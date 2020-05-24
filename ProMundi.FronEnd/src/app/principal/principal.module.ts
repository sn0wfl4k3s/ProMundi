import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home/home.component';
import { HeaderComponent } from './header/header.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { Routes, RouterModule } from '@angular/router';
import { SidebarComponent } from './sidebar/sidebar.component';
import { LoginModalComponent } from './header/login-modal/login-modal.component';
import { FormsModule } from '@angular/forms';
import { SaudeComponent } from './saude/saude.component';
import { PerfilComponent } from './perfil/perfil.component';
import { CarouselModule } from 'ngx-bootstrap';
import { NgxSummernoteModule } from 'ngx-summernote';




@NgModule({
  imports: [
    CommonModule,
    SharedModule,
    FormsModule,
    RouterModule,
    CarouselModule.forRoot(),
    NgxSummernoteModule,
  ],
  declarations: [
    HomeComponent,
    HeaderComponent,
    SidebarComponent,
    LoginModalComponent,
    SaudeComponent,
    PerfilComponent
  ],
  exports: [
    HomeComponent,
    SaudeComponent,
    HeaderComponent,
    SidebarComponent
  ],
  entryComponents: [
    LoginModalComponent
  ]
})
export class PrincipalModule { }
