export class User {

    public username: string;
    public password: string;

    constructor(data) {
        Object.assign(this, data);
    }

}