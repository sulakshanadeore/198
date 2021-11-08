class Emp
{
   ename:string;
    constructor(empname:string)
    {
this.ename=empname;

    }
    showdetails():void{
        
        console.log(this.ename);

    }

}
class Manager extends Emp   
{
    v_city:string;
    constructor(empname:string,city:string)
    {
        super(empname);
        this.v_city=city;

    }
    display():void{
super.showdetails();
console.log(this.v_city);
    }
}

var e1=new Manager("Aditi","Pune");
e1.display();