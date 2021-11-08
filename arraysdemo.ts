class A2
{

nosgreaterThan10(element:number,index:number):void
{
    var n1;
if (element>10) {
    n1=element;
}
return n1;
}

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

console.log("Concat arrays");
        var a2=arr.concat(arr1);
        a2.forEach(function (value) {
            console.log(value);
        });

        console.log("filter method of array");
var nos10=a2.filter(this.nosgreaterThan10);

console.log(nos10);
    }

}

let objA=new A2();
objA.m1();
