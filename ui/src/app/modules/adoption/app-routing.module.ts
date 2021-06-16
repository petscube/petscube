import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdoptionComponent } from './app.component';

const routes: Routes = [
  {
    path: '', component: AdoptionComponent,
    children: [
      {
        path: 'search', loadChildren: () => import(`./views/pages/petsadoption/petsadoption.module`).then(
          module => module.PetsadoptionModule
        ), data: { preload: true }
      }
    ]
  },


];
@NgModule({
  imports: [RouterModule.forChild(routes)],



  exports: [RouterModule]
})
export class AdoptionRoutingModule { }
