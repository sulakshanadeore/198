class Demo1 {

    decideswitch():void{
var g:string='c';
switch (g) {
    case 'A':
        console.log("its A");
        break;
        case 'B':
            console.log("its B");
        break;
        case 'C':
            console.log("its C");
        break;
    default:
        console.log("Some thing differenet thN a,b OR c");
        break;
}
    }

    decide():void{
        var i=1;
    if (i==10) {
        console.log("i =10");
    }
    else if(i>10)
    {
        console.log("i > 10");
    }
    else{
        console.log("dont know");
    }
    }
}
var d=new Demo1();
//d.decide();
d.decideswitch();