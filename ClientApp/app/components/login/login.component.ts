import { Component } from '@angular/core';
import { Http } from '@angular/http'
//import { teacherModel } from '../../models/teacherModel'
//import { User } from "../../models/user"
import { $scope }

@Component({
    selector: 'login',
    templateUrl: './login.component.html'
})

export class loginComponent {
    //public  Teachers: Teacher[];
    public data = $scope.fields
    //this.Teacher.username();
    
    constructor(http: Http) {
    //$scope.login
    //Teacher asdf = new Teacher{this.username = $scope.username}

    http.post('api/teachercontroller/check', this.data)
    }

}

 
interface Teacher {

    username: string;
    password: string;
}
