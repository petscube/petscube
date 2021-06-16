import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AmplifyUIAngularModule } from '@aws-amplify/ui-angular';
 
import { CommonModule } from '@angular/common'; 
import Amplify,{Auth} from 'aws-amplify';
import awsconfig from './config/aws-exports';
 
import { NavigationService } from '../../../../src/app/core/services/navigation/navigation-service.service';
import { AuthenticationService } from '../../../../src/app/modules/authentication/authenication.service';
import { HttpClientModule } from '@angular/common/http';
import { HttphelperService } from './services/httphelper.service';

/* Configure Amplify resources */
const oauth= {
  "domain": "authpetscube.auth.ap-south-1.amazoncognito.com",
  "scope": [
      "phone",
      "email",
      "openid",
      "profile",
      "aws.cognito.signin.user.admin"       
  ],
  "redirectSignIn": "http://localhost:4200",
  "redirectSignOut": "http://localhost:4200",
  "responseType": "code"
}
Amplify.configure(awsconfig);
Auth.configure({oauth: oauth});
 

Auth.currentSession()
  .then(data => console.log(data))
  .catch(err => console.log(err));
 
 

@NgModule({
  declarations: [ ],
  imports: [CommonModule,HttpClientModule,  AmplifyUIAngularModule
  ],
  providers:[NavigationService,HttphelperService,AuthenticationService],
  exports: [ ]
})
export class SharedLibModule { }
