export class Login {

    public name: string;
    public password: string;

    constructor(data) {
        Object.assign(this, data);
    }

}