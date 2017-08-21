import {Injectable} from "@angular/core";

@Injectable()
export class ApiSettings {
    resume: string;

    constructor() {
        this.resume = "/api/resume"
    }
}
