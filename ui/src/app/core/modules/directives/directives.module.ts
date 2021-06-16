import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LocationSearchDirective } from './location-search.directive';
import { AgmCoreModule } from '@agm/core';
@NgModule({
  declarations: [LocationSearchDirective],
  imports: [
    CommonModule,
    AgmCoreModule.forRoot({
      apiKey: 'AIzaSyDaeF_KMb7onS7PAi90j66FQlFxYJPPkm0',
      libraries: ['places']
    }),
  ],
  exports:[LocationSearchDirective]
})
export class SharedDirectivesModule { }
