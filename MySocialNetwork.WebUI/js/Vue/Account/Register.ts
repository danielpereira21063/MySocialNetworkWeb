var httpRequest = new XMLHttpRequest;
const AppRegister: any = {
    data() {
        return {
            Addresses: {
                States: [],
                Cities: []
            }
        }
    },

    methods: {
        getStates() {
            const thisvue = this;
            const url = "https://servicodados.ibge.gov.br/api/v1/localidades/estados/";

            httpRequest.open("GET", url);

            httpRequest.onreadystatechange = () => {
                if (httpRequest.readyState == 4 && httpRequest.status == 200) {
                    let response = JSON.parse(httpRequest.responseText);
                    thisvue.Addresses.States = response;
                }
            }

            httpRequest.send();
        },
    },

    mounted() {
        //this.getStates();
    },

    watch: {
    }
}

Vue.createApp(AppRegister).mount("#viewRegister");