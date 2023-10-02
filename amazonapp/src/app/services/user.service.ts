import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { User } from "../login/user";

@Injectable()
export class UserService{


    constructor(private httpClient:HttpClient){
    }

    getToken():string{
        var token = "";
        token = sessionStorage.getItem("token") as string;
        return token;

    }

    login(user:User){
       console.log(user)
       return this.httpClient.post("http://localhost:5114/api/UserApi/Login",user);

    }
}