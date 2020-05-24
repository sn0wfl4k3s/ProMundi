import { Component, OnInit } from '@angular/core';
import { UsuarioService } from 'src/app/services/usuario.service';
import { Usuario } from 'src/app/models/usuario';

@Component({
  selector: 'app-saude',
  templateUrl: './saude.component.html',
  styleUrls: ['./saude.component.scss']
})
export class SaudeComponent implements OnInit {
  usuarios: Array<Usuario>;
  constructor(private usuarioService: UsuarioService) { }

  ngOnInit() {
    this.carregarUsuarios();
  }

  carregarUsuarios(): void {
    this.usuarioService.getAll()
      .subscribe(result => {
        this.usuarios = result;
      })
  }

}
