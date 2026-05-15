$(function(){

    const $faTomb={
        nev:"gerinces",
        gyerekek:[{
            nev:"hal",
            gyerekek:[{
                nev:"ponty",
                gyerekek:[]
            },{
                nev:"harcsa",
                gyerekek:[]
            }]},{
            nev:"madar",
            gyerekek:[{
                nev:"pinty",
                gyerekek:[]
            },{
                nev:"sas",
                gyerekek:[]
            }]},{
            nev:"emlős", 
            gyerekek:[{
                nev:"farkas", 
                gyerekek:[]
            },{
                nev:"tigris",
                gyerekek:[]
            },{
                nev:"elefánt",
                gyerekek:[]
            }]
        }]
    }
    const $fa=$('#fa');

    function Epit(e){
    const $elem = $('<div>').addClass('lista');
    const $szoveg = $('<span>').text(e.nev);
    const $gyerekTarolo = $("<div>").addClass("gyerekek");
    for(let i = 0; i < e.gyerekek.length; i++){
        $gyerekTarolo.append(Epit(e.gyerekek[i]));
    }
    if(e.gyerekek.length > 0){
        const $gomb = $('<button>').addClass("gomb").text('+');
        $gomb.on('click', function(){
            $gyerekTarolo.slideToggle(200);
            if($gomb.text() === "+"){
                $gomb.text('-');
            } else {
                $gomb.text('+');
            }
        });
        $elem.append($gomb);
    }
    $elem.append($szoveg, $gyerekTarolo);
    return $elem;
    }
    $fa.append(Epit($faTomb));
});
    

 /*   $(".toggle").on("click", function(){
        const $gyerekek = $(this).parent().find("> .gyerekek");

        $gyerekek.slideToggle(200);

        if ($(this).text() === "+") {
            $(this).text("-");
        } else {
            $(this).text("+");
        }
    });
*/
