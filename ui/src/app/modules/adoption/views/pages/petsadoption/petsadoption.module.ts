import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PetsadoptionComponent } from './petsadoption.component';
import { Routes, RouterModule } from '@angular/router';
import { SharedModule } from './../../components/shared.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedDirectivesModule } from '../../../../../core/modules/directives/directives.module';
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
