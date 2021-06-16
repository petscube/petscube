import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

 
import { AutocompleteSearchComponent } from './autocomplete-search/autocomplete-search.component';
 
import { PetcardComponent } from './petcard/petcard.component';
 
import { NgbModalModule } from '@ng-bootstrap/ng-bootstrap';


@NgModule({
  declarations: [AutocompleteSearchComponent, PetcardComponent],
  imports: [
  NgbModalModule,
  
  CommonModule
  ],
  exports:[AutocompleteSearchComponent,PetcardComponent],
  
})
export class SharedModule { }
