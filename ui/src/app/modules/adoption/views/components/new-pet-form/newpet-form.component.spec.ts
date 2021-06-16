import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewpetFormComponent } from './newpet-form.component';

describe('NewpetFormComponent', () => {
  let component: NewpetFormComponent;
  let fixture: ComponentFixture<NewpetFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewpetFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NewpetFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
