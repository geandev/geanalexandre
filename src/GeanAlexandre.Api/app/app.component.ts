import {Component, OnInit, Output} from '@angular/core';
import {UserRepository} from "./components/shared/respository/UserRepository";
import {Location} from "@angular/common";
import {User} from "./components/shared/model/User";
import {Resume} from "./components/shared/model/Resume";

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html'
})

export class AppComponent implements OnInit {

    private readonly _userRepository: UserRepository;
    private userName: string = "geanalexandre";

    resumes: Resume[];

    constructor(userRepository: UserRepository) {
        this._userRepository = userRepository;
    }

    ngOnInit() {
        this._userRepository.getByUserName(this.userName).then(user => {
            this.resumes = user.resumes;
        })
    }
}
