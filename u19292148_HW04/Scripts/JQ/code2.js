$(document).ready(function () {
    
    $(".col").show();
    $(".pat").hide();
    $(".qoute").hide();
    $(".sprice").show();
    $(".cprice").hide();
    $(".bprice").hide();



    $("#prodType").on("change", function () {
        var val = $(this).val();
        if (val == "Cup") {
            $(".pat").hide();
            $(".col").hide();
            $(".qoute").show();
            $(".sprice").hide();
            $(".cprice").show();
            $(".bprice").hide();
        }
        if (val == "Straw") {
            $(".pat").hide();
            $(".col").show();
            $(".qoute").hide();
            $(".sprice").show();
            $(".cprice").hide();
            $(".bprice").hide();
        }
        if (val == "Bag") {
            $(".pat").show();
            $(".col").hide();
            $(".qoute").hide();
            $(".sprice").hide();
            $(".cprice").hide();
            $(".bprice").show();
        }

    });


   
});