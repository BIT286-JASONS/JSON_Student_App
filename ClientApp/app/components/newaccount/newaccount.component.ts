import { Component } from '@angular/core';
import { Http } from '@angular/http';
import { CreationService } from '../../services/teacher/creation.service';
import { Observable } from 'rxjs/Rx';
import { Router } from '@angular/router';
//import {Student} from '../../services/student';

@Component({
    selector: 'newaccount',
    templateUrl: './newaccount.component.html',
    styleUrls: ['./newaccount.component.css']
})
export class NewAccountComponent {

    public teacher;
    model: any = {};
    constructor(private creationServices: CreationService,
        private router: Router) { }

    ngOnInit() {
        this.getTeachers();

    }

    getTeachers() {
        this.creationServices.getTeacher().subscribe(
            // the first argument is a function which runs on success
            data => { this.teacher = data },
            // the second argument is a function which runs on error
            err => console.error(err),
            // the third argument is a function which runs on completion
            () => console.log('done loading foods')
        );
    }

    onSubmit() {
        let Teacher = { ID: 3, FirstName: this.model.FirstName, LastName: this.model.LastName, UserName: this.model.UserName, Password: this.model.Password };
        let user = { UserName: this.model.UserName, Password: this.model.Password };
        if (this.model.checkbox == false) {

        }
        this.createUser(user);
        this.router.navigate(['../score']);

    }

    createUser(user) {
        sessionStorage.setItem('currentUser', JSON.stringify(user));
    }

    createTeacher(user) {
        let Teacher = { ID: 3, FirstName: user.FirstName, LastName: user.LastName, UserName: user.UserName, Password: user.Password };
        this.creationServices.createTeacher(user).subscribe(
            data => {
                // refresh the list
                this.getTeachers();
                return true;
            },
            error => {
                console.error("Error saving food!");
                return Observable.throw(error);
            }
        );
    }
}