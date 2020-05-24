import { Component, OnInit } from '@angular/core';
import { Usuario } from 'src/app/models/usuario';

import {  BsModalRef } from 'ngx-bootstrap/modal'
import * as alertify from 'alertify.js'

@Component({
  selector: 'app-login-modal',
  templateUrl: './login-modal.component.html',
  styleUrls: ['./login-modal.component.scss']
})
export class LoginModalComponent implements OnInit {
  usuario: Usuario;
  constructor(private modalRef: BsModalRef) { }

  ngOnInit() {
    this.usuario = new Usuario();
  }

  fecharModal() {
    this.modalRef.hide();
  }

  login() {
    alertify.logPosition('bottom right').success("Seja Bem Vindo")
    this.fecharModal();
  }
}
