/*Készítse el a következő webalkalmazás jQuery felhasználásával!
 Törekedjen a jQuery eszközeinek a hatékony használatára!

Készítsen egy GYIK (Gyakran ismételt Kérdések) tömböt, 
amiben kérdéseket lehet átrolni úgy, hogy egy kérdést egy objektum ír
 le a kérdés szövegével és a válasszal! Tegyen a tömbbe legalább 3 kérdést!
Az oldal betöltődésekor jelenítse meg a kérdéseket úgy, hogy minden kérdésű
 alatt legyen a hozzá tartozó válasz, de nem látható módon. A kérdés előtt
  legyen egy + (plusz) jel. Ha a felhasználó a jelre klikkel, akkor 
  animáltan nyissa le a választ a kérdés alatt, illetve a + jel váltson 
  - (mínusz) jelre. Ha a - jelre klikkel, csukódjon be a válasz és a jel
   váltson vissza + jelre!

Készítsen egy "Új kérdés" gombot, amire klikkelve animáltam 
jelenítsen meg egy űrlapot, amiben meg lehet adni a kérdés és a 
válasz szövegét! Az űrlap mentésekor mentse a tömbbe a megadott kérdést 
illetve jelenítse meg az oldalon a kérdéslista végén!

Kikötések

    Nem használhatja a html() függvényt!
    Csak üres html elemet hozhat létre, azaz se attribútuma, se tartalma
     nem lehet, ezeket a létrehozás után kell hozzáadnia!

Maximális pontszám 20 pont */
$(function(){

    const $gyikKerdesek=[{kerdes:"kerdes1",valasz:"valasz1"},
        {kerdes:"kerdes2", valasz:"valasz2"},{
            kerdes:"kerdes3", valasz:"valasz3"
        }];

        const $urlap=$('#urlap');
        $urlap.hide();
        const $ment=$('#submit');
        const $ujKerdes=$('#ujbtn');
        
        const $nagyTarolo=$('<div>').addClass('nTarolo');
        
    function Epit(){
        $gyikKerdesek.forEach(gy =>{
            const $kerdesGombTarolo=$('<div>').addClass('kgTarolo');
            const $valaszTarolo=$('<div>').addClass('vTarolo');
            const $tarolo=$('<div>').addClass('tarolo');
            
            const $gomb=$('<button>').addClass('gomb').text('+');
            const $kerdes=$('<div>').addClass('kerdes').text(gy.kerdes);
            const $valasz=$('<div>').addClass('valasz').text(gy.valasz).hide();
            $kerdesGombTarolo.append($kerdes,$gomb);
            $valaszTarolo.append($valasz);
            $tarolo.append($kerdesGombTarolo,$valaszTarolo);
            
            
            $nagyTarolo.append($tarolo);

            $gomb.on('click', function(){
                if($gomb.text()==='+'){
                    $gomb.text('-');
                }
                else{$gomb.text('+');}
                $valasz.slideToggle(300);
            })
        });
    }
    
            $ujKerdes.on('click', function(){
                $urlap.slideToggle(300);
            })

            $ment.on('click', function(e){
                e.preventDefault();
                const $Ujkerdesek=$('.kds').val();
                const $Ujvalaszok=$('.vlsz').val();

                $gyikKerdesek.push({kerdes: $Ujkerdesek, valasz: $Ujvalaszok});
                Epit();
                $Ujkerdesek.val('');
                $Ujvalaszok.val('');
            })
    $('body').append($nagyTarolo);


    Epit();
});