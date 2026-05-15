$(function(){

    const $lista=$('#lista');
    const $urlap= $('#urlap');

    $urlap.hide();

    $lista.nextAll('button').first().on('click', function() {
        $urlap.slideToggle(500);
    })
/*
    $('li').on('click'), function(){
        $(this).toggleClass('selected');
    }*/
   $lista.on('click', 'li', function($event){
        $($event.target).toggleClass('selected');
   })

    $urlap.on('submit', function($event){
        $event.preventDefault();
        let $szoveg =$(this).find('input').filter('[type=text]').first().val().trim();
        if($szoveg ==''){
            return;}
        const $li=$('<li></li>')
        $lista.append($li);
        $li.text($szoveg).hide().slideDown(500);
        $(this).find('input[type=text]:first-of-type').val('');
    })

    $lista.nextAll('button').eq(1).on('click', function(){
        $(this)
        .siblings('ul')
        .first()
        .children()
        .filter('.selected')
        .slideUp(500, function(){
            $(this).remove();
        });
    })

});

/*
    to-do lista:
    űrlap: feladat: ...mező... aztán gomb
        !amit mentünk az bekerül a listába
    toDO lista:
    -elem
    -elem.... <- animáltan nyíljon lefelé
      !az elemeket lehessen kijelölni és legyen
      egy olyan gomb hogy kész és töröl, a töröl törli a készek pedig
      kerüljenek egy kész listába ami kap egy új valamilyen stílust !

*/