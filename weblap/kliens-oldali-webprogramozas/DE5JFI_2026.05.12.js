$(function () {

    const kerdesekTomb = [
        { kerdes: "kerdes1", valasz: "valasz1" },
        { kerdes: "kerdes2", valasz: "valasz2" },
        { kerdes: "kerdes3", valasz: "valasz3" }
    ];

    const $nTarolo = $('<div>').attr('id', 'nTarolo');
    $('body').append($nTarolo);

    function Epit() {
        $nTarolo.empty();

        for (let i = 0; i < kerdesekTomb.length; i++) {
            const adat = kerdesekTomb[i];
            const $elem = $('<div>').addClass('elem');
            const $gomb = $('<button>')
                .addClass('gomb')
                .text('+');
            const $kerdes = $('<div>')
                .addClass('kerdes')
                .text(adat.kerdes);
            const $valasz = $('<div>')
                .addClass('valasz')
                .text(adat.valasz)
                .hide();
            const $fejlec = $('<div>')
                .addClass('fejlec')
                .append($gomb, $kerdes);
            $elem.append($fejlec, $valasz);
            $nTarolo.append($elem);

            $gomb.on('click', function () {
                $valasz.slideToggle(300);
                if ($gomb.text() === '+') {
                    $gomb.text('-');
                } else {
                    $gomb.text('+');
                }
            });
        }
    }

    const $urlap = $('#urlap').hide();
    const $uj = $('#uj');
    $uj.on('click', function () {
        $urlap.slideToggle(300);
    });
    $urlap.on('submit', function (e) {
        e.preventDefault();
        const kds = $('#kds').val();
        const vlsz = $('#vlsz').val();
        kerdesekTomb.push({
            kerdes: kds,
            valasz: vlsz
        });
        $('#kds').val('');
        $('#vlsz').val('');
        Epit();
        $urlap.slideUp();
    });
    Epit();
});