var kerdesTomb=[{kerdes:"kerdes?", valasz:"valassz", pont:2},
    {kerdes:"kerdes 2?", valasz:"valassz 2", pont:4},
    {kerdes:"kerdes 3?", valasz:"valassz 3", pont:6}
];

var uresAblak;
var szamlalo;
var randomKerdes;
var kerdesFeltesz=document.getElementById('kerdesFeltesz');

function Ellenoriz(){
    var beirt=uresAblak.document.getElementById('beirt').value;
    var valaszJo=randomKerdes.valasz;
    if(valaszJo===beirt)
    {uresAblak.close();
        document.body.innerHTML+=`Helyes válasz! Ennyi pontot ért a kérdés:${randomKerdes.pont}`
    }
    else if(valaszJo!==beirt)
    {
        uresAblak.close();
        document.body.innerHTML+=`Helytelen válasz! Ennyi pontot ért volna a kérdés:${randomKerdes.pont}`
    }
}
kerdesFeltesz.addEventListener('click', function(){
    randomKerdes=kerdesTomb[Math.floor(Math.random()*kerdesTomb.length)];
    uresAblak=window.open('', 'height=400px, width=400px');
    uresAblak.document.open();
    uresAblak.document.write(`<html><head></head><body>`
        +`<div id="kerdesEgesz">`
        +`<p>${randomKerdes.kerdes}</p>`
        +`<p>${randomKerdes.pont}</p>`
        +`<label for="beirt">Válasz:</label>`
        +`<input id="beirt" name="beirt" type="text">`
        +`<button id="ment" type="button">Ment</button>`
        +`</div>`
        +`</body></html>`);
    uresAblak.document.close();
    szamlalo=setTimeout(Ellenoriz, 5000);
    var ment=uresAblak.document.getElementById("ment");
    ment.addEventListener('click',function(){
        clearTimeout(szamlalo);
        Ellenoriz();
    })
})

