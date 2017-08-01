var myVue = new Vue({
	el: "#vueApp",
	data: {
		urlForTaxId: "",
		userInput: "",
		cityInput: "",
		responseOr: {
			Address: {}
		},
		responseEs: {},
		responseBasic: {
			Address: {}
		},
		responseRzp: {
			Address: {}
		},
		cache: {
			es: {},
			basic: {},
			or: {},
			rzp: {}
		}
	},
	watch: {
		userInput: function (newVal) {
			this.userInput = newVal;
			if (isNaN(Number(newVal)) && $("#city").css("display") !== "inline") {
				console.log("making city input visible");
				$("#city").css("display", "inline");
			} else if (newVal === "") {
				this.HideEveryResult();
				this.city = "";
			} else if (!isNaN(Number(newVal)) && newVal.length === 8) {
				this.SearchByTaxIdInES();
				this.SearchByTaxIdInBasic();
				this.HideEveryResult();
				$("#companySearch").css("display", "block");
				$("#basicDataTable").css("display", "block");
			}
		},
		cityInput: _.debounce(function (newVal) {
			this.cityInput = newVal;
			this.SearchByNameAndCityInES();
		},
			500)
	},
	methods: {
		SendRequestTo: function (url) {
			return this.$http.get(url);
		},
		HideEveryResult: function () {
			$("#error").css("display", "none");
			$("#companySearch").css("display", "none");
			$("#registryData").css("display", "none");
			$("#basicDataTable").css("display", "none");
			$("#city").css("display", "none");
			$("#rzpData").css("display", "none");
		},
		SearchByTaxIdInBasic: _.debounce(function (taxId) {
			if ((this.userInput.length === 8 && !isNaN(Number(this.userInput)) && this.cache.basic[this.userInput] == undefined) || taxId != undefined) {
				console.log("user input is possibly a tax id");
				$("#city").css("display", "none");
				var self = this;
				this.SendRequestTo("/api/searchbas/searchbytaxid?taxid=" + (taxId == undefined ? this.userInput : taxId))
					.then(function (response) {
						console.log("this in .then fnc: " + this);
						self.responseBasic = response.body;
						self.cache.basic[this.userInput] = response.body;
						if (self.responseBasic.Error != null) {
							console.log("responseBasic contains Errors. Showing #error");
							this.HideEveryResult();
							$("#error").css("display", "block");
						} else {
							console.log("responseBasic does not contain errors, showing results");
							this.HideEveryResult();
							$("#basicDataTable").css("display", "block");
						}
					});
				console.log("request sequence ended");
			}
			else if (this.cache.basic[this.userInput] != undefined) {
				console.log("tax id is cached.");
				this.responseBasic = this.cache.basic[this.userInput];
				if (this.responseBasic.Error != null) {
					console.log("responseBasic contains Errors. Showing #error");
					this.HideEveryResult();
					$("#error").css("display", "block");
				} else {
					console.log("responseBasic does not contain errors, showing results");
					this.HideEveryResult();
					$("#basicDataTable").css("display", "block");
				}
			}
		}, 1250),
		SearchByTaxIdInES: _.debounce(function (taxId) {
			if ((this.userInput.length === 8 && !isNaN(Number(this.userInput)) && this.cache.es[this.userInput] == undefined) || taxId != undefined) {
				console.log("user input is possibly a tax id");
				$("#city").css("display", "none");
				var self = this;
				this.SendRequestTo("/api/searches/by?taxid=" + (taxId == undefined ? this.userInput : taxId))
					.then(function (response) {
						self.responseEs = response.body;
						self.cache.es[this.userInput] = response.body;
						if (self.responseEs.Errors != null) {
							console.log("responseEs contains Errors. Showing #error");
							this.HideEveryResult();
							$("#error").css("display", "block");
						} else {
							console.log("responseEs does not contain errors, showing results");
							this.HideEveryResult();
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
		}, 1250),
		SearchByNameAndCityInES: _.debounce(function () {
			if (this.cityInput !== "" && this.userInput !== "" && this.cache.es[this.userInput + "&" + this.cityInput] == undefined) {
				console.log("city and name isnt empty, making request. (" + this.cityInput + " " + this.userInput + ")");
				$("#loader").css("display", "block");
				var self = this;
				this.SendRequestTo("/api/searches/by?name=" + this.userInput + "&city=" + this.cityInput)
					.then(function (response) {
						self.responseEs = response.body;
						self.cache.es[this.userInput + "&" + this.cityInput] = self.responseEs;
						if (self.responseEs.Errors != null) {
							console.log("responseEs contains Errors. Showing #error");
							this.HideEveryResult();
							$("#error").css("display", "block");
						} else {
							console.log("responseEs does not contain errors, showing results");
							this.HideEveryResult();
							$("#companySearch").css("display", "block");
						}
						console.log("Request took - " + self.responseEs.Time);
					});
				$("#loader").css("display", "none");
				console.log("request sequence ended");
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
		}, 1250),
		InstantSearchByNameAndCityInES: function () {
			console.log("Enter pressed, searching instantly");
			if (this.cityInput !== "" && this.userInput !== "" && this.cache.es[this.userInput + "&" + this.cityInput] == undefined) {
				console.log("city and name isnt empty, making request. (" + this.cityInput + " " + this.userInput + ")");
				$("#loader").css("display", "block");
				var self = this;
				this.SendRequestTo("/api/searches/by?name=" + this.userInput + "&city=" + this.cityInput)
					.then(function (response) {
						self.responseEs = response.body;
						self.cache.es[this.userInput + "&" + this.cityInput] = self.responseEs;
						if (self.responseEs.Errors != null) {
							console.log("responseEs contains Errors. Showing #error");
							this.HideEveryResult();
							$("#error").css("display", "block");
						} else {
							console.log("responseEs does not contain errors, showing results");
							this.HideEveryResult();
							$("#companySearch").css("display", "block");
						}
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
				this.SendRequestTo("/api/searchbas/searchbytaxid?taxid=" + taxId)
					.then(function (basicResponse) {
						self.responseBasic = basicResponse.body;
						self.cache.basic[taxId] = basicResponse.body;

						if (this.responseBasic.PlaceOfEvidence != undefined) {
							this.SendRequestTo("/api/search" + this.responseBasic.PlaceOfEvidence + "/searchbytaxid?taxid=" + taxId)
								.then(function (response) {
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
												$("#rzpData").css("display", "block");
											}
											break;
										default:
											console.log("Error: Place of evidence is invalid: " + this.responseBasic.PlaceOfEvidence);
											break;
									}
								});
						}
					});
			}
		}
	}
})