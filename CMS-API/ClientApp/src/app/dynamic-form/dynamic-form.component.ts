import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { QuestionType, WebPage } from '../models/app-modules';

@Component({
  selector: 'app-dynamic-form',
  templateUrl: './dynamic-form.component.html',
  styleUrls: ['./dynamic-form.component.scss']
})
export class DynamicFormComponent implements OnInit {
  @Input() webPage?: WebPage;
  @Input() questionTypes: QuestionType[] = [];
  @Input() form?: FormGroup;
  @Output() onBackClick: EventEmitter<boolean> = new EventEmitter<boolean>();
  @Output() onNextClick: EventEmitter<boolean> = new EventEmitter<boolean>();
  @Output() onSaveClick: EventEmitter<boolean> = new EventEmitter<boolean>();
  @Output() onSubmitClick: EventEmitter<boolean> = new EventEmitter<boolean>();
  constructor() { } 

  ngOnInit(): void {
  }

  getOptions(typeId?: string){
    return this.questionTypes.find(qt => qt.id == typeId)?.options || [];
  }

}
