$(function(){

function htmlEPitese(){

    const kepTarolo=[
        {
            link:"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSsc7pewmtNIfZAzruKJQQWYlqhYpdnCJHrJw&s",
            szoveg:"sütit néző kutya"
        },
        {
            link:"https://nyuszis.kepek1.hu/kep/nyuszis-kepek_20.jpg",
            szoveg:"rönkön ülő nyuszi"
        },
        {
            link:"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTpjQdKWIA0MQe9IbrLZ6RUtDNrlRNAkBmsiA&s",
            szoveg:"kicsi kacsa"
        }
    ];

    for(let i=0;i<kepTarolo.length;i++){

        const $img=$('<img>')
        .attr('src',kepTarolo[i].link)
        .attr('alt',kepTarolo[i].szoveg);

        const $kepekTarolo=$('<div>')
        .addClass('kepek');

        $kepekTarolo.append($img);
        $('body').append($kepekTarolo);

        $img.on('click', function(){

            const $hatter=$('<div>')
            .attr('id','hatter')
            .hide();

            const $Nagykep=$('<img>')
            .attr('src',kepTarolo[i].link);

            const $leiras=$('<p>')
            .text(kepTarolo[i].szoveg);

            const $bezaras=$('<button>')
            .text('X');

            const $NagyKepAblak=$('<div>')
            .attr('id','nkAblak')
            .hide()
            .append($bezaras, $Nagykep, $leiras);

            $('body').append($hatter, $NagyKepAblak);

            $hatter.fadeIn(300);
            $NagyKepAblak.fadeIn(300);

            $bezaras.on('click', function(){
                $hatter.fadeOut(200, ()=> $hatter.remove());
                $NagyKepAblak.fadeOut(200, ()=> $NagyKepAblak.remove());
            });

        });

    }
}

htmlEPitese();

});