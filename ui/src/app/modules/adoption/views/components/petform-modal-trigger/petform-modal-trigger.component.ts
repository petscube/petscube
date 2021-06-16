import { Component, OnDestroy, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { NewpetFormComponent } from '../new-pet-form/newpet-form.component';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
 
import { takeWhile } from "rxjs/operators";
import { NavigationService } from 'src/app/core/services/navigation/navigation-service.service';
@Component({
  selector: 'app-petform-modal-trigger',
  templateUrl: './petform-modal-trigger.component.html',
  styleUrls: ['./petform-modal-trigger.component.scss']
})
export class PetformModalTriggerComponent implements OnInit, OnDestroy {
  isDestroyed: boolean = false;
  constructor(private modalService: NgbModal, private router: Router, private navService: NavigationService,
    //private navService:NavigationService,
    private route: ActivatedRoute) { }
  ngOnDestroy(): void {
    this.isDestroyed = true;
  }

  ngOnInit(): void {
    this.router.events.subscribe((event) => {
      if (event instanceof NavigationEnd) {
        var url = this.router.url;
        if (url.indexOf('option=create')>-1) {
          var modal = this.modalService.open(NewpetFormComponent);
          modal.dismissed.pipe(takeWhile(x => !this.isDestroyed)).subscribe((obj) => {
            this.navService.back(); 
          });

        } 
      }

    });

  }
  openPetForm() {
    this.router.navigateByUrl(`/${this.router.url}?option=create`);
  }
}
