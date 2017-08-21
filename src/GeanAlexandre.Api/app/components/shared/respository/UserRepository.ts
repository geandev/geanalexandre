import 'rxjs/add/operator/toPromise'

import {Injectable} from "@angular/core";
import {Http} from "@angular/http";

import {IUserRepository} from "./IUserRepository";
import {ApiSettings} from "../context/ApiSettings";
import {User} from "../model/User";

@Injectable()
export class UserRepository implements IUserRepository {

    private readonly http: Http;
    private readonly apiSettings: ApiSettings;

    constructor(http: Http, apiSettings: ApiSettings) {
        this.http = http;
        this.apiSettings = apiSettings;
    }


    public getByUserName(userName: string): Promise<User> {
        return this.http.get(`${this.apiSettings.resume}/${userName}`).toPromise()
            .then(response => <User>response.json());
    }

}
