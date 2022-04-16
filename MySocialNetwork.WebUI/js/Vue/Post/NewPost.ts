var httpRequest = new XMLHttpRequest;

const AppNewPost: any = {
    data() {
        return {
            PostViewModel: {
                Subtitle: "",
                Images: []
            }
        }
    },

    methods: {
        postPost() {

            const formats = ["jpg", "jpeg", "png"];
            let images = document.querySelectorAll(".post-images") as NodeListOf<HTMLImageElement>;

            images.forEach((img, idx) => {
                formats.forEach((format) => {
                    if (img.src.includes(`data:image/${format};`) && img.src != img.src[idx - 1]) {
                        var src: string = img.src.replace(`data:image/${format};`, "");
                        this.PostViewModel.Images.push({
                            file: src
                        });
                    }
                })
            });

            const url = "/post/create";

            httpRequest.open("POST", url);
            httpRequest.setRequestHeader("Content-Type", "application/json;charset=UTF-8");

            httpRequest.onreadystatechange = () => {
                if (httpRequest.readyState == XMLHttpRequest.DONE && httpRequest.status == 200) {
                    console.log(httpRequest.responseText);
                }
            };


            var data = JSON.stringify(this.PostViewModel);
            httpRequest.send(data);

        }
    },

    mounted() {
    },

    watch: {

    }
}

Vue.createApp(AppNewPost).mount("#modalNewPost");