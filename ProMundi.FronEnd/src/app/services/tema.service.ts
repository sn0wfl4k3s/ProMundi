import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Categoria } from '../models/categoria';
import { Tema } from '../models/tema';

@Injectable({ providedIn: 'root' })
export class TemaService {

    url = `${environment.webApiUrl}/api/Tema`;

    constructor(private http: HttpClient) { }

    getAll() {
        return this.http.get<Array<Tema>>(this.url);
    }

    getById(id: string | number) {
        return this.http.get<Tema>(`${this.url}/${id}`);
    }

    post(entidade: Tema) {
        return this.http.post<any>(this.url, entidade);
    }

    put(entidade: Tema, id: string | number) {
        return this.http.put<any>(`${this.url}/${id}`, entidade);
    }

    delete(id: string | number) {
        return this.http.delete<any>(`${this.url}/${id}`);
    }

}