const appRegister = {
    data() {
        return {
            addresses: {
                states: [],
                cities: []
            }
        }
    },

    methods: {
        getStates() {
            var thisvue = this;

            $.ajax({
                type: "get",
                url: "https://servicodados.ibge.gov.br/api/v1/localidades/estados/",
                success: function (resp) {
                    thisvue.addresses.states = resp;
                    console.log(resp)
                }
            });
        },

        getCities() {
            var thisvue = this;
            var uf = $("#selectState :selected").val();

            $.ajax({
                type: "get",
                url: "https://servicodados.ibge.gov.br/api/v1/localidades/estados/" + uf + "/municipios",
                success: function (resp) {
                    thisvue.addresses.cities = resp;
                }
            });
        }
    },

    created() {
        this.getStates();
    }
}

Vue.createApp(appRegister).mount("#viewRegister");