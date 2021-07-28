import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, FormsModule } from '@angular/forms';
import { Module, QuestionType } from '../models/app-modules';

@Component({
  selector: 'app-dynamic-question',
  templateUrl: './dynamic-question.component.html',
  styleUrls: ['./dynamic-question.component.scss']
})
export class DynamicQuestionComponent implements OnInit {
  @Input() questionTypes: QuestionType[] = [];
  _module?: Module;
  forms: FormGroup[] = [];
  @Input()
  set module(value: Module | undefined) {
    this._module = value;
  }
  get module(): Module | undefined {
    return this._module;
  }
  selectedPage = 0;

  constructor(private fb: FormBuilder) { }

  ngOnInit(): void {
    this.forms = this.getFormGroups();
  }

  getFormGroups() {
    let forms: FormGroup[] = [];
    if (this?.module?.webPages) {
      this.module.webPages.forEach(page => {
        const group: any = {};
        page.questions.forEach(question => {
          if (question.id) {
            const qt = this.questionTypes.find(item => item.id === question.questionTypeId);
            group[question.id] = new FormControl(question.value || qt?.defaultValue);
          }
        });
        forms.push(this.fb.group(group));
      });
    }
    return forms;
  }
  get formValues() {
    return this.forms.map(form => form.value);
  }

  onBackClick() {
    if (this.selectedPage > 0) {
      this.selectedPage -= 1;
    }
  }
  onNextClick() {
    if (this.selectedPage < ((this.module?.webPages?.length || 0) + 1)){
      this.selectedPage += 1;
    }
  }
  onSaveClick() {

  }
  onSubmitClick() {

  }

}
