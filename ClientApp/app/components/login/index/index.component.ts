import { Component, OnInit } from '@angular/core';
import { User } from '../../../models/userModel';
import { Router, ActivatedRoute } from '@angular/router';
import { Http, Headers, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map'


@Component({
    selector: 'index',
    templateUrl: './index.component.html',
})


export class IndexComponent {
    //model: User = {username: "", password: ""};
    //loading = false;

    //constructor(
    //    private http: Http,
    //    private route: ActivatedRoute,
    //    private router: Router) { }

    //ngOnInit() {
    //    // reset login status
    //    this.logout();
    //    }

    //login() {
    //    this.loading = true;
    //    this.loginuser(this.model.username, this.model.password)
    //        .subscribe(
    //        data => {
    //            this.router.navigate(['/scores']);
    //        },
    //        error => {
    //            this.loading = false;
    //        });
    //}


    //loginuser(username: string, password: string) {
    //    let user = { username: username, password: password };
    //    return this.http.post('/api/teacher/check', JSON.stringify(user))
    //        .map((response: Response) => {
    //            if (response) {
    //                if (response.status < 300) {

    //                    localStorage.setItem('currentUser', user.username);
    //                }

    //            }
    //        });
    //}

    //logout() {
    //    // remove user from local storage to log user out
    //    sessionStorage.removeItem('currentUser');
    //}
}