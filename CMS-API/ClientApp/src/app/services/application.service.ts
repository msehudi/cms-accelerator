import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ModuleData } from '../models/app-modules';

@Injectable({
  providedIn: 'root'
})
export class ApplicationService {

  constructor(private httpCLient: HttpClient) {
  }

  public getApplicationTypes() {
    return this.httpCLient.get<ModuleData>('api/applications/application-types');
  }
}
