$(function(){

    const kepTomb=[{link:"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSsc7pewmtNIfZAzruKJQQWYlqhYpdnCJHrJw&s", szoveg:"sütit néző kutya"}, 
        {link:"https://nyuszis.kepek1.hu/kep/nyuszis-kepek_20.jpg",szoveg:"rönkön ülő nyuszi"},
        {link:"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTpjQdKWIA0MQe9IbrLZ6RUtDNrlRNAkBmsiA&s",szoveg:"kicsi kacsa"}];

        
    const $kepekTarolo=$("#kepekTarolo");
    const $nagyAblak=$('#nagyAblak').hide();
    const $nkAblak=$('#nkAblak');
    const $kepDoboz=$('<div>').addClass("kepDoboz");

function Epit(){
    for(let i=0;i<kepTomb.length;i++){
        const $kep=$('<img>').addClass('kepek')
        .attr('src',kepTomb[i].link)
        .attr('alt', kepTomb[i].szoveg);
        
        $kepekTarolo.append($kep);
        
        $kep.on('click', function(){ 
            $nkAblak.empty();
            const $nagyKep=$('<img>').addClass('nagyKep')
            .attr('src',kepTomb[i].link)
            .attr('alt', kepTomb[i].szoveg);
            const $szoveg=$('<p>').addClass('sz').text(kepTomb[i].szoveg);
            const $x=$('<button>').addClass('x').text('X');    
            $kepDoboz.append($nagyKep,$x);
            $nkAblak.append($kepDoboz,$szoveg );
            $nagyAblak.append($nkAblak);
            $nagyAblak.fadeIn(300);

            $x.on('click', function(){
                $nagyAblak.fadeOut(300, function(){
                    $nagyAblak.hide();
                    $nkAblak.empty();
                });
            })
        })
    }
}

Epit();
});