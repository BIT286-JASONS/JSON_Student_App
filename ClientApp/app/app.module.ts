import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { UniversalModule } from 'angular2-universal';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/scores/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { IndexComponent } from './components/login/index/index.component';
import { NewAccountComponent } from './components/login/newaccount/newaccount.component';
import { ChangePasswordComponent } from './components/scores/changepassword/changepassword.component';
import { EqualValidator } from './components/scores/changepassword/changepassword.equal-validator.directive'; 

@NgModule({
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        FetchDataComponent,
        IndexComponent,
        NewAccountComponent,
        ChangePasswordComponent,
        HomeComponent,
        EqualValidator
    ],
    imports: [
        UniversalModule,
        FormsModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        RouterModule.forRoot([
            { path: '', redirectTo: 'index', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: 'index', component: IndexComponent },
            { path: 'newaccount', component: NewAccountComponent },
            { path: 'changepassword', component: ChangePasswordComponent },
            { path: '**', redirectTo: 'index' }
        ])
    ]
})
export class AppModule {
}
