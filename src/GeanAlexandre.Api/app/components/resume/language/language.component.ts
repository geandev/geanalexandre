import { Component, OnInit, Input } from '@angular/core';
import { Language } from '../../shared/model/Language';

@Component({
    selector: 'language',
    templateUrl: './language.component.html'
})
export class LanguageComponent implements OnInit {

    @Input() languages: Language[];

    ngOnInit() {

    }
}
