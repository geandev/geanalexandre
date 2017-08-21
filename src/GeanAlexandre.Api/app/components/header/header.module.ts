import {NgModule} from '@angular/core';

import {HeaderComponent} from './header.component'
import {PhotoComponent} from './photo/photo.component'

@NgModule({
    declarations: [
        HeaderComponent,
        PhotoComponent
    ],
    exports: [HeaderComponent]
})
export class HeaderModule {
}
