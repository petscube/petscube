import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
 
import { ReactiveFormsModule } from '@angular/forms';
 
import { SharedLibModule } from '../../../../../../../../../projects/shared/src/lib/sharedlib.module';
import { NewpetFormComponent } from 'src/app/modules/adoption/views/components/new-pet-form/newpet-form.component';
import { PetformModalTriggerComponent } from 'src/app/modules/adoption/views/components/petform-modal-trigger/petform-modal-trigger.component';
import { SharedDirectivesModule } from 'src/app/core/modules/directives/directives.module';
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
