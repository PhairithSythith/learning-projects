var urlap=document.getElementById("urlap");
var minErtek=document.getElementById("minErtek");
var maxErtek=document.getElementById("maxErtek");
var submit=document.getElementById("submit");
var osszeAd=document.getElementById("osszeAd");
var ujra=document.getElementById("ujra");
var kartyaTarolo=document.getElementById("kartyaTarolo");
var eredeti=[];
var visszaEredeti=[];
var osszeg=0;

function KartyaLetrehoz(){
    osszeAd.innerText=osszeg;
    kartyaTarolo.innerHTML="";
    for(let i=0;i<eredeti.length;i++){
        var kartya=document.createElement('div');
        kartya.className="kartyaDb";
        kartya.draggable=true;
        kartya.innerText=eredeti[i];
        kartya.addEventListener("dragstart", function(event){
            event.dataTransfer.setData("text",event.target.innerText);
        })
        kartyaTarolo.appendChild(kartya);
    }
}

urlap.addEventListener("submit", function(event){
    event.preventDefault();
    var min=Number(minErtek.value);
    var max=Number(maxErtek.value);
    eredeti=[];
    osszeg=0;
    if(min>max){
        alert("A min érték nem lehet nagyobb mint a max érték!");
        return;
    }
    for(let i=0;i<10;i++){
        var random=Math.floor(Math.random()*(max-min+1))+min;
        eredeti.push(random);
    }
    visszaEredeti=eredeti.slice();
    KartyaLetrehoz();
})

osszeAd.addEventListener("dragover", function(event){
    event.preventDefault();
})

osszeAd.addEventListener("drop", function(event){
    event.preventDefault();
    var adat=event.dataTransfer.getData("text");
    var szam=Number(adat);
    var index=eredeti.indexOf(szam);
    if(index!==-1){
        eredeti.splice(index,1);
    }
    osszeg+=szam;
    KartyaLetrehoz();
})

ujra.addEventListener("click", function(){
    if(!confirm("Biztos újra kezded?")){
        return;
    }
    eredeti=visszaEredeti.slice();
    osszeg=0;
    KartyaLetrehoz();
})