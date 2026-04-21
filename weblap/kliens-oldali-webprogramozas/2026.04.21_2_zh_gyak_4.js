var kerdesTomb=[{kerdes:"kerdes", valasz:"valasz", pont:3},
    {kerdes:"kerdes 2", valasz:"valasz 2", pont:4},
    {kerdes:"kerdes 3", valasz:"valasz 3", pont:5},];

var kerdesKer=document.getElementById("kerdesKer");
var uresAblak;
var szamlalo;
var randomKerdes;

function Ellenoriz(){
    var beirt=uresAblak.document.getElementById("beirt");
    var jo=randomKerdes.valasz;
    if(beirt===jo){
        uresAblak.close();
        document.body.innerHTML+=`Helyes válasz! ${randomKerdes.pont} pontot kaptál!`;
    }
    else if(beirt!==jo){
        uresAblak.close();
        document.body.innerHTML+=`Helytelen válasz! ${randomKerdes.pont} pontot kaptál volna!`;
    }
}

kerdesKer.addEventListener("click",function(){
    randomKerdes=kerdesTomb[Math.floor(Math.random()*kerdesTomb.length)];
    uresAblak=window.open('','height=400px, width=400px');
    uresAblak.document.open();
    uresAblak.document.write(`<html><head></head><body>`
        +`<div id="kerdesEgesz">`
        +`<p id="kerdes">Kérdés: ${randomKerdes.kerdes}</p>`
        +`<p id="kerdes">Pont: ${randomKerdes.pont}</p>`
        +`<label for="beirt">Ide írd a választ:</label>`
        +`<input type="text" id="beirt" name="beirt" required>`
        +`<button id="ment" type="button">Ment</button>`
        +`</div>`
        +`</body></html>`);
        uresAblak.document.close();
        szamlalo=setTimeout(Ellenoriz, 5000);
        var ment=uresAblak.document.getElementById("ment");
        ment.addEventListener("click", function(){
            clearTimeout(szamlalo);
            Ellenoriz();
        })
})