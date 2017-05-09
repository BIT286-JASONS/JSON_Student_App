import { Injectable } from "@angular/core";
import { Http, Response, Headers, RequestOptions } from "@angular/http";
import { Observable } from "rxjs/Rx";

@Injectable()
export class CreationService {

    constructor(private http: Http) { }
    
    getTeacher() {
        return this.http.get('/api/teacher/Get').map((res: Response) => res.json());
    }

    createTeacher(teacher) {
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        let body = JSON.stringify(teacher);
        return this.http.post('/api/teacher/create', body, headers).map((res: Response) => res.json());
    }
    
    //updateFood(food) {
    //    let headers = new Headers({ 'Content-Type': 'application/json' });
    //    let options = new RequestOptions({ headers: headers });
    //    let body = JSON.stringify(food);
    //    return this.http.put('/api/food/' + food_id, body, headers).map((res: Response) => res.json());
    //}
    //deleteFood(food_id) {
    //    return this._http.delete('/api/food/' + food_id);
    //}
}