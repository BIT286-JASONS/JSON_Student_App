import { Component, ViewChild, OnInit } from '@angular/core';
import { Observable } from 'rxjs'
import { FormsModule } from '@angular/forms';

@Component({
    selector: 'flashcards',
    templateUrl: './flashcards.component.html',
    styleUrls: ['./flashcards.component.css']
})


export class flashcardsComponent implements OnInit{

    one: Number = Math.floor((Math.random() * 10) + 1);
    two: Number = Math.floor((Math.random() * 10) + 1);


    ngOnInit() {

    }

    

    


}