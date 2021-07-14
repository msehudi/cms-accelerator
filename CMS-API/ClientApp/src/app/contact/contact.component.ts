import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.scss']
})
export class ContactComponent implements OnInit {
  private _user: any;
  addressForm: FormGroup;
  @Input() set user(value: any) {
    this._user = value;
    if (this.addressForm && value) {
      this.addressForm.patchValue({ ...value, email: value.userName });
    }
  }
  get user() {
    return this._user;
  }
  private _disabled: any;
  @Input() set disabled(value: any) {
    this._disabled = value;
    if (this.addressForm && value) {
      this.addressForm.disable();
    }
  }
  get disabled() {
    return this._disabled;
  }
  @Output() valueChange: EventEmitter<any> = new EventEmitter<any>();


  hasUnitNumber = false;

  constructor(private fb: FormBuilder) {
    this.addressForm = this.fb.group({
      // company: null,
      firstName: [this?.user?.firstName, Validators.required],
      lastName: [this?.user?.lastName, Validators.required],
      // address: [null, Validators.required],
      email: [this?.user?.userName, [Validators.required, Validators.email]],
      // address2: null,
      // city: [null, Validators.required],
      // country: [null, Validators.required],
      // state: [null, Validators.required],
      // postalCode: [null, Validators.compose([Validators.required])
      // ],
      // shipping: ['free', Validators.required]
    });
  }
  ngOnInit(): void {

    this.addressForm.valueChanges
      .subscribe(value => this.valueChange.emit(value));
    if (this.disabled) {
      this.addressForm.disable();
    }
  }
}
