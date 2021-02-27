// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//var width = document.getElementById("width").innerHTML;
//var depth = document.getElementById("depth").innerHTML;
//var calc = document.getElementById("depth").onkeyup(CalculateArea(width, depth));
//document.getElementById("area").value = calc;

function CalculateArea(width, depth)
{
        area = width * depth;
        return area;
}

// To add images to dropbox materials --------------------------------
window.onload = function () {
    const routes = ["/Quotes/Edit", "/Quotes/Create"];
    const pathUrl = window.location.pathname;
    
    if (routes.includes(pathUrl)) {
        console.log(pathUrl);
        addImages();
    } 
}
//window.onload = addImages();

function addImages() {
    const newURL = window.location.protocol + "//" + window.location.host + "/";
    const materialSelect = document.querySelector('.materialSelect');
    const options = materialSelect.options;

    for (let i = 0; i < options.length; i++) {
        let name = options[i].value;
        let src = `${newURL}lib/images/${name}.jpg`;
        //console.log(src);
        options[i].setAttribute("data-left" ,src);
    }
    $('.materialSelect').selectator();
}
// ----------------------------------------------------------



