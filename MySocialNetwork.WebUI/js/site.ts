const loadImage = function (event) {
    var input = event.target;
    var reader = new FileReader();

    console.log(event)

    reader.onload = () => {
        var dataUrl = reader.result;
        var output = document.getElementById('imgFile-1') as HTMLFormElement;
        output.classList.remove("d-none");
        output.src = dataUrl;
    }
    reader.readAsDataURL(input.files[0]);
}