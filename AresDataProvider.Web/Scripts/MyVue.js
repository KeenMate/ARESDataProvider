var router = new VueRouter({
	routes: [
		{
			path: '/ico/:TaxId',
			component: {
				template: '<div class="ui segments" id="basicDataTable"> ' +
					'<div class="ui segment"> ' +
					'<p class="ui three columns grid"> ' +
					'<strong class="ui column">@Index_cshtml.BasicData</strong> ' +
					'<strong class="ui column">@Index_cshtml.PlaceOfEvidence <a v-on:click="SearchTaxId(responseBasic.TaxId)">{{responseBasic.PlaceOfEvidence}}</a></strong> ' +
					'<strong class="ui column"><a v-on:click="SearchByTaxIdInES(responseBasic.TaxId)">@Index_cshtml.EconomicSubject</a></strong> ' +
					'</p> ' +
					'</div> ' +
					'<div class="ui two columns divided grid segment"> ' +
					'<div class="ui column"> ' +
					'<p> ' +
					'<strong>@Index_cshtml.TaxID</strong> {{responseBasic.TaxId}} ' +
					'</p> ' +
					'</div> ' +
					'<div class="ui column"> ' +
					'<p> ' +
					'<strong>@Index_cshtml.CompanyName</strong> {{responseBasic.Name}} ' +
					'</p> ' +
					'</div> ' +
					'</div> ' +
					'<div class="ui segment"> ' +
					'<p> ' +
					'<strong>@Index_cshtml.AddressInfos</strong> ' +
					'</p> ' +
					'<div class="ui segments"> ' +
					'<div class="ui segment"> ' +
					'<p> ' +
					'<strong>@Index_cshtml.Country/@Index_cshtml.CountryCode </strong> {{responseBasic.Address.Country}}/{{responseBasic.Address.CountryCode}} ' +
					'</p> ' +
					'</div> ' +
					'<div class="ui five columns grid segment"> ' +
					'<div class="ui column"> ' +
					'<p> ' +
					'<strong>@Index_cshtml.City </strong> {{responseBasic.Address.City}} ' +
					'</p> ' +
					'</div> ' +
					'<div class="ui column"> ' +
					'<p> ' +
					'<strong>@Index_cshtml.DistrictName </strong> {{responseBasic.Address.DistrictName}} ' +
					'</p> ' +
					'</div> ' +
					'<div class="ui column"> ' +
					'<p> ' +
					'<strong>@Index_cshtml.CityPartName </strong> {{responseBasic.Address.CityPartName}} ' +
					'</p> ' +
					'</div> ' +
					'<div class="ui column"> ' +
					'<p> ' +
					'<strong>@Index_cshtml.Street </strong> {{responseBasic.Address.Street}} ' +
					'</p> ' +
					'</div> ' +
					'<div class="ui column"> ' +
					'<p> ' +
					'<strong>@Index_cshtml.ZipCode </strong> {{responseBasic.Address.ZipCode}} ' +
					'</p> ' +
					'</div> ' +
					'</div> ' +
					'<div class="ui four columns grid segment"> ' +
					'<p class="ui column"> ' +
					'<strong>@Index_cshtml.HouseNumber </strong> {{responseBasic.Address.HouseNumber}} ' +
					'</p> ' +
					'<p class="ui column"> ' +
					'<strong>@Index_cshtml.OrientationNumber </strong> {{responseBasic.Address.OrientationNumber}} ' +
					'</p> ' +
					'<p class="ui column"> ' +
					'<strong>@Index_cshtml.AddressCode </strong> {{responseBasic.Address.AddressCode}} ' +
					'</p> ' +
					'<p class="ui column"> ' +
					'<strong>@Index_cshtml.ObjectCode </strong> {{responseBasic.Address.ObjectCode}} ' +
					'</p> ' +
					'</div> ' +
					'</div> ' +
					'</div> ' +
					'<div class="ui segments"> ' +
					'<div class="ui segment"> ' +
					'<p> ' +
					'<strong>@Index_cshtml.ScopeOfBusiness </strong> ' +
					'</p> ' +
					'</div> ' +
					'<div class="ui segment" v-for="item in responseBasic.ScopeOfBusiness"> ' +
					'<p>{{item}}</p> ' +
					'</div> ' +
					'</div> ' +
					'</div>',	
				watch: {
					'$route': function (to, from) {
						if ((to.fullpath === from.fullpath) && (to.params.TaxId.length === 8 && !isNaN(to.params.TaxId))) {
							this.SearchByTaxIdInBasic(to.params.TaxId);
						}
					}
				},
				data() {
					return {
						responseBasic: {
							Address: {}
						},
						cache: {}
					}
				},
				methods: {
					SearchByTaxIdInBasic: function (taxId) {
						if (!isNaN(taxId) && taxId.length === 8 && this.cache[taxId] == undefined) {
							var self = this;
							this.$emit('isRequesting', true);
							this.$parent.SendRequestTo("/api/searchbas/searchbytaxid?taxid=" + taxId)
								.then(function (response) {
									this.$emit('isRequesting', false);
									self.responseBasic = response.body;
									self.cache[taxId] = response.body;
									this.$emit('isLoading', false);
								});
						}
						else if (this.cache[taxId] != undefined) {
							this.responseBasic = this.cache[this.userInput];
						}
					}
				},
				mounted() {
					this.SearchByTaxIdInBasic(this.$route.params.TaxId);
					console.log(this.responseBasic);
				}
			}
		}
	]
});

