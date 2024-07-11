import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DocumentAssistantComponent } from './document-assistant.component';

describe('DocumentAssistantComponent', () => {
  let component: DocumentAssistantComponent;
  let fixture: ComponentFixture<DocumentAssistantComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DocumentAssistantComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DocumentAssistantComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
