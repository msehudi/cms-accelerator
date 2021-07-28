import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Module, QuestionType } from '../models/app-modules';
import { ApplicationService } from '../services/application.service';

@Component({
  selector: 'app-application',
  templateUrl: './application.component.html',
  styleUrls: ['./application.component.scss']
})
export class ApplicationComponent implements OnInit {
  applicationTypes: Module[] = []; 
  appId?: string;
  currentModule?: string;
  questionTypes: QuestionType[] = [];
  constructor(
    private route: ActivatedRoute,
    private applicationService: ApplicationService,
  ) { 
    this.route.params.subscribe(params => {
      let id = params.id;
      if(id === 'new'){
        id = null;
      }
      this.appId = id;
    });

    this.applicationService.getApplicationTypes()
    .subscribe(data => {
      this.applicationTypes = data.modules; 
      this.questionTypes = data.questionTypes;
    })
  }

  getModule(id: string){
    return this.applicationTypes.find(module => module.id === id);
  }

  ngOnInit(): void {
  }

}
