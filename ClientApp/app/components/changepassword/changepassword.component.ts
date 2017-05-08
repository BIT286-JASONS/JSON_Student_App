import { Component, OnInit } from '@angular/core';
import { Password } from './changepassword.password.interface';
import { Http } from '@angular/http';
import { Observable } from 'rxjs/Rx';


@Component({
    selector: 'changepassword',
    templateUrl: './changepassword.component.html',
    styleUrls: ['./changepassword.component.css']
})

export class ChangePasswordComponent {
    public password: Password;
   

    //submitted = false;

    ngOnInit() {
        // initialize model here
        this.password = {
          oldPassword: '',
          newPassword: '',
          confirmPassword: ''
        }
    }

    //onSubmit() { this.submitted = true; }

    // TODO: Remove this when we're done
    //get diagnostic() { return JSON.stringify(this.password); }

    //constructor (private http: Http) {}
    //data = sessionStorage.getItem('key');


    save(model: Password, isValid: boolean) {
        console.log(model, isValid);
    //    http.put('/api/Teacher/Update', JSON.stringify(model)).toPromise()
     //       .then(() => password);
     //   });
    }

}