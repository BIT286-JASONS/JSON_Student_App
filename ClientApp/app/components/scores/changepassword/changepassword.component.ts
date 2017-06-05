
import { Component, OnInit } from '@angular/core';
import { Password } from './changepassword.password.interface';
import { User } from '../../../models/userModel';
import { EqualValidator } from './equal-validator.directive';  // import validator
import {ChangePasswordService} from '../../../services/changepassword/changepassword.service';

@Component({
    moduleId: module.id + '',
    selector: 'changepassword',
    templateUrl: './changepassword.component.html',
    styleUrls: ['./changepassword.component.css'],
    entryComponents: [EqualValidator]
})

export class ChangePasswordComponent implements OnInit{
    public password: Password;
    output:             any;

    constructor(private _changePasswordService: ChangePasswordService) { }

    ngOnInit() {
       // initialize model here
       this.password = {
           oldPassword: '',
           newPassword: '',
           confirmPassword: ''
       }
    }

    save(model: Password, user: User) {
       // call API to save customer
       this.output = null;

        this._changePasswordService.savePassword(user, this.password).subscribe(
            res => {
                this.output                = res;
            }, error => {
                this.output                = error;
            }
        );
    }

}

