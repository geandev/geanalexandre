import {Component, Input} from '@angular/core';

@Component({
    selector: 'about',
    templateUrl: './about.component.html'
})
export class AboutComponent {
    @Input() text: string;
}
