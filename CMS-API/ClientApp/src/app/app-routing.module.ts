import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ApplicationComponent } from './application/application.component';
import { AuthGuard } from './auth-guard';
import { ContactComponent } from './contact/contact.component';
import { LoginComponent } from './login/login.component';
import { MyProfileComponent } from './my-profile/my-profile.component';
import { NewUserComponent } from './new-user/new-user.component';

const routes: Routes = [

  {
    path: 'new-user',
    component: NewUserComponent
  },
  {
    path: 'login',
    component: LoginComponent
  },
  {
    path: 'application/:id',
    component: ApplicationComponent,
    canActivate: [AuthGuard]
  },
  {
    path: '',
    component: MyProfileComponent,
    canActivate: [AuthGuard]
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
