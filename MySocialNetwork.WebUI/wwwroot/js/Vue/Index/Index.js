var httpRequest = new XMLHttpRequest;
const AppIndex = {
    data() {
        return {
            postViewModel: {
                subtitle: "",
                images: []
            },
            postsViewModel: [],
            loggedUser: {}
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

        getLoggedUser() {
            var thisvue = this;
            const url = "/User/GetLogged";
            $.ajax({
                type: "get",
                url: url,
                success: function (resp) {
                    thisvue.loggedUser = resp;
                }
            });
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
        comment(postId) {
            const thisvue = this;
            $.ajax({
                type: "post",
                data: JSON.stringify($(`#text-comment-${postId}`).val()),
                contentType: "application/json",
                url: "/post/comment/" + postId,
                success: function (resp) {
                    $(`#text-comment-${postId}`).val("");
                    thisvue.getPosts();
                }
            });
        },

        likedByThisUser(post) {
            var liked = post.likes.find(x => x.userId == this.loggedUser.id && x.isLiked) == null ? false : true;

            return liked;
        },

        getQtyPostLikes(post) {
            return post.likes.reduce((acc, cur) => acc += (cur.isLiked ? 1 : 0), 0);
        },
        showDivToComment(idx) {
            $(".div-comment").addClass("d-none")

            $("#div-comment-" + idx).removeClass("d-none");
        }
    },
    created() {
        this.getLoggedUser();
        this.getPosts();
    },
    mounted() {
    },
    watch: {}
};
Vue.createApp(AppIndex).mount("#ViewIndex");
