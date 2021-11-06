class LDemo {
    m1():void{
var num:number=1;
for (let index = 0; index < 5; index++) {
    console.log(num);
    num=num+1;
    
}
  }

  m2():void{
     // var j:any;
      var l:any="abcdef";//array/list
      var k:string;
k=l[2];
console.log(k);


      console.log("----------------");
      for (var j in l) {
          k=l[j];
              console.log(k);
              
          }
      }
    //   for ( j in l) {
    //       console.log(l[j]);
    //   }



    m3():void{

        var arr=[10,20,30,40];
        for (var  i of arr) {
         console.log(i);
        }
    }

    whiledemo():void{
var i=1;
while(i<5)
{
    console.log(i);
    i=i+1;
}

    }
    dowhiledemo():void{

        var i=10;
        do {
            console.log(i);
            i+=1;
        } while (i<=12);
    }
  }



var d2=new LDemo();
d2.dowhiledemo();