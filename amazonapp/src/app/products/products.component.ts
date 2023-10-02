import { Component } from '@angular/core';
import { Product } from '../product/product';
import { Router } from '@angular/router';
import { ProductService } from '../services/product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent {

  className:string="";

  products:Product[]=[];
 
  
  constructor(private productService:ProductService ,private router:Router){
    this.productService.getProducts().subscribe(data=>{
      console.log(data)
      this.products = data as Product[];      })
  }

 

  
  addToCart(product:any){

    
  
    
      this.router.navigateByUrl("cart");
    }
  }
//   addToCart(){
//   this.className= "spinner-border";

//   this.hotelService.addHotel(this.hotel).subscribe(data=>{

//     this.product = data as Product;

//     if(this.product.id>0)

//       alert("The hotel has been added");

//       this.router.navigateByUrl("hotels");

//   this.className="";

// }

