
var svg = document.querySelector("svg");


var paths = svg.querySelectorAll("path");

console.log(paths.length);



function hoverEffect (eleman,activeClass) {
    eleman.forEach((e) => {
        console.log(e);
        e.onmouseover = (event) => eleman.forEach((event) => event.classList.add(activeClass));
        e.onmouseout = (event) => eleman.forEach((event) => event.classList.remove(activeClass));
    });
    }


    hoverEffect(document.querySelectorAll(".head"),"active");

    hoverEffect(document.querySelectorAll(".solkol"),"active");

    hoverEffect(document.querySelectorAll(".sagkol"),"active");

    hoverEffect(document.querySelectorAll(".hand"),"active");

    hoverEffect(document.querySelectorAll(".gogus"),"active");

    hoverEffect(document.querySelectorAll(".karin"),"active");

    hoverEffect(document.querySelectorAll(".sagbacak"),"active");

    hoverEffect(document.querySelectorAll(".solbacak"),"active");

    hoverEffect(document.querySelectorAll(".diz"),"active");

    hoverEffect(document.querySelectorAll(".foot"),"active");