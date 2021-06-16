import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AuthenticationService } from 'src/app/modules/authentication/authenication.service';
import { NavigationService } from 'src/app/core/services/navigation/navigation-service.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'petscube';
  userName:string='';
  constructor(private authService: AuthenticationService,private route: ActivatedRoute,
    private navService:NavigationService) {
    // authService.getCurrentUser().subscribe(obj=>{
    //     this.userName=obj.FullName;
    //   })
  }
  ngOnInit() {
    this.route.queryParams
      .subscribe(params => {
        if(params['code']){
          this.navService.authenticateSuccessRedirect();
          //redirected to previous page
        } // { orderby: "price" }
           
      }
    );
  }
  isMobile = false;
  signInClicked() {
    this.authService.authenticate();
  }
}
