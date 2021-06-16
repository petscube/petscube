import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path:'adoption',loadChildren: () => import(`src/app/modules/adoption/app.module`).then(
    module => module.AdoptionModule
  ), data: { preload: true }},
  { path: '', redirectTo: 'adoption', pathMatch: 'full' },
 
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {
    initialNavigation: 'enabled'
})],
  exports: [RouterModule]
})
export class AppRoutingModule { }
