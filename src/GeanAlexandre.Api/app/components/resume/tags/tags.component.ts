import { Component, OnInit, Input } from '@angular/core';

@Component({
    selector: 'tags',
    templateUrl: './tags.component.html'
})

export class TagsComponent implements OnInit {

    @Input() tags: string[];

    ngOnInit() {

    }
}
