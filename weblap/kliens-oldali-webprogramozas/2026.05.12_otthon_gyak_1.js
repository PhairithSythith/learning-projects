$(function () {
    const $ment = $('#ment');
    const $nagy = $('#nagy');
    ujSor();

    function ujSor() {
        const $beirt = $('<input>').addClass('beirt');
        const $torol = $('<button>').text('Töröl');
        const $tarolo = $('<div>').addClass('tarolo').hide();

        $tarolo.append($beirt, $torol);
        $nagy.append($tarolo);

        $tarolo.slideDown(300);

        $torol.on('click', function () {
            $tarolo.slideUp(300, function () {
                $tarolo.remove();
            });

        });
    }
    $ment.on('click', function () {
        $('.beirt').last().attr('readonly', 'readonly');
        ujSor();
    });
});