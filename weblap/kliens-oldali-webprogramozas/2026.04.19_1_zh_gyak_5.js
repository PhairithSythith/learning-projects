var urlap=document.getElementById("urlap");
var minErtek=document.getElementById("minErtek");
var maxErtek=document.getElementById("maxErtek");
var ujra=document.getElementById("ujra");
var ment=document.getElementById("ment");
var osszAd=document.getElementById("osszAd");
var kartyaTarolo=document.getElementById("kartyaTarolo");
var eredeti=[];
var visszaEredeti=[];
var osszeg=0;

function kartyaLetrehoz(){
    osszAd.innerText=osszeg;
    kartyaTarolo.innerHTML="";
    for(var i=0;i<eredeti.length;i++){
        var kartya=document.createElement('div');
        kartya.className='kartyak';
        kartya.draggable=true;
        kartya.innerText=eredeti[i];
        kartya.addEventListener('dragstart',function(event){
            event.dataTransfer.setData("text",event.target.innerText);
        })
        kartyaTarolo.appendChild(kartya);
    }
}

urlap.addEventListener("submit", function(event){
    event.preventDefault();
    var min= Number(minErtek.value);
    var max=Number(maxErtek.value);
    if(min>max){
        alert("A min érték nem lehet nagyobb mint a max érték!");
        return;
    }
    eredeti=[];
    osszeg=0;
    for(var i=0;i<10;i++){
        var random=Math.floor(Math.random()*(max-min+1))+min;
        eredeti.push(random);
    }
    visszaEredeti=eredeti.slice();
    kartyaLetrehoz();
})

osszAd.addEventListener('dragover', function(event){
    event.preventDefault();
})

osszAd.addEventListener('drop',function(event){
    event.preventDefault();
    var adat=event.dataTransfer.getData("text");
    var szam=Number(adat);
    var index=eredeti.indexOf(szam);
    if(index!==-1){
        eredeti.splice(index, 1);
    }
    osszeg+=szam;
    kartyaLetrehoz();
})
ujra.addEventListener('click',function(){
    if(!confirm("Biztos újra kezded?")){
        return;
    }
    eredeti=visszaEredeti.slice();
    osszeg=0;
    kartyaLetrehoz();
})