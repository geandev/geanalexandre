import {Component, Input, OnInit} from '@angular/core';
import {Contact} from "../../shared/model/Contact";

@Component({
    selector: 'contact',
    templateUrl: './contact.component.html'
})
export class ContactComponent implements OnInit {
    @Input() contact: Contact;

    ngOnInit() {

    }
}
