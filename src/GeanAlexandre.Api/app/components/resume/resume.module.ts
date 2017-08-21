import { NgModule } from '@angular/core';

import { HttpModule } from '@angular/http'

import { ExperienceComponent } from './experience/experience.component'
import { EducationComponent } from './education/education.component'
import { AboutComponent } from './about/about.component'
import { ContactComponent } from './contact/contact.component'
import { SkillComponent } from './skill/skill.component'
import { LanguageComponent } from './language/language.component'
import { TagsComponent } from './tags/tags.component'
import { ResumeComponent } from './resume.component'
import { CommonModule } from "@angular/common";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
    declarations: [
        TagsComponent,
        LanguageComponent,
        SkillComponent,
        ContactComponent,
        AboutComponent,
        ExperienceComponent,
        EducationComponent,
        ResumeComponent,
    ],
    imports: [
        CommonModule,
        HttpModule,
        BrowserAnimationsModule

    ],
    exports: [ResumeComponent]
})
export class ResumeModule {
}
