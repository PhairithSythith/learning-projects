var urlap=document.getElementById('urlap');
var minErtek=document.getElementById('minErtek');
var maxErtek=document.getElementById('maxErtek');
var kartyaTarolo=document.getElementById('kartyaTarolo');
var osszeAd=document.getElementById('osszeAd');
var ujra=document.getElementById('ujra');
var eredeti=[];
var visszaTolt=[];
var osszeg=0;

function kartyaLetrehoz(){
    
    osszeAd.innerText=osszeg;
    kartyaTarolo.innerHTML="" ;
    for(var i=0;i<eredeti.length;i++){
        var kartya=document.createElement('div');
        kartya.className="kartya";
        kartya.draggable=true;
        kartya.innerText=eredeti[i];
        kartya.addEventListener('dragstart', function(event){
            event.dataTransfer.setData("text", event.target.innerText);
        })
        kartyaTarolo.appendChild(kartya);
    }
}

urlap.addEventListener('submit',function(event){
    event.preventDefault();
    var min=Number(minErtek.value);
    var max=Number(maxErtek.value);
    if(min>max){
        alert("A min érték nem lehet nagyobb a max értéknél");
        return;
    }
    eredeti=[];
    osszeg=0;
    for(var i=0;i<10;i++){
        var random=Math.floor(Math.random()*(max-min+1))+min;
        eredeti.push(random);
    }
    visszaTolt=eredeti.slice();
    kartyaLetrehoz();
})

osszeAd.addEventListener('dragover', function(event){
    event.preventDefault();
})

osszeAd.addEventListener('drop', function(event){
    event.preventDefault();
    var adata= event.dataTransfer.getData("text");
    var szam=Number(adata);
    var index=eredeti.indexOf(szam);
    if(index!==-1)
    {
        eredeti.splice(index, 1);
    }
    osszeg+=szam;
    kartyaLetrehoz();
})

ujra.addEventListener('click', function(){
    if(!confirm("Biztos újra kezdi?")){
        return;
    }
    eredeti=visszaTolt.slice();
    osszeg=0;
    kartyaLetrehoz();
})