import { Component, OnInit, Input } from '@angular/core'
import { trigger, state, animate, transition, style } from '@angular/animations'
import { Skill } from '../../shared/model/Skill';
import { SkillLevel } from '../../shared/model/SkillLevel';

@Component({
    selector: 'skill',
    templateUrl: './skill.component.html',
    animations: [
        trigger('level', [
            state('beginner', style({
                width: '15%'
            })),
            state('proficient', style({
                width: '25%'
            })),
            state('expert', style({
                width: '75%'
            })),
            state('master', style({
                width: '100%'
            })),
            transition('* <=> *', animate('1000ms ease-in-out'))
        ])
    ]
})
export class SkillComponent implements OnInit {

    @Input() skills: Skill[];

    ngOnInit(): void {

    }
    getLevelName(level: SkillLevel): string {
        return Skill.getLevelName(level)
    }
}
