import {Component, Input, OnInit} from '@angular/core';
import {Header} from "../shared/model/Header";

@Component({
    selector: 'resume-header',
    templateUrl: './header.component.html'
})
export class HeaderComponent implements OnInit {

    @Input() header: Header;

    ngOnInit() {
    }
}
