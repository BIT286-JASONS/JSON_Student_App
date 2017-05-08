export interface Password {
    	oldPassword: string; // required, validate with database.
    	newPassword: string; // required, value must be equal to confirm password.
    	confirmPassword: string; // required, value must be equal to newPassword.

}
