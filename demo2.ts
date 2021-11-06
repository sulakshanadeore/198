class User {
    m1():void{
    var str='100';
    //var str2:any=str;
    var str2:number=<number><any>str;
    console.log(typeof(str2));
    str2=1000;
    console.log(str2);

    var s1=10;
    var s2:any=s1;
    s1=555.333;
    s2='hello';
    s2=3322;

    }
}
var u=new User();
u.m1()