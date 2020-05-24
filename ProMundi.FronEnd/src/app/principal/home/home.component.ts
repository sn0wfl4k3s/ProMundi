import { Component, OnInit } from '@angular/core';
import { CategoriaService } from 'src/app/services/categoria.service';
import { Categoria } from 'src/app/models/categoria';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  categorias: Array<Categoria>;

  constructor(private categoriaService: CategoriaService) { }

  ngOnInit() {
    this.carregarCategorias();
  }

  carregarCategorias(): Promise<void> {
    const promise = new Promise<void>((resolve, reject) => {
      this.categoriaService.getAll()
        .subscribe(result => {
          console.log(result)
          this.categorias = result;
        })
    });
    return promise;
  }

  desativaSidebar() {

  }

}
