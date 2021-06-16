import { Directive, ElementRef, EventEmitter, HostListener, Output } from '@angular/core';
import { MapsAPILoader } from '@agm/core';
@Directive({
  selector: '[appLocationSearch]'
})
export class LocationSearchDirective {
  @Output() onLocationSelect = new EventEmitter();
  constructor(el: ElementRef, private mapsAPILoader: MapsAPILoader) {
    this.mapsAPILoader.load().then(() => {
    let autocomplete = new google.maps.places.Autocomplete(el.nativeElement);
      autocomplete.addListener("place_changed", () => {
          //get the place result
          let place: google.maps.places.PlaceResult = autocomplete.getPlace();

          //verify result
          if (place.geometry === undefined || place.geometry === null) {
            return;
          }

         this.onLocationSelect.emit(place);
      });
    });
 }
 @HostListener('click', ['$event']) 
 onClick($event){
  console.info('clicked: ' + $event);
}

}
 