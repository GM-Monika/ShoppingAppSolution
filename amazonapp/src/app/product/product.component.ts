import { Component, ViewChild } from '@angular/core';
import { Product } from './product';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent {
  product:Product =new Product();
  showErrors:boolean = false;
  @ViewChild("productForm") productForm:any
  order:any 

  assignFile(pic:any){
    this.product.pic = "/assets/images/"+pic.files[0].name;
  }
}
