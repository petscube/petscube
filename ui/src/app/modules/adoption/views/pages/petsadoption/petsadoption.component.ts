import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-petsadoption',
  templateUrl: './petsadoption.component.html',
  styleUrls: ['./petsadoption.component.scss'],
   
})
export class PetsadoptionComponent implements OnInit {

  constructor(private modalService: NgbModal) { }

  ngOnInit(): void {
  }

}
