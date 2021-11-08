interface IEmployee
{
firstname:string;
lastname:string;
//calculatesalary(basicSal:number):number;


}

interface I1 extends IEmployee
{
sal:number;
}

let edata:IEmployee={
    firstname:"anil",
    lastname:"C"
  //  calculatesalary:1000
    
}
console.log(edata.firstname);
console.log(edata.lastname);

let ie1:I1={firstname:"Prajakta",lastname:"N",sal:10000};
console.log(ie1.firstname);
console.log(ie1.lastname);



// class Employees implements IEmployee {
//     firstname: string;
//     lastname: string;
//     netsal:number;
//     calculatesalary(basicSal: number): number {
//       this.netsal=basicSal -(basicSal*.10);
//       return this.netsal;
//     }
      
    
// }

// let emp=new Employees();
// emp.firstname="Anil";
// emp.lastname="C";
// emp.netsal=emp.calculatesalary(10000);
// console.log(emp.firstname);
// console.log(emp.lastname);
// console.log(emp.netsal);