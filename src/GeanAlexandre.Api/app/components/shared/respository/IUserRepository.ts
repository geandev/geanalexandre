import {User} from "../model/User";

export interface IUserRepository {
    getByUserName(userName: string): Promise<User>
}