import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-new-user',
  templateUrl: './new-user.component.html',
  styleUrls: ['./new-user.component.scss']
})
export class NewUserComponent {
  addressForm = this.fb.group({
    password: [null, Validators.required],
    password2: [null, Validators.required]
  });



  constructor(private fb: FormBuilder) {}

  onSubmit(): void {
    alert('To do: send data to api');
  }
}
