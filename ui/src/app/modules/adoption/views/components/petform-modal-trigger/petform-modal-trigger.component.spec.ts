import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PetformModalTriggerComponent } from './petform-modal-trigger.component';

describe('PetformModalTriggerComponent', () => {
  let component: PetformModalTriggerComponent;
  let fixture: ComponentFixture<PetformModalTriggerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PetformModalTriggerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PetformModalTriggerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
