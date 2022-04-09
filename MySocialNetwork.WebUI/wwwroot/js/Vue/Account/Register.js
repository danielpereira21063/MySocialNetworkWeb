const appRegister = {
    data() {
        return {
            addresses: {
                states: [],
                cities: []
            },

            genres: []
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

            if (!uf) return;

            $.ajax({
                type: "get",
                url: "https://servicodados.ibge.gov.br/api/v1/localidades/estados/" + uf + "/municipios",
                success: function (resp) {
                    thisvue.addresses.cities = resp;
                }
            });
        },

        getGenres() {
            var thisvue = this;

            $.ajax({
                type: "get",
                url: "/Account/GetAllGenres",
                success: function (resp) {
                    thisvue.genres = resp;
                }
            });
        },
    },

    created() {
        this.getStates();
        this.getGenres();
    }
}

Vue.createApp(appRegister).mount("#viewRegister");