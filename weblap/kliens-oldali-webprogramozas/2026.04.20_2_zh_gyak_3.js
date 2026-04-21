var kerdesKap=document.getElementById("kerdesKap");

var kerdesTomb=[{kerdes:"kerdes",valasz:"valasz",pont:3},
    {kerdes:"kerdes2",valasz:"valasz2",pont:6},
    {kerdes:"kerdes3",valasz:"valasz3",pont:9}
];

var uresAblak;
var idozito;
var randomKerdesKap;

function Ellenoriz(){
    var beirt=uresAblak.document.getElementById("beirt");
    var joValasz=randomKerdesKap.valasz;
    if(beirt===joValasz){
        uresAblak.close();
        document.body.innerHTML+=`Helyes válasz! A kérdés ${randomKerdesKap.pont} pontot ért!`;
    }
    else if(beirt!==joValasz){
        uresAblak.close();
        document.body.innerHTML+=`Helytelen válasz! A kérdés ${randomKerdesKap.pont} pontot ért volna!`;
    }
}

kerdesKap.addEventListener("click", function(){
    randomKerdesKap=kerdesTomb[Math.floor(Math.random()*kerdesTomb.length)];
    uresAblak=window.open('','height=400px, width=400px');
    uresAblak.document.open();
    uresAblak.document.write(`<html><head></head><body>`
        +`<div id="kerdesEgybe>`
        +`<p>Kérdés: ${randomKerdesKap.kerdes}</p>`
        +`<p>Ennyi pontot ért: ${randomKerdesKap.pont}</p>`
        +`<label for="beirt">Válasz:</label>`
        +`<input id="beirt" name="beirt" type="text">`
        +`<button id="ment" type="button">Ment</button>`
        +`</div>`
        +`</body></html>`
    );
    uresAblak.document.close();
    idozito=setTimeout(Ellenoriz(), 5000);
    var ment=uresAblak.document.getElementById("ment");
    ment.addEventListener("click", function(){
        clearTimeout(idozito);
        Ellenoriz();
    })
})