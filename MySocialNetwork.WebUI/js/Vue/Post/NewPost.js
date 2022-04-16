var httpRequest = new XMLHttpRequest;
const AppNewPost = {
    data() {
        return {
            PostViewModel: {
                Subtitle: "",
                Images: []
            }
        };
    },
    methods: {
        postPost() {
            this.PostViewModel.Images = [];
            const formats = ["jpg", "jpeg", "png"];
            let images = document.querySelectorAll(".post-images");
            images.forEach((img, idx) => {
                formats.forEach((format) => {
                    let base64Info = `data:image/${format};base64,`;
                    if (img.src.includes(base64Info) && img.src != img.src[idx - 1]) {
                        let src = img.src.replace(base64Info, "");
                        this.PostViewModel.Images.push({
                            file: src
                        });
                    }
                });
            });
            const url = "/post/create";
            httpRequest.open("POST", url);
            httpRequest.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
            httpRequest.onreadystatechange = () => {
                console.log(httpRequest);
            };
            var data = JSON.stringify(this.PostViewModel);
            httpRequest.send(data);
        }
    },
    mounted() {
    },
    watch: {}
};
Vue.createApp(AppNewPost).mount("#modalNewPost");
