import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BookcoffeeComponent } from './bookcoffee.component';

describe('BookcoffeeComponent', () => {
  let component: BookcoffeeComponent;
  let fixture: ComponentFixture<BookcoffeeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BookcoffeeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BookcoffeeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
