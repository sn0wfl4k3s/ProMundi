import { Component, OnInit } from '@angular/core';
import { UsuarioService } from 'src/app/services/usuario.service';
import { Usuario } from 'src/app/models/usuario';
import { Categoria } from 'src/app/models/categoria';
import { Tema } from 'src/app/models/tema';
import { CategoriaService } from 'src/app/services/categoria.service';
import { TemaService } from 'src/app/services/tema.service';

@Component({
  selector: 'app-perfil',
  templateUrl: './perfil.component.html',
  styleUrls: ['./perfil.component.scss']
})
export class PerfilComponent implements OnInit {
  categorias: Array<Categoria>;
  temas:Array<Tema>;
  usuario: Usuario;
  tema: any;
  categoria: any;
  config = {
    placeholder: '',
    tabsize: 2,
    height: '200px',
    uploadImagePath: '/api/upload',
    toolbar: [
        ['misc', ['codeview', 'undo', 'redo']],
        ['style', ['bold', 'italic', 'underline', 'clear']],
        ['font', ['bold', 'italic', 'underline', 'strikethrough', 'superscript', 'subscript', 'clear']],
        ['fontsize', ['fontname', 'fontsize', 'color']],
        ['para', ['style', 'ul', 'ol', 'paragraph', 'height']],
        ['insert', ['table', 'picture', 'link', 'video', 'hr']]
    ],
    fontNames: ['Helvetica', 'Arial', 'Arial Black', 'Comic Sans MS', 'Courier New', 'Roboto', 'Times']
  }

  constructor(
    private usuarioService: UsuarioService,
    private categoriaService: CategoriaService,
    private temaService: TemaService
    ) { }

  ngOnInit() {
    this.usuario == new Usuario();
    this.carregarPerfilUsuario();
    this.carregarCategorias();
    this.carregarTemas();
  }

  carregarPerfilUsuario(): void {
    this.usuarioService.getById(2)
      .subscribe(result => {
        this.usuario = result;
      })
  }
  carregarCategorias(): void {
    this.categoriaService.getAll()
      .subscribe(result => {
        this.categorias = result;
      })
  }
  carregarTemas(): void {
    this.temaService.getAll()
      .subscribe(result => {
        this.temas = result;
      })
  }



}
