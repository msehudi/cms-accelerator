import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ApplicationService {

  constructor(private httpCLient: HttpClient) {
  }

  public getApplicationTypes() {
    return this.httpCLient.get<any[]>('api/applications/application-types');
  }
}
