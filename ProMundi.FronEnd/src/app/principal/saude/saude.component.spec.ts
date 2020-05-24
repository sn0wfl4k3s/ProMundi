/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { SaudeComponent } from './saude.component';

describe('SaudeComponent', () => {
  let component: SaudeComponent;
  let fixture: ComponentFixture<SaudeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SaudeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SaudeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
