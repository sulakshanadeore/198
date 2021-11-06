class Employee {
    sayHello():void{
        var empid:number=null;
        var ename:string=undefined;
        console.log('hello...good morning');
        console.log(empid);
        console.log(ename);
        ename=ename+"Kamini";

        empid=empid+90;
        console.log(empid);
        console.log(ename);
    }
    addNos(i:number,j:number):void{
var ans=i+j;
console.log(ans);

    }
    deductNos(i:number,j:number):number{

        return i-j;
    }
}

var emp=new Employee();
emp.sayHello();
emp.addNos(10,20);
var a:number=emp.deductNos(100,10);
console.log(a);