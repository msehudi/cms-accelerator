import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot } from '@angular/router';
import { UserService } from './services/user.service';

@Injectable({ providedIn: 'root' })
export class AuthGuard implements CanActivate {
    constructor(
        private router: Router,
        private userService: UserService) { }

    async canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
        const user = await this.userService.getCurrentUser();
        if (!user) {
            this.router.navigate(['login']);
            return false;
        }
        return true;
    }
}