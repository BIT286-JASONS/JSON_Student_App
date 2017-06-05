import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';


import { EqualValidator } from './equal-validator.directive';
import { ChangePasswordComponent }   from './ChangePassword.component';

@NgModule({
  imports:      [ BrowserModule, FormsModule ],
  declarations: [ ChangePasswordComponent, EqualValidator ],
  bootstrap:    [ ChangePasswordComponent ],
   exports: [
    EqualValidator
    ]

})

export class ChangePasswordModule { }