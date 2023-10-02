import { Component } from '@angular/core';
import { Cart } from './cart';
import { Product } from '../product/product';
import { ProductService } from '../services/product.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent {

  cart: any[] = [];

  constructor(private router: Router) {}

  placeOrder() {
    // Implement logic to place an order (e.g., send a request to a server)
    // After a successful order, navigate to the order success page
    this.router.navigate(['/order-success']);
  }



}

  // product:Product= new Product();
  // products:Product[]=[];
  // constructor(private productService:ProductService,private router:Router){
  //   this.productService.getProducts().subscribe(htl=>{
  //     this.products = htl as Product[];
  //   })
  // }
  // selectChange(hid:any){
  //   for (let index = 0; index < this.products .length; index++) {
  //     if(this.products [index].id==hid)
  //     {
  //       this.product= this.products[index];
  //       break;
  //     }
      
  //   }
  // }



  // deleteRoom(){
  //   this.productService.deleteRoom(this.product.id).subscribe(htl=>{
  //     if(htl){
  //       alert(" hotel deleted successfully")
  //       this.router.navigateByUrl("rooms");
  //     }
  //   })
  //   this.room = new Room();
  // }



