import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';;
import { Usuario } from '../models/usuario';

@Injectable({ providedIn: 'root' })
export class UsuarioService {

    url = `${environment.webApiUrl}/api/Usuario`;

    constructor(private http: HttpClient) { }

    getAll() {
        return this.http.get<Array<Usuario>>(this.url);
    }

    getById(id: string | number) {
        return this.http.get<Usuario>(`${this.url}/${id}`);
    }

    post(entidade: Usuario) {
        return this.http.post<any>(this.url, entidade);
    }

    put(entidade: Usuario, id: string | number) {
        return this.http.put<any>(`${this.url}/${id}`, entidade);
    }

    delete(id: string | number) {
        return this.http.delete<any>(`${this.url}/${id}`);
    }

}