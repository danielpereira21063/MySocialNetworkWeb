const loadImage = function (event) {
    var input = event.target;
    var reader = new FileReader();
    console.log(event);
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
