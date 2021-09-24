"use strict";

const $ = selector => document.querySelector(selector);

const getErrorMsg = lbl => `${lbl} must be a valid number greater than zero.`;

const focusAndSelect = selector => {
    const elem = $(selector);
    elem.focus();
    elem.select();
};

const processEntries = () => {
    const miles = parseFloat($("#miles").value);
    const gallons = parseFloat($("#gallons").value);

    if (isNaN(miles) || miles <= 0) {
        alert(getErrorMsg("Miles driven"));
        focusAndSelect("#miles");
    } else if (isNaN(gallons) || gallons <= 0) {
        alert(getErrorMsg("Gallons of gas used"));
        focusAndSelect("#gallons");
    } else {
        $("#mpg").value = (miles / gallons).toFixed(2);
    }
};

var clearEntries = () => {
    $("#miles").value = "";
    $("#gallons").value = "";
    $("#mpg").value = "";
};

var clearMiles = () => {
    $("#miles").value = "";
}

var clearGallons = () => {
    $("#gallons").value = "";
}

document.addEventListener("DOMContentLoaded", () => {
    // calculates miles per gallon
    $("#calculate").addEventListener("click", processEntries);

    // clears entries when double-click MPG text box
    $("#mpg").addEventListener("dblclick", clearEntries);

    // clear miles on focus
    $("#miles").addEventListener("focus", clearMiles);

    // clear gallons on focus
    $("#gallons").addEventListener("focus", clearGallons);

    // calculates on gallons blur
    $("#gallons").addEventListener("blur", processEntries);
});