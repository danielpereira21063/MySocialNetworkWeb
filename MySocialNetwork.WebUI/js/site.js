const loadImage = function (event) {
    var input = event.target;
    var reader = new FileReader();
    reader.onload = () => {
        var dataUrl = reader.result;
        var output = document.getElementById('imgFile-1');
        output.classList.remove("d-none");
        output.src = dataUrl;
    };
    reader.readAsDataURL(input.files[0]);
};

const _base64ToArrayBuffer = (base64) => {
    var binary_string = window.atob(base64);
    var len = binary_string.length;
    var bytes = new Uint8Array(len);
    for (var i = 0; i < len; i++) {
        bytes[i] = binary_string.charCodeAt(i);
    }
    return bytes.buffer;
};

const loadDefaultPostImage = (element) => {
    element.src = "/img/post-image-default.png";
    element.onerror = null;
};

const baseUrl = "/social-network";

const links = document.querySelectorAll("a");


links.forEach(x => {
    var link = x.href;

    linksArray = link.split("/");

    link = "";

    linksArray.forEach((txt, idx) => {
        if (idx > 2) {
            link += txt;
        }
    });

    if (link.length == 0 && link.includes(baseUrl)) {
        return;
    }

    x.href = `${baseUrl}/${link}`;
});