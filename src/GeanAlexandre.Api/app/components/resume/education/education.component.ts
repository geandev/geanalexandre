import {Component, Input, OnInit} from '@angular/core';
import {Education} from "../../shared/model/Education";

@Component({
    selector: 'education',
    templateUrl: './education.component.html'
})
export class EducationComponent implements OnInit {

    @Input() educations: Education[];

    ngOnInit() {

    }
}
