import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
 
import { Routes, RouterModule } from '@angular/router';
 
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ReactiveFormsModule } from '@angular/forms';
import { PetsadoptionComponent } from 'src/app/modules/adoption/views/pages/petsadoption/petsadoption.component';
import { SharedModule } from 'src/app/modules/adoption/views/components/shared.module';
import { SharedDirectivesModule } from 'src/app/core/modules/directives/directives.module';
 
const routes: Routes = [
  {path:'',component:PetsadoptionComponent}
];

@NgModule({
  declarations: [PetsadoptionComponent],
  imports: [

RouterModule.forChild(routes),
    SharedModule,
    SharedDirectivesModule,
    CommonModule,
    NgbModule,
    
  ]
})
export class PetsadoptionModule { }
