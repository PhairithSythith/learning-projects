$(function(){

    const $inputNev = $('<input>')
        .addClass('nevBe')
        .attr('type','text');

    const $gomb = $('<button>')
        .attr('id','gomb')
        .text('Új név');

    const $nagyTarolo = $('<div>').addClass('nagyTarolo');

    const $tarolo = $('<div>').attr('id','tarolo');

    $nagyTarolo.append($tarolo);

    $('body').append($inputNev, $gomb, $nagyTarolo);

    $gomb.on('click', function(){

        const $sor = $('<div>').addClass('sor').hide();

        const $beirt = $('<input>')
            .addClass('mentett')
            .attr('type','text')
            .val($inputNev.val())
            .attr('readonly','readonly');

        const $torolBtn = $('<button>')
            .addClass('torol')
            .text('Töröl');

        $torolBtn.on('click', function(){
            $sor.slideUp(300, function(){
                $sor.remove();
            });
        });

        $sor.append($beirt, $torolBtn);
        $sor.fadeIn(400);

        $tarolo.append($sor);

        $inputNev.val('');

    });

});