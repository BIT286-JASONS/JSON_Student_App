import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { UniversalModule } from 'angular2-universal';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/scores/home/home.component';
import { IndexComponent } from './components/login/index/index.component';
import { ScoresListComponent } from './components/scores/scoreslist/scoreslist.component';
import { NewAccountComponent } from './components/login/newaccount/newaccount.component';
import { ChangePasswordComponent } from './components/scores/changepassword/changepassword.component';
import { TimeComponent } from './components/games/time/time.component'
import { AlienRoundupComponent } from './components/games/alienroundup/alienroundup.component';
import { EqualValidator } from './components/scores/changepassword/changepassword.equal-validator.directive'; 

@NgModule({
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,
        IndexComponent,
        NewAccountComponent,
        ChangePasswordComponent,
        HomeComponent,

        EqualValidator,
        ScoresListComponent,
        AlienRoundupComponent,
        TimeComponent

    ],
    imports: [
        UniversalModule,
        FormsModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        RouterModule.forRoot([
            { path: '', redirectTo: 'index', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'index', component: IndexComponent },
            { path: 'newaccount', component: NewAccountComponent },
            { path: 'changepassword', component: ChangePasswordComponent },
            { path: 'list', component: ScoresListComponent },
            { path: 'time', component: TimeComponent },
            { path: 'alienroundup', component: AlienRoundupComponent },
            { path: '**', redirectTo: 'index' }
           
        ])
    ]
})
export class AppModule {
}