var myVue = new Vue({
	el: "#vueApp",
	router: router,
	data: {
		urlForTaxId: "",
		userInput: "Hello mother fucker",
		requestTime: 0,
		cityInput: "",
		responseOr: {
			Address: {}
		},
		responseEs: {},
		responseRzp: {
			Address: {}
		},
		cityVisible: false,
		isRequesting: false,
		cache: {
			es: {},
			or: {},
			rzp: {}
		},
		isLoading: false
	},
	methods: {
		SendRequestTo: function (url) {
			this.isLoading = true;
			return this.$http.get(url);
		},
		HideEveryResult: function () {
			$("#error").css("display", "none");
			$("#companySearch").css("display", "none");
			$("#registryData").css("display", "none");
			$("#basicDataTable").css("display", "none");
			$("#rzpData").css("display", "none");
			this.requestTime = 0;
		},
		SearchByTaxIdInES: function (taxId) {
			if ((this.userInput.length === 8 && !isNaN(Number(this.userInput)) && this.cache.es[this.userInput] == undefined) || taxId != undefined) {
				console.log("user input is possibly a tax id");
				this.cityVisible = false;
				var self = this;
				this.isRequesting = true;
				this.SendRequestTo("/api/searches/by?taxid=" + (taxId == undefined ? this.userInput : taxId))
					.then(function (response) {
						self.isLoading = false;
						self.isRequesting = false;
						self.responseEs = response.body;
						self.cache.es[this.userInput] = response.body;
						if (self.responseEs.Errors != null) {
							console.log("responseEs contains Errors. Showing #error");
							this.HideEveryResult();
							$("#error").css("display", "block");
						} else {
							console.log("responseEs does not contain errors, showing results");
							this.HideEveryResult();
							self.requestTime = self.responseEs.TimeTaken;
							$("#companySearch").css("display", "block");
						}
					});
				console.log("request sequence ended");
			}
			else if (this.cache.es[this.userInput] != undefined) {
				console.log("tax id is cached.");
				this.responseEs = this.cache.es[this.userInput];
				if (this.responseEs.Errors != null) {
					console.log("responseEs contains Errors. Showing #error");
					this.HideEveryResult();
					$("#error").css("display", "block");
				} else {
					console.log("responseEs does not contain errors, showing results");
					this.HideEveryResult();
					$("#companySearch").css("display", "block");
				}
			}
		},
		PreSearch: function () {
			if (!isNaN(Number(this.userInput))) {
				if (this.userInput.length !== 8)
					alert("Tax ID's length must be 8");
				else {
					$('#city').css("display", "none");
					router.push('/ico/' + this.userInput)
				}
			}
			else if (this.userInput.length !== 0) {
				this.SendRequestTo("/api/searches/by?name=" + this.userInput)
					.then(function (response) {
						if (response.body.ItemsFound !== 0) {
							this.cityVisible = false;
							self.HideEveryResult();
							self.requestTime = self.responseEs.TimeTaken;
							$("#companySearch").css("display", "block");
							self.responseEs = response.body;
							self.cache.es[this.userInput + "&" + this.cityInput] = self.responseEs;
							self.requestTime = self.responseEs.TimeTaken;
							this.isLoading = false;
							return true;
						} else {
							this.HideEveryResult();
							this.cityVisible = true;
							this.isLoading = false;
							return false;
						}
					});
			}
		},
		SearchByNameAndCityInES: function () {
			if (this.cityInput !== "" && this.userInput !== "" && this.cache.es[this.userInput + "&" + this.cityInput] == undefined && this.isRequesting === false) {
				console.log("city and name isnt empty, making request. (" + this.cityInput + " " + this.userInput + ")");
				$("#loader").css("display", "block");
				var self = this;
				this.isRequesting = true;
				this.SendRequestTo("/api/searches/by?name=" + this.userInput + "&city=" + this.cityInput)
					.then(function (response) {
						self.isRequesting = false;
						self.responseEs = response.body;
						self.cache.es[this.userInput + "&" + this.cityInput] = self.responseEs;
						if (self.responseEs.Errors != null) {
							console.log("responseEs contains Errors. Showing #error");
							this.HideEveryResult();
							$("#error").css("display", "block");
						} else {
							console.log("responseEs does not contain errors, showing results");
							this.HideEveryResult();
							self.requestTime = self.responseEs.TimeTaken;
							$("#companySearch").css("display", "block");
						}
						this.isLoading = false;
					});
				$("#loader").css("display", "none");
				console.log("request sequence ended");
				console.log("Request took - " + this.responseEs.Time);
			}
			else if (this.cache.es[this.userInput + "&" + this.cityInput] != undefined) {
				this.responseEs = this.cache.es[this.userInput + "&" + this.cityInput];
				if (this.responseEs.Errors != null) {
					console.log("responseEs contains Errors. Showing #error");
					this.HideEveryResult();
					$("#error").css("display", "block");
				} else {
					console.log("responseEs does not contain errors, showing results");
					this.HideEveryResult();
					$("#companySearch").css("display", "block");
				}
			}
		},
		SearchTaxId: function (taxId) {
			var self = this;
			if (taxId.length === 8 && !isNaN(Number(taxId))) {
				this.isRequesting = true;
				this.SendRequestTo("/api/searchbas/searchbytaxid?taxid=" + taxId)
					.then(function (basicResponse) {
						self.isRequesting = false;
						self.responseBasic = basicResponse.body;
						self.cache.basic[taxId] = basicResponse.body;

						if (this.responseBasic.PlaceOfEvidence != undefined) {
							self.isRequesting = true;
							this.SendRequestTo("/api/search" + this.responseBasic.PlaceOfEvidence + "/searchbytaxid?taxid=" + taxId)
								.then(function (response) {
									self.isRequesting = false;
									switch (this.responseBasic.PlaceOfEvidence) {
										case "OR":
											self.responseOr = response.body;
											self.cache.or[taxId] = response.body;
											if (this.responseOr.Error != null) {
												console.log("responseOr contains Error. Showing #error");
												this.HideEveryResult();
												$("#error").css("display", "block");
											} else {
												console.log("responseOr does not contain error, showing results");
												this.HideEveryResult();
												self.requestTime = self.responseOr.TimeTaken;
												$("#registryData").css("display", "block");
											}
											break;
										case "RZP":
											self.responseRzp = response.body;
											self.cache.rzp[taxId] = response.body;
											if (this.responseRzp.Errors != null) {
												console.log("responseRzp contains Error. Showing #error");
												this.HideEveryResult();
												$("#error").css("display", "block");
											} else {
												console.log("responseRzp does not contain errors, showing results");
												this.HideEveryResult();
												self.requestTime = self.responseRzp.TimeTaken;
												$("#rzpData").css("display", "block");
											}
											break;
										default:
											console.log("Error: Place of evidence is invalid: " + this.responseBasic.PlaceOfEvidence);
											break;
									}
								});
						}
						this.isLoading = false;
					});
			}
		}
	},
	created() {
		this.$on('isLoading', function (value) {
			this.isLoading = value;
		});
		this.$on('isRequesting', function (value) {
			this.isLoading = value;
		});
	}
});