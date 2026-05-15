$(function(){

    const fa={
        nev:"Gerinces",
        gyerekek:[{
            nev:"Hal",
            gyerekek:[{
                nev: "Ponty", gyerekek:[]},
                {nev: "Harcsa", gyerekek:[]
            }]},{
            nev:"Madár",
            gyerekek:[{
                nev:"Pinty", gyerekek:[]},
                {nev:"Sas", gyerekek:[]
            }]},{
            nev:"Emlős",
            gyerekek:[{
                nev:"Farkas", gyerekek:[]},
                {nev:"Tigris", gyerekek:[]},
                {nev:"Elefánt", gyerekek:[]}]
            }]
        };

    function  faMutatas(csucs){
        const $sor=$('<div>').addClass('sor');
        const $gomb=$('<button>');
        if(csucs.gyerekek.length>0){
            $gomb.text('+');
        }
        else{
            $gomb.hide();
        }
        const $kiirtNev=$('<span>')
        .text(csucs.nev);

        const $gyerekTarolo=$('<div>').hide();

        for(let i=0;i<csucs.gyerekek.length;i++){
            $gyerekTarolo.append(
            faMutatas(csucs.gyerekek[i]))
        };

        $gomb.on('click', function(){
            if($gyerekTarolo.is(':hidden')){
            $gyerekTarolo.show();
            $gomb.text('-');}
            else {
                $gyerekTarolo.hide();
                $gomb.text('+');
            }
        });
        $sor.append($gomb, $kiirtNev, $gyerekTarolo)
        return $sor;
    };

    $('body').append(faMutatas(fa));
});
