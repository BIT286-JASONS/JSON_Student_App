export class Teacher {
    public id: number;
    public firstname: string;
    public lastname: string;
    public username: string;
    public password: string;

    constructor(data) {
        Object.assign(this, data);
    }
}