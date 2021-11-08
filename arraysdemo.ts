class A2
{
    m1():void{
        var arr:number[]=[1,2,3,4,5];
        for (let index = 0; index < arr.length; index++) {
            console.log(arr[index]);
        }

        var arr1=new Array(5);
        arr1=[10,11,12,13,14];
        arr1.forEach(function (value) {
            console.log(value);
        });


    }

}

let objA=new A2();
objA.m1();
