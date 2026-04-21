var urlap=document.getElementById("urlap");
var minErtek=document.getElementById("minErtek");
var maxErtek=document.getElementById("maxErtek");
var ment=document.getElementById("ment");
var ujra=document.getElementById("ujra");
var  osszeAd=document.getElementById("osszeAd");
var kartyaTarolo=document.getElementById("kartyaTarolo");
var eredeti=[];
var eredetiVissza=[];
var osszeg=0;

function KartyaLetrehoz(){
    osszeAd.innerText=osszeg;
    kartyaTarolo.innerHTML="";
    for(var i=0;i<eredeti.length;i++){
        var kartya=document.createElement('div');
        kartya.className="kartyaDb";
        kartya.draggable=true;
        kartya.innerText=eredeti[i];
        kartya.addEventListener('dragstart', function(event){
            event.dataTransfer.setData("text",event.target.innerText);
        })
        kartyaTarolo.appendChild(kartya);
    }
}

urlap.addEventListener("submit", function(event){
    event.preventDefault();
    eredeti=[];
    osszeg=0;
    var min=Number(minErtek.value);
    var max=Number(maxErtek.value);
    if(min>max){
        alert("A min érteék nem lehet nagyobb a max értéknél!");
        return;
    }
    for(var i=0;i<10;i++){
        var random=Math.floor(Math.random()*(max-min+1))+min;
        eredeti.push(random);
    }
    eredetiVissza=eredeti.slice();
    KartyaLetrehoz();
})

osszeAd.addEventListener("dragover", function(event){
    event.preventDefault();
})

osszeAd.addEventListener("drop",function(event){
    event.preventDefault();
    var aadat=event.dataTransfer.getData("text");
    var szam=Number(aadat);
    var index=eredeti.indexOf(szam);
    if(index!==-1){
        eredeti.splice(index, 1)
    }
    osszeg+=szam;
    KartyaLetrehoz();
})

ujra.addEventListener("click", function(){
    if(!confirm("Biztos újra kezdi?")){
        return;
    }
    eredeti=eredetiVissza.slice();
    osszeg=0;
    KartyaLetrehoz();
})