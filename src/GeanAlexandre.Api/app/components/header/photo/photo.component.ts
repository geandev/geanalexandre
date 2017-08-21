import {Component, Input, OnInit} from '@angular/core';
import {Header} from "../../shared/model/Header";

@Component({
    selector: 'photo-header',
    templateUrl: './photo.component.html'
})

export class PhotoComponent implements OnInit {

    @Input() header: Header;

    ngOnInit() {
    }
}
