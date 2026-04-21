var urlap = document.getElementById('urlap');
var minErtek = document.getElementById('min');
var maxErtek = document.getElementById('max');
var kartyaTarolo = document.getElementById('kartyaTarolo');
var osszeAdo = document.getElementById('osszeAd');
var ujraGomb = document.getElementById('ujra');
var eredeti = [];
var alap = [];
var osszeg = 0;
urlap.addEventListener('submit', function (event) {
    event.preventDefault();
    var min = Number(minErtek.value);
    var max = Number(maxErtek.value);
    if (min > max) {
        alert("A min nem lehet nagyobb mint a max");
        return;
    }
    eredeti = [];
    osszeg = 0;
    osszeAdo.innerText = 0;
    kartyaTarolo.innerHTML = "";
    for (var i = 0; i < 10; i++) {
        var random = Math.floor(Math.random() * (max - min + 1)) + min;
        eredeti.push(random);
    }
    alap = eredeti.slice();
    for (var i = 0; i < eredeti.length; i++) {
        var kartya = document.createElement("div");
        kartya.className = "kartyaDb";
        kartya.draggable = true;
        kartya.innerText = eredeti[i];
        kartya.addEventListener("dragstart", function (event) {
            event.dataTransfer.setData("text", event.target.innerText);
        });
        kartyaTarolo.appendChild(kartya);
    }
});

osszeAdo.addEventListener("dragover", function (event) {
    event.preventDefault();
});

osszeAdo.addEventListener("drop", function (event) {
    event.preventDefault();
    var adat = event.dataTransfer.getData("text");
    var szam = Number(adat);
    var index = eredeti.indexOf(szam);
    if (index !== -1) {
        eredeti.splice(index, 1);
    }
    osszeg += szam;
    osszeAdo.innerText = osszeg;
    kartyaTarolo.innerHTML = "";
    for (var i = 0; i < eredeti.length; i++) {
        var kartya = document.createElement("div");
        kartya.className = "kartyaDb";
        kartya.draggable = true;
        kartya.innerText = eredeti[i];
        kartya.addEventListener("dragstart", function (event) {
            event.dataTransfer.setData("text", event.target.innerText);
        });
        kartyaTarolo.appendChild(kartya);
    }
});

ujraGomb.addEventListener("click", function () {
    if (!confirm("Biztos újra kezded?")) {
        return;
    }
    eredeti = alap.slice();
    osszeg = 0;
    osszeAdo.innerText = 0;
    kartyaTarolo.innerHTML = "";
    for (var i = 0; i < eredeti.length; i++) {
        var kartya = document.createElement("div");
        kartya.className = "kartyaDb";
        kartya.draggable = true;
        kartya.innerText = eredeti[i];
        kartya.addEventListener("dragstart", function (event) {
            event.dataTransfer.setData("text", event.target.innerText);
        });
        kartyaTarolo.appendChild(kartya);
    }
});