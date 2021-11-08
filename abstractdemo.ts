abstract class Vehicle
{
    vehname:string;
    vehprice:number;
constructor(vname:string,vprice:number)
{
    this.vehname=vname;
    this.vehprice=vprice;
}

    abstract calculateAvg():number;


}

class Car extends Vehicle {
    calculateAvg(): number {
        let avg:number=0;
        if (this.vehname=="Audi") {
            avg=10;
        }
        else{
avg=20;

        }
        return avg;
        
    }
    constructor(carname:string,carprice:number) {
        super(carname,carprice);
    }
}

let c=new Car("Alto",50000);
let a=c.calculateAvg();
console.log("Average =" + a);