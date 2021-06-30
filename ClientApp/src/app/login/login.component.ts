import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {
  addressForm = this.fb.group({
    userName: [null, Validators.required],
    password: [null, Validators.required]
  });
  constructor(private fb: FormBuilder) { }

  onSubmit(): void {
    alert('Thanks!');
  }
}
