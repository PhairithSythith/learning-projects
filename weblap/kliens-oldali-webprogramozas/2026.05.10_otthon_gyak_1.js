$(function(){

    const $body=$('body');

    const $mezok=$('<div>');
    $mezok.attr("id","mezok");
    $body.append($mezok);

    const $uj=$('<div>');
    $uj.attr('id','uj');
    $body.append($uj);

    let $mostInput =$('<input>');
    $mostInput.attr('type','text');
    $mostInput.attr('id','nev');

    const $gomb=$('<button>');
    $gomb.attr('id','ujNev');
    $gomb.text('Új név');

    $uj.append($mostInput); $uj.append($gomb);

    $gomb.on('click', function(){
        const $ujInput=$('<input>'); 
        $ujInput.val($mostInput.val());
        $ujInput.attr('readonly','readonly');
        $mostInput.val('');

        const $torol=$('<button>');
        $torol.attr('class','torol');
        $torol.text('Töröl');

        const $ujDiv=$('<div>');
        $ujDiv.attr('class','ujDiv');
        $ujDiv.hide();
        $ujDiv.append($ujInput,$torol);
        $mezok.append($ujDiv);
        $ujDiv.slideDown(300);

        $torol.on('click', function(){
            $ujDiv.slideUp(300, function(){
                $ujDiv.remove();
            })
        })
    });

});