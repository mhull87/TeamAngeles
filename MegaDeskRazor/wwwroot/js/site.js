// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var width = document.getElementById("width").innerHTML;
var depth = document.getElementById("depth").innerHTML;
var calc = document.getElementById("depth").onkeyup(CalculateArea(width, depth));
document.getElementById("area").value = calc;

function CalculateArea(width, depth)
    {
        area = width * depth;
        return area;
    }