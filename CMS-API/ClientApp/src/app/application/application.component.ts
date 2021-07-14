import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ApplicationService } from '../services/application.service';

@Component({
  selector: 'app-application',
  templateUrl: './application.component.html',
  styleUrls: ['./application.component.scss']
})
export class ApplicationComponent implements OnInit {
  applicationTypes: any[] = []; 

  constructor(
    private route: ActivatedRoute,
    private applicationService: ApplicationService,
  ) { 
    this.route.params.subscribe(params => {
      let id = params.id;
      if(id === 'new'){
        id = null;
      }
    });

    this.applicationService.getApplicationTypes()
    .subscribe(data => {
      this.applicationTypes = data;
    })
  }

  ngOnInit(): void {
  }

}
