var myVue = new Vue({
	el: '#vueApp',
	data: {
		urlForTaxId: '',
		userInput: '',
		cityInput: '',
		registryResponse: {
			Address: {}
		},
		searchResponse: {}
	},
	watch: {
		userInput: function (newVal) {
			this.userInput = newVal;
			if (isNaN(Number(newVal))) {
				console.log('making city input visible');
				$('#city').css('display', 'inline');
			} else if (newVal === '') {
				$('#error').css('display', 'none');
				$('#companySearch').css('display', 'none');
				$('#result').css('display', 'none');
				$('#city').css('display', 'none');
			} else {
				this.UpdateUserInput();
			}
		},
		cityInput: function (newVal) {
			this.cityInput = newVal;
			this.SearchByNameAndCity();
		}
	},
	methods: {
		SendRequestTo: function (url) {
			return this.$http.get(url);
		},
		UpdateUserInput: _.debounce(function () {
			if (this.userInput.length === 8 && !isNaN(Number(this.userInput)) && this.userInput !== '') {
				console.log('user input is possibly a tax id');
				$('#city').css('display', 'none');
				this.SendRequestTo('/api/companyregistry/by?taxid=' + this.userInput + '&extended=true')
					.then(function (registryResponse) {
						this.registryResponse = registryResponse.body;
						if (this.registryResponse.Error != null) {
							console.log('Error in registryResponse isnt null. Error should appear.');
							$('#error').css('display', 'block');
							$('#companySearch').css('display', 'none');
							$('#result').css('display', 'none');
						} else {
							console.log('registryResponse does not contain errors, Showing #result');
							$('#error').css('display', 'none');
							$('#companySearch').css('display', 'none');
							$('#result').css('display', 'block');
						}
					});
				console.log('request sequence ended');
			}
		}, 1250),
		SearchByNameAndCity: _.debounce(function () {
			if (this.cityInput !== '' && this.userInput !== '') {
				console.log('city and name isnt empty, making request. (' + this.cityInput + ' ' + this.userInput + ')');
				this.SendRequestTo('/api/search/by?name=' + this.userInput + '&city=' + this.cityInput)
					.then(function (registryResponse) {
						this.searchResponse = registryResponse.body;
						if (this.searchResponse.Errors != null) {
							console.log('registryResponse contains Errors. Showing #error');
							$('#error').css('display', 'block');
							$('#companySearch').css('display', 'none');
							$('#result').css('display', 'none');
						} else {
							console.log('registryResponse does not contain errors, showing results');
							$('#error').css('display', 'none');
							$('#companySearch').css('display', 'block');
							$('#result').css('display', 'none');
						}
					});
				console.log('request sequence ended');
			}
		}, 1250),
		SearchTaxId: function (taxId) {
			this.userInput = taxId;
		}
	}
})