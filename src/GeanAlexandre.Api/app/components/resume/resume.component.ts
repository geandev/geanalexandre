import {Component, Input, OnInit} from '@angular/core';
import {Resume} from "../shared/model/Resume";

@Component({
    selector: 'resume-body',
    templateUrl: './resume.component.html'
})
export class ResumeComponent implements OnInit {

    @Input() resume: Resume;

    ngOnInit() {
    }
}
