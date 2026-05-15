
/* to-do lista: űrlap: Új teendő: [...mező...] Hozzáad gomb 
!amit mentünk az bekerül a todod listába
 toDO lista: -elem -elem.... <- animáltan nyíljon lefelé 
 !az elemeket lehessen kijelölni és legyen egy olyan gomb 
 hogy kész és töröl, a töröl törli teljesen a készek pedig 
 kerüljenek egy kész listába ami kap egy új valamilyen stílust ! */


$(function(){

    const $urlap = $('#urlap');
    const $nincsKeszLista = $('#nincsKezs');
    const $KeszLista = $('#Kezs');
    const $input = $urlap.find('input[type=text]');
    $nincsKeszLista.hide();
    $KeszLista.hide();

    $urlap.on('submit', function(event){
        event.preventDefault();
        $nincsKeszLista.show();
        let teendo = $input.val().trim();
        if(teendo === '') return;
        const $li = $('<li></li>')
            .text(teendo)
            .hide();
        $nincsKeszLista.append($li);
        $li.slideDown(300);
        $input.val('');
    });
    $nincsKeszLista.on('click', 'li', function(){
        $(this).toggleClass('selected');
    });
    $('#torol').on('click', function(){
        $nincsKeszLista.find('.selected').remove();
    });
    $('#kesz').on('click', function(){
        $KeszLista.show();
        $nincsKeszLista.find('.selected')
            .removeClass('selected')
            .hide()
            .appendTo($KeszLista)
            .slideDown(300);
    });

});