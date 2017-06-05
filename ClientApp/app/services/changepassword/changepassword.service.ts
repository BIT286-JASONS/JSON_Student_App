import { Injectable } from "@angular/core";
import { Http, Response, Headers, RequestOptions } from "@angular/http";
import { Observable } from "rxjs/Rx";

@Injectable()
export class ChangePasswordService {

    constructor(private http: Http) { }

    getPassword(user) {
        return this.http.get('/api/changepassword/Get').map((res: Response) => res.json());
    }

    savePassword(user) {
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        let body = JSON.stringify(user);
        return this.http.post('/api/changepassword/Save', body, headers).map((res: Response) => res.json());
    }
}