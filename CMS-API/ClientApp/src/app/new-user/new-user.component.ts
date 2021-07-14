import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-new-user',
  templateUrl: './new-user.component.html',
  styleUrls: ['./new-user.component.scss']
})
export class NewUserComponent {
  contact: any;

  addressForm = this.fb.group({
    password: [null, Validators.required],
    confirmPassword: [null, Validators.required]
  });



  constructor(private fb: FormBuilder,
    private userService: UserService) { }

  onSubmit(): void {
    const data = {
      ...this.contact,
      ...this.addressForm.value
    };
    this.userService.registerUser(data);
    alert('To do: send data to api');
  }
}
