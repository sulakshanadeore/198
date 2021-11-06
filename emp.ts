class employee {
    private static empcount:number=0;
private    _empid:number;
private    _empname:string;
public getEmpCount():number
{
return employee.empcount;

}
     
constructor()
{
employee.empcount=employee.empcount+1;

}
    // constructor(empno:number,ename:string) {
    //     this._empid=empno;
    //     this._empname=ename;
    // }
public set employeeid(v : number) {
    this._empid = v;
}

public get employeeid() : number {
    return this._empid
}


public set employeename(v : string) {
    this._empname = v;
}

public get employeename() : string {
    return this._empname;
}
    display=()=>
    {
        console.log(this._empid);
        console.log(this._empname);
    }
}
var e1=new employee();
e1.employeeid=1;
e1.employeename="Sumit";
console.log("U entered employee id= "  +e1.employeeid);
console.log("U entered employee name= "  +e1.employeename);
e1.display();
var c:number=e1.getEmpCount();
console.log("Employee Count=" + c); 

var e2=new employee();
e2.employeeid=2;
e2.employeename="Kabir";
console.log("U entered employee id= "  +e2.employeeid);
console.log("U entered employee name= "  +e2.employeename);
e2.display();
var c:number=e2.getEmpCount();
console.log("Employee count= " + c);

var e3=new employee();
var c:number=e3.getEmpCount();
console.log("Employee count= " + c);
// var e1=new employee(1,"Poonam");
// var e2=new employee(2,"Sumit");
// e1.display();
// console.log("----------");
// e2.display();