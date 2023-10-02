import { Injectable } from "@angular/core";
import { Product } from "../product/product";
import { HttpClient } from "@angular/common/http";

@Injectable()
export class ProductService{
   
   
    constructor(private httpClient:HttpClient){

       
      }

      getToken():string{
        var token = "";
        token = sessionStorage.getItem("token") as string;
        return token;

    }

    getProducts(){
        // return this.hotels;
        return this.httpClient.get("http://localhost:5114/api/ProductApi/GetAllProducts");
 
       }
    getProductById(){
        return this.httpClient.get("");
    }
    }