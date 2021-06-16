import { Injectable } from '@angular/core';
import { Auth } from 'aws-amplify';
import { from, Observable } from 'rxjs';
 
import { Router } from '@angular/router';
import { CurrentUser } from '../../../../projects/shared/src/lib/models/user';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  constructor(private router:Router) { }
  authenticate(){
    sessionStorage.setItem('urlBeforeAuth',this.router.url);    
    var url="https://authpetscube.auth.ap-south-1.amazoncognito.com/login?client_id=1ncljuefot70a2ovovt1a6e4ni&response_type=code&scope=email+openid+phone+profile&redirect_uri=http://localhost:4200";
    window.location.assign(url);
     
  }
   
  getCurrentUser():CurrentUser{
    return new CurrentUser();
  }
}
