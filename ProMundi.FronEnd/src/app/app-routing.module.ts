import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './principal/home/home.component';
import { SaudeComponent } from './principal/saude/saude.component';
import { PerfilComponent } from './principal/perfil/perfil.component';

const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },    
  { path:"home", component:HomeComponent},
  { path:"perfil",component:PerfilComponent},
  { path:"saude", component:SaudeComponent}

 ];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
    declarations: [],
})
export class AppRoutingModule { }
