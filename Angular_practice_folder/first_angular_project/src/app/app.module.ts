import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MyAppComponent } from 'src/my-app/my-app.component';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { App2Component } from 'src/app2/app2.component';

@NgModule({
  declarations: [
    AppComponent,
    MyAppComponent,
    App2Component
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    //impoMyAppComponent
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
