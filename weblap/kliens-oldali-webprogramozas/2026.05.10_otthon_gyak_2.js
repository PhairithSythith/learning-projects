$(function(){
const adatTarolo=[{link:"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSd4wFarQURnRyZAAM5JdOiXuU1SPTmGLPLww&s", szoveg:"Cuki fekvő foltos malac"},
    {link:"https://i.pinimg.com/236x/4b/3c/57/4b3c57fa528418cd5f696ab57d4a8e9e.jpg", szoveg:"Cuki boci nyelvjútva"},
    {link:"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSWC2peqAzIXEub4x4vVLQT0CNKgH_D_dBADQ&s", szoveg:"Cuki nyuszi nyújtott nyelvvel"},
    {link:"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRY2I4zQlEec1drGz6xDKjJgNwrIw_9-yIRZQ&s", szoveg:"Cuki nyuszi fürdés közben"},
    {link:"https://img-9gag-fun.9cache.com/photo/adPPEAN_460s.jpg", szoveg:"Cuki nyuszi ül a fűben"},
    {link:"https://i.pinimg.com/236x/c9/0b/72/c90b72c658a37cf72068b4279188a678.jpg", szoveg:"Cuki kecske ugrás közben"},
    {link:"https://i.ytimg.com/vi/9krVutgCLMc/maxresdefault.jpg", szoveg:"Cuki kecske labdázik"},
    {link:"https://i.pinimg.com/236x/9b/57/b1/9b57b1a525f463787ad09953d15f2168.jpg", szoveg:"Cuki kecske nyelvét nyújtva"},
    {link:"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQmCmLQlS4QWynz26Cq6z4DWrz_LJyjv-Dekg&s", szoveg:"Cuki foltos malac fagyit eszik"},
    {link:"https://assets.4cdn.hu/kraken/74MVoLkW3gRhCuCus.jpeg", szoveg:"Cuki boci hóban játszik"},
    {link:"https://assets.4cdn.hu/kraken/74MVpMh7YqvyCu8cs.jpeg", szoveg:"Cuki boci pihen"},
    {link:"https://bopci.cafeblog.hu/files/2016/02/Cute-Pig-Pictures-29.jpg", szoveg:"Cuki fogott malac napszemüvegben"}
];
   function htmlEpit() {

        for (let i = 0; i < adatTarolo.length; i++) {

            const $kepTarolo = $('<div>')
                .addClass('kepek');

            const $kep = $('<img>');

            $kep.attr('src', adatTarolo[i].link);
            $kep.attr('alt', adatTarolo[i].szoveg);

            $kep.on('click', function () {

                const $hatter = $('<div>')
                    .attr('id', 'hatter')
                    .hide();

                const $nagykep = $('<img>')
                    .attr('src', adatTarolo[i].link);

                const $leiras = $('<p>')
                    .text(adatTarolo[i].szoveg);

                const $bezarGomb = $('<button>')
                    .attr('id', 'bezarGomb')
                    .text('X');

                const $nagykepAblak = $('<div>')
                    .attr('id', 'nagykepAblak')
                    .hide();

                $nagykepAblak.append(
                    $bezarGomb,
                    $nagykep,
                    $leiras
                );

                $('body').append(
                    $hatter,
                    $nagykepAblak
                );

                $hatter.fadeIn(300);
                $nagykepAblak.fadeIn(300);

                $bezarGomb.on('click', function () {

                    $nagykepAblak.fadeOut(300, function () {
                        $nagykepAblak.remove();
                    });

                    $hatter.fadeOut(300, function () {
                        $hatter.remove();
                    });

                });

            });

            const $szovegTarolo = $('<div>')
                .addClass('szoveg')
                .text(adatTarolo[i].szoveg);

            $kepTarolo.append(
                $kep,
                $szovegTarolo
            );

            $('body').append($kepTarolo);
        }
    }

    htmlEpit();

});