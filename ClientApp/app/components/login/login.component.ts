import { Component } from '@angular/core';
import { Http } from '@angular/http'
///import { LoginCtrl } from 'login'

@Component({
    selector: 'login',
    templateUrl: './login.component.html'
})
export class loginComponent {
    public Teachers: Teacher[];

    constructor(http: Http) {
        http.get('/api/teachercontrolle/get').subscribe(result => {
            this.Teachers = result.json() as Teacher[];
        });
    }



}
 
interface Teacher {

    username: string;
    password: string;
}
