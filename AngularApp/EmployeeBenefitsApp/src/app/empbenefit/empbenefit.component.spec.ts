import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmpbenefitComponent } from './empbenefit.component';

describe('EmpbenefitComponent', () => {
  let component: EmpbenefitComponent;
  let fixture: ComponentFixture<EmpbenefitComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmpbenefitComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EmpbenefitComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
