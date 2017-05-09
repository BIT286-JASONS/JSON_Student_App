import { Component } from '@angular/core';
import { Http } from '@angular/http'
import { LoginCtrl } from 'login'

@Component({
    selector: 'login',
    templateUrl: './login.component.html'
})
export class FetchDataComponent {
    public teacher: theTeachers[];

    constructor(http: Http) {
        http.get('/api/teachercontrolle/get').subscribe(result => {
            this.teacher = result.json() as theTeachers[];
        });
    }
    s
    //for(theTeacher[])
    
    //}


}
function login($scope)
{
    while ({{ $scope.username }} != {{ this.user }})
{

}
}   
interface theTeachers {

    username: string;
    password: string;
}
