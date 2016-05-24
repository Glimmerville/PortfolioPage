function animationHover(element, animation) {
    element = $(element);
    element.hover(
        function () {
            element.addClass('animated ' + animation);
        },
        function () {
            //wait for animation to finish before removing classes 
            window.setTimeout(function () {
                element.removeClass('animated ' + animation);
            }, 2000);
        });
}
//I altered this below to do what I want, but it was originally found on js.fiddle.
//http://jsfiddle.net/P8D22/17/
// This is a shortcut for $(document).ready()
$(function () {

    // This is a shortcut to bind both mouseOver and mouseOut
    $('div.slideOutTab').hover(function () {
        // Animate out when hovered, stopping all previous animations
        $(this)
            .stop(true, false)
            .animate({
                left: -20
            }, 350);
    }, function () {
        // Animate back in when not hovered, stopping all previous animations
        $(this)
            .stop(true, false)
            .animate({
                left: -400
            }, 380);
    });


});