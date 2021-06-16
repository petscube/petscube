import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PetsadoptionComponent } from './petsadoption.component';

describe('PetsadoptionComponent', () => {
  let component: PetsadoptionComponent;
  let fixture: ComponentFixture<PetsadoptionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PetsadoptionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PetsadoptionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
