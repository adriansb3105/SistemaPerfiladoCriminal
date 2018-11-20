hideShowDivs(1, "block");
hideShowDivs(2, "none");
hideShowDivs(3, "none");
hideShowDivs(4, "none");
document.querySelector("#victima-page-1-li").addEventListener("click", () => {
    hideShowDivs(1, "block");
    hideShowDivs(2, "none");
    hideShowDivs(3, "none");
    hideShowDivs(4, "none");
});
document.querySelector("#victima-page-2-li").addEventListener("click", () => {
    hideShowDivs(1, "none");
    hideShowDivs(2, "block");
    hideShowDivs(3, "none");
    hideShowDivs(4, "none");
});
document.querySelector("#victima-page-3-li").addEventListener("click", () => {
    hideShowDivs(1, "none");
    hideShowDivs(2, "none");
    hideShowDivs(3, "block");
    hideShowDivs(4, "none");
});
document.querySelector("#victima-page-4-li").addEventListener("click", () => {
    hideShowDivs(1, "none");
    hideShowDivs(2, "none");
    hideShowDivs(3, "none");
    hideShowDivs(4, "block");
});
function hideShowDivs(id, action) {
    document.querySelector("#victima-" + id).style.display = action;
}
