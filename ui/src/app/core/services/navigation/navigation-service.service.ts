import { Injectable } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { Location } from '@angular/common';

@Injectable()
export class NavigationService {
  private history: string[] = [];

  constructor(private router: Router, private location: Location) {
    this.router.events.subscribe((event) => {
      if (event instanceof NavigationEnd) {
        this.history.push(event.urlAfterRedirects);
         
      }
    })
  }
  authenticateSuccessRedirect(){
    var prevUrl=sessionStorage.getItem('urlBeforeAuth');   
    window.location.assign(prevUrl);
  }
  back(): void {

    this.history.pop()
    if (this.history.length > 0) {
      this.location.back();
    } 
  }
}
