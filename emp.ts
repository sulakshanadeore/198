class employee {
private    _empid:number;
private    _empname:string;

      
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
// var e1=new employee(1,"Poonam");
// var e2=new employee(2,"Sumit");
// e1.display();
// console.log("----------");
// e2.display();