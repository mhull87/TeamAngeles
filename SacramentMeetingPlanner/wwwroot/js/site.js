// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var speakerhead = document.getElementById("speakerhead");
var speaker = document.getElementById("speaker");
var topichead = document.getElementById("topichead");
var topic = document.getElementById("topic");

document.getElementById("searchspeaker").onclick = showSpeaker;
document.getElementById("topicsearch").onclick = showTopic;

function showSpeaker() {
    speakerhead.classList.remove("hidden");
    speaker.classList.remove("hidden");
}

function hideSpeaker() {
    speakerhead.classList.add("hidden");
    speaker.classList.add("hidden");
}

function showTopic() {
    topichead.classList.remove("hidden");
    topic.classList.remove("hidden");
}

function hideTopic() {
    topichead.classList.add("hidden");
    topic.classList.add("hidden");
}