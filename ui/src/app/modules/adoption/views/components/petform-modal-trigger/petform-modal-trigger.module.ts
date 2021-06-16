import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NewpetFormComponent } from '../new-pet-form/newpet-form.component';
import { PetformModalTriggerComponent } from './petform-modal-trigger.component';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedDirectivesModule } from '../../../../../core/modules/directives/directives.module';
import { SharedLibModule } from 'projects/shared/src/public-api';
 
@NgModule({
  declarations: [NewpetFormComponent,PetformModalTriggerComponent],
  imports: [  
 
CommonModule,
    ReactiveFormsModule,
    SharedDirectivesModule,
    SharedLibModule
  ],
  exports:[PetformModalTriggerComponent]
})
export class PetFormModalTrigger { }
