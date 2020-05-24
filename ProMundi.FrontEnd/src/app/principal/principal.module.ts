import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home/home.component';
import { HeaderComponent } from './header/header.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { Routes } from '@angular/router';
import { SidebarComponent } from './sidebar/sidebar.component';

@NgModule({
  imports: [
    CommonModule,
    SharedModule,
   
  ],
  declarations: [
    HomeComponent,
    HeaderComponent,
    SidebarComponent
  ],
  exports: [
    HomeComponent,
    HeaderComponent,
    SidebarComponent
  ]
})
export class PrincipalModule { }
