$(function() {
    $(document).ajaxStart(function() {
        $('#screen').css({
            'display': 'block',
            opacity: 0.7,
            'width': $(document).width(),
            'height': $(document).height()
        });
        $("#loading_dialog").css("display", "block");
    });

    $(document).ajaxComplete(function() {

        setTimeout(function() {
            $('#screen').css("display", "none");
            $("#loading_dialog").css("display", "none");
        }, 200);

    });
});