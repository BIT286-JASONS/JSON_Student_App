export class NewAccount {

    public id: number;
    public firstname: string;
    public lastname: string;
    public username: string;
    public password: string;
    public isTeacher?: boolean;
    public teacher_id?: number;


    constructor(data) {
        Object.assign(this, data);
    }
}