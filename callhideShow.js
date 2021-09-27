$(document).ready(function(){

$("#btnshow").click(function(){
    $("p").show();
});



$("#btnhide").click(function(){
    $("p").hide();
});



$("p").click(function(){
   $(this).hide();
});


$("#btntoggle").click(
    function(){
        $("p").toggle();
    }
);

// $("this").show();

});
