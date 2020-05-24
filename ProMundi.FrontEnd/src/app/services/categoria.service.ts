import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Categoria } from '../models/categoria';

@Injectable({ providedIn: 'root' })
export class CategoriaService {

    url = `${environment.webApiUrl}/api/Categoria`;

    constructor(private http: HttpClient) { }

    getAll() {
        return this.http.get<Array<Categoria>>(this.url);
    }

    getById(id: string | number) {
        return this.http.get<Categoria>(`${this.url}/${id}`);
    }

    post(entidade: Categoria) {
        return this.http.post<any>(this.url, entidade);
    }

    put(entidade: Categoria, id: string | number) {
        return this.http.put<any>(`${this.url}/${id}`, entidade);
    }

    delete(id: string | number) {
        return this.http.delete<any>(`${this.url}/${id}`);
    }

}