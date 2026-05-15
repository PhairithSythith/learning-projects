var lista=document.getElementById("lista");
var urlap=document.getElementById("urlap");
var szoveg=document.getElementById("szoveg");
var sorrend=document.getElementById("sorrend");
var ment=document.getElementById("ment");
var szovegTomb=[];
var minta=/^[a-zA-Z0-9][" "a-zA-z0-9][a-zA-z0-9]{3,}/;
function Listazas(){
        lista.innerHTML="";
    for(let i=0;i<szovegTomb.length;i++){
        var li= document.createElement('li');
        li.innerText+=szovegTomb[i];
        lista.appendChild(li);
    }
}
urlap.addEventListener("submit", function(event){
    event.preventDefault();
    if(minta.test(szoveg.value)){
        szovegTomb.push(szoveg.value);
    SorRend();
    Listazas();}
    else{ 
        alert("Nem megfelelő suöveg bevitel!");
        return;
    }
    szoveg.value="";
});
function SorRend(){
    if(sorrend.value==="nov"){
        szovegTomb.sort();
    }
    else{
        szovegTomb.sort(); 
        szovegTomb.reverse();
    }
}
sorrend.addEventListener("change", function(){
    SorRend();
    Listazas();
});