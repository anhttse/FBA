$(".alert").fadeTo(2000, 500).slideUp(500, function () {
    $("#success-alert").slideUp(500);
});

$('#Target').on('change',function() {
    var selected = $(this).val();
    if (selected !== '2' && selected !== '4') {
        $('#target-url').prop('hidden', false);
    } else {
        $('#target-url').prop('hidden', true);
    }
})