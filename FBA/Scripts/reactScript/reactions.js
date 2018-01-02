$('.reaction').on('click',
    function() {
        var reaction = $(this).data('title');
        var url = $(this).css('background-image');
        $('#reaction-current').css('background-image', url);
        $('#ReactionType').val(reaction);
    });