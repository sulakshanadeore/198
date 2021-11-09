import { Component, OnInit } from '@angular/core';
import { productsModel } from 'src/Models/productsModel';



@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
productID:number=0;
productName:string="";
productPrice:number=0;

nos:number[]=[1,2,3,4,5];

 

  products=[
  {"id":1,"name":"laptops",price:60000},
  {"id":2,"name":"mobile covers",price:600},
  {"id":3,"name":"mobiles",price:60000},
  {"id":4,"name":"harddisk",price:60000},
];

plist:productsModel[]=
[
new productsModel(1,"books",60000),
new productsModel(2,"Notebooks",40000)
];
 
displayProductList():void{
  

  
  
}

Save($event:any)
{
console.log(this.productID);
console.log(this.productName)
console.log(this.productPrice);
let p=new productsModel(this.productID,this.productName,this.productPrice);


}
  constructor() { }

  ngOnInit(): void {
    this.displayProductList();
  }

}
