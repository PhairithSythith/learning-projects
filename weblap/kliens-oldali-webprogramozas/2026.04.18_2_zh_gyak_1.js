const tesztKerdesek=[
    {kerdes:"ez egy kerdes", helyesValasz:"helyes válasz",pontszam:2},
    {kerdes:"ez egy masik kerdes", helyesValasz:"masik helyes válasz",pontszam:4},
    {kerdes:"ez egy megint masik kerdes", helyesValasz:"megint masik helyes válasz",pontszam:6}
];
var uresAblak;
var szamlalo;
var randomKerdesKap;
function ellenoriz(){
    const beirt = uresAblak.document.getElementById('ideIr').value;
    const jo = randomKerdesKap.helyesValasz;
    if(beirt === jo){
        uresAblak.close();
        document.body.innerHTML += "Helyes";
    } else {
        uresAblak.close();
        document.body.innerHTML += "Helytelen";
    }
}
document.getElementById("kerdesKap").addEventListener('click', function(){
    randomKerdesKap = tesztKerdesek[Math.floor(Math.random()*tesztKerdesek.length)];
    uresAblak = window.open('','ures','height=400px,width=400px');
    uresAblak.document.open();
    uresAblak.document.write('<html><head></head><body>');
    uresAblak.document.write(
        "<div id='kerdes'>" +
        "<p>Kérdés: " + randomKerdesKap.kerdes + "</p>" +
        "<p>Max pont: " + randomKerdesKap.pontszam + "</p>" +
        "<label for='ideIr'>Válasz:</label>" +
        "<input type='text' id='ideIr'>" +
        "<button type='button' id='kuldes'>Küld</button>" +
        "</div>"
    );
    uresAblak.document.write('</body></html>');
    uresAblak.document.close();
    szamlalo = setTimeout(ellenoriz, 5000);
    const gomb = uresAblak.document.getElementById('kuldes');
    gomb.addEventListener('click', function(){
        clearTimeout(szamlalo);
        ellenoriz();
    });
});