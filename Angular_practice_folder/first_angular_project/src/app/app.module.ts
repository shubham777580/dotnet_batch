import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MyAppComponent } from 'src/my-app/my-app.component';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent,
    MyAppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    //MyAppComponent
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
