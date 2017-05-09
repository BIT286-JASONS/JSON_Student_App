import { Component } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { user } from './user'


@Component({
    selector: 'login',
    templateUrl: './login.component.html'
})
export class LoginComponent {
    constructor(
        public username: string,
        public password: string

    ) { }



    onSubmit() {

    }


    public login()
    {

    }


}