/*$ (document).ready(...) *//*jQuery szimbóluma és ha az oldal betöltődött akkor fusson le*/
/* vagy így is lehet írni: $(()=>{...}) */
/*vagy így és ez a legjobb: */
$(function(){
    console.log($('#focim').text()); /*document.getElementById('focim').innerText*/
    $('#alc').html('<u>Előnyei</u>'); /*innerHtml*/

    $('li').css('font-family', 'Courier');

    $('li').css({
        'background-color':'grey',
        'color':'orange',
        'font-size':'1.5em'
    });

    $('li').addClass('listElem');

    $('ul > li:first-of-type').attr('title','Egyszerre több elemre hivatkozás');

    $('li').click(function(){
        $(this).toggleClass('select');
    });

    $('li').on({
        mouseenter: function(){
            $('#nagyito').stop('true','true').fadeIn(100).text($(this).text());
        },
        mouseleave: function(){
            $('#nagyito').stop('true','true').fadeOut(200, function(){
                $(this).hide().text("");
            });
        },
        dblclick: function(){
            $(this).animate({
                opacity: 0.3,
                marginLeft: '20px'
            }, 500);
        }
    });

    //ált a változó neveket $ jellel kezdjük jQueryben
    var $jQueryValtozo=1;
    console.log($jQueryValtozo);
});

//Házi feladat!!!! CooSpace