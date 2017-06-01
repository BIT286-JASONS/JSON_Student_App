import { Component, ViewChild} from '@angular/core';
import { Observable } from 'rxjs'

@Component({
    selector: 'jupiter',
    templateUrl: './jupiter.component.html',
})


export class jupiterComponent {
    
    one: Number =Math.floor((Math.random() * 10) + 1);
    two: Number = Math.floor((Math.random() * 10) + 1);


    ngAfterViewInit() {
            }
    


}
