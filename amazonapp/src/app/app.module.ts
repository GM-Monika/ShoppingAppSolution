import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import {HttpClientModule} from '@angular/common/http';
// import { JwtModule } from '@auth0/angular-jwt';


import { FormsModule } from '@angular/forms';
import { JwtModule } from '@auth0/angular-jwt';
import { UserService } from './services/user.service';
import { HomeComponent } from './home/home.component';
import { ProductComponent } from './product/product.component';
import { ProductsComponent } from './products/products.component';
import { ProductService } from './services/product.service';
import { CartComponent } from './cart/cart.component';

@NgModule({
  declarations: [
    AppComponent,
    RegisterComponent,
    LoginComponent,
    HomeComponent,
    ProductComponent,
    ProductsComponent,
    CartComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule

    //  JwtModule.forRoot({
    //   config:{
    //     tokenGetter:tokenGetter,
    //     allowedDomains:["http://localhost:5268/"]
    //   }
    // })
  ],
  providers: [UserService,ProductService],
  bootstrap: [AppComponent]
})
export class AppModule { }
