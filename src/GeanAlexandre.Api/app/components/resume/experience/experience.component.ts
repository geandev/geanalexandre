import { Component, OnInit, Input } from '@angular/core';
import { Experience } from "../../shared/model/Experience";

@Component({
    selector: 'experience',
    templateUrl: './experience.component.html'
})

export class ExperienceComponent implements OnInit {
    @Input() experiences: Experience[];
    ngOnInit() {

    }
}
