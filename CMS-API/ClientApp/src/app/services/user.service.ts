import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private httpCLient: HttpClient) {
  }

  public registerUser(user: any) {
    return this.httpCLient.post('api/auth/register', user);
  }

  public getUser() {
    return this.httpCLient.get<any>('api/auth/current-user');
  }

  public loginUser(user: any) {
    return this.httpCLient.post('api/auth/login', user)

  }

  private _user: any;
  public async getCurrentUser() {
    if (!this._user) {
      this._user = await this.getUser().toPromise().catch(error => null);
    }
    return this._user;
  }
}
