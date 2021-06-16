import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms'; 
import { HttphelperService } from 'projects/shared/src/lib/services/httphelper.service';
import { ApiUrl } from '../../../core/constants';

@Component({
  selector: 'app-newpet-form',
  templateUrl: './newpet-form.component.html',
  styleUrls: ['./newpet-form.component.scss']
})
export class NewpetFormComponent implements OnInit {
  imageSrc: string;
  constructor(private fb: FormBuilder,private httpHelper:HttphelperService) { }
  petForm = this.fb.group({
    name: [''],
    age: ['', Validators.required],
    pincode: ['', Validators.required],
    gender: ["", Validators.required],
    contact: ['', Validators.required],
    breed: ['', Validators.required],
    petType: ["", Validators.required],     
    fileSource: [''],
    image: ['']
  });
  ngOnInit(): void {
  }
  locationSelect($event){
    debugger;
  }
  onFileChange(event) {
    const reader = new FileReader();

    if (event.target.files && event.target.files.length) {
      const [file] = event.target.files;
      reader.readAsDataURL(file);

      reader.onload = () => {

        this.imageSrc = reader.result as string;

        this.petForm.patchValue({
          fileSource: reader.result
        });

      };

    }
  }
  onSubmit(): void {
   
   if(this.petForm.valid){
    var data=this.petForm.controls;
    this.httpHelper.post(ApiUrl.AddPet,data);
   }
  }

}
