class A1
{
m1():void{
   
    var i=10
        var j=1;
        var k=1;
        
        do
        {
        if(j<=3)
        {
            console.log(i);
            j+=1;
        }
        else
        {
            let i=100;   
            
            i=i+10;
            console.log(i);

        }
        k+=1;
    }
    while(k<=6);
    
}

}
var obj=new A1();
obj.m1();