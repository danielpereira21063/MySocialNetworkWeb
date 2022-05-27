var httpRequest = new XMLHttpRequest;
const AppIndex = {
    data() {
        return {
            postViewModel: {
                subtitle: "",
                images: []
            },
            postsViewModel: []
        };
    },
    methods: {
        postPost() {
            this.postViewModel.images = [];
            const formats = ["jpg", "jpeg", "png"];
            let images = document.querySelectorAll(".post-images");
            images.forEach((img, idx) => {
                formats.forEach((format) => {
                    let base64Info = `data:image/${format};base64,`;
                    if (img.src.includes(base64Info) && img.src != img.src[idx - 1]) {
                        let src = img.src.replace(base64Info, "");
                        this.postViewModel.images.push({
                            file: src
                        });
                    }
                });
            });
            const url = "/post/create";
            httpRequest.open("POST", url);
            httpRequest.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
            var data = JSON.stringify(this.postViewModel);
            httpRequest.send(data);
            httpRequest.onreadystatechange = () => {
                if (httpRequest.readyState == XMLHttpRequest.DONE && httpRequest.status == 200) {
                    $("#postSuccess").removeClass("d-none");
                    $("#modalNewPost").modal("hide");
                    $("#post-images").each(() => {
                        $(this).src = "";
                    });
                    this.getPosts();
                }
            };
        },
        getPosts() {
            const url = "/post/getAll";
            httpRequest.open("GET", url);
            httpRequest.onreadystatechange = () => {
                if (httpRequest.readyState == XMLHttpRequest.DONE && httpRequest.status == 200) {
                    var response = JSON.parse(httpRequest.responseText);
                    this.postsViewModel = response;
                    console.log(response);
                }
            };
            httpRequest.send();
        },

        like(postId) {
            const url = "/post/like/" + postId;
            httpRequest.open("PUT", url);
            httpRequest.onreadystatechange = () => {
                if (httpRequest.readyState == XMLHttpRequest.DONE && httpRequest.status == 200) {
                    this.getPosts();
                }
            }
            httpRequest.send();
        },

        likedByThisUser(post) {
            var liked = post.likes.find(x => x.userId == post.userId) == null ? false : true;
            console.log(post)
            return liked;
        }
    },
    created() {
        this.getPosts();
    },
    mounted() {
    },
    watch: {}
};
Vue.createApp(AppIndex).mount("#ViewIndex");
