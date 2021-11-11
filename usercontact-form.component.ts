import { Component, OnInit } from '@angular/core';
import { FormGroup,FormControl } from '@angular/forms';
import { ContactDetails } from 'src/Models/ContactDetails';
@Component({
  selector: 'app-usercontact-form',
  templateUrl: './usercontact-form.component.html',
  styleUrls: ['./usercontact-form.component.css']
})
export class UsercontactFormComponent implements OnInit {


  contactForm = new FormGroup({
    firstname: new FormControl(),
    lastname: new FormControl(),
    mobileno:new FormControl(),
    email: new FormControl(),
    gender: new FormControl(),
    isMarried: new FormControl(),
    country: new FormControl()
  });
  constructor() { }

  ngOnInit(): void {
  }
SubmitData()
{
console.log(this.contactForm.value);
 let contactDet:ContactDetails=new ContactDetails();
 contactDet.firstname=this.contactForm.value["firstname"];
 contactDet.lastname=this.contactForm.value["lastname"];
 contactDet.mobileno=this.contactForm.value["mobileno"];
 

 //console.log("Going to model class: " + contactDet.firstname);

}
}
