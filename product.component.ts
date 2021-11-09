import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
productID:number=0;
productName:string="";
productPrice:number=0;

Save($event:any)
{
console.log(this.productID);
console.log(this.productName)
console.log(this.productPrice);


}
  constructor() { }

  ngOnInit(): void {
  }

}
