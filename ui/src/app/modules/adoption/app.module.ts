import { NgModule } from '@angular/core';
 
import { SharedModule } from './views/components/shared.module';
import { PetFormModalTrigger } from './views/components/petform-modal-trigger/petform-modal-trigger.module';
import { AdoptionRoutingModule } from './app-routing.module';
import { AdoptionComponent } from './app.component';

@NgModule({
  declarations: [
    AdoptionComponent
  ],
  imports: [
     
    SharedModule,
    PetFormModalTrigger,
    AdoptionRoutingModule
  ],
  providers: [],
 
})
export class AdoptionModule { }
