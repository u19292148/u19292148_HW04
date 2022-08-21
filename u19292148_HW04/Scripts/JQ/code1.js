function counter() {
    var count = setInterval(function () {
        var c = parseInt($('.counter').text());
        $('.counter').text((++c).toString());
        if (c == 20) {
            clearInterval(count);


        }
    }, 60);
}
function counter1() {
    var count = setInterval(function () {
        var c = parseInt($('.counter1').text());
        $('.counter1').text((++c).toString());
        if (c == 200) {
            clearInterval(count);


        }
    }, 60);
}
function counter2() {
    var count = setInterval(function () {
        var c = parseInt($('.counter2').text());
        $('.counter2').text((++c).toString());
        if (c == 30) {
            clearInterval(count);


        }
    }, 60);
}


counter();
counter1();
counter2();

$('#img1').css("left", "-650px").delay(800).animate({ left: '30px' }, 400);