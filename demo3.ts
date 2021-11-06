var g=100;
class G1
{

    i=10;
    static j=20;

    showNos():void
    {
        var l=123;
console.log("Global var =" + g);

console.log("Local  var =" + l );

    }

} 
var gvar=new G1();
console.log("Class variable =" +
 gvar.i);
console.log("static class var =" + G1.j);  

