import { Component, OnInit } from '@angular/core';
import { Password } from './changepassword.password.interface';


@Component({
    moduleId: module.id + '',
    selector: 'changepassword',
    templateUrl: './changepassword.component.html',
    styleUrls: ['./changepassword.component.css']
})

export class ChangePasswordComponent implements OnInit {
    public password: Password;

    ngOnInit() {
        // initialize model here
        this.password = {
            oldPassword: '',
            newPassword: '',
            confirmPassword: ''
        }
    }

    save(model: Password, isValid: boolean) {
        // call API to save customer
        console.log(model, isValid);
    }

}