import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';
import {FormsModule} from '@angular/forms';
import {HttpModule} from '@angular/http';

import {UserRepository} from './components/shared/respository/UserRepository'
import {ApiSettings} from './components/shared/context/ApiSettings'

import {AppComponent} from './app.component'

import {HeaderModule} from './components/header/header.module'
import {ResumeModule} from './components/resume/resume.module'
import {AppRouteModule} from "./app.route";

@NgModule({
    declarations: [
        AppComponent
    ],
    imports: [
        // AppRouteModule,
        BrowserModule,
        FormsModule,
        HttpModule,
        HeaderModule,
        ResumeModule
    ],
    providers: [
        ApiSettings,
        UserRepository,

    ],
    bootstrap: [AppComponent]
})
export class AppModule {
}
