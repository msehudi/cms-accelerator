import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {
  loginForm = this.fb.group({
    userName: [null, Validators.required],
    password: [null, Validators.required]
  });
  constructor(private fb: FormBuilder,
    private userService: UserService) { }

  onLogin(): void {
    const data = {
      ...this.loginForm.value
    }
    this.userService.loginUser(data);
  }
}
