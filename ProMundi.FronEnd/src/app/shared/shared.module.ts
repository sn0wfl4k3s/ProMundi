import { defineLocale } from 'ngx-bootstrap/chronos';
import { ptBrLocale } from 'ngx-bootstrap/locale';
import { DataGridConfig, EnumAutoFitMode, EnumDataGridMode, InputFormsConfig, NgxUiHeroDataGridModule, NgxUiHeroInputFormsModule, NgxUiHeroModule } from 'ngx-ui-hero';

import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

defineLocale('pt-br', ptBrLocale);

const dataGridSettings: DataGridConfig = {
    emptyResultsMessage: 'Nenhum registro encontrado no momento.',
    infoMessage: 'Exibindo de {recordsFrom} até {recordsTo}, de {totalRecords} registros encontrados.',
    actionsColumnCaption: '',
    autoFitMode: EnumAutoFitMode.ByContent,
    mode: EnumDataGridMode.OnClient,
    paging: {
      firstText: '<<',
      previousText: '<',
      nextText: '>',
      lastText: '>>',
      boundaryLinks: true,
      directionLinks: true,
      rotate: true,
      maxSize: 10,
      itemsPerPage: 10
    },
    styles: {
      striped: true,
      bordered: true,
      hoverEffect: true,
      responsive: true
    },
    exporting: {
        exportButtonLabel: 'Exportar'
    }
};

const inputFormsConfig: InputFormsConfig = {
    currency: {
      currencyCode: 'BRL',
      align: 'right',
      allowNegative: true,
      allowZero: true,
      decimal: ',',
      thousands: '.',
      precision: 2,
      prefix: '',
      suffix: ''
    },
    validationMessages: {
      invalid: '{label} estÃ¡ invÃ¡lido',
      required: '{label} Ã© obrigatÃ³rio',
      pattern: '{label} estÃ¡ invÃ¡lido',
      maxlength: 'O valor preenchido Ã© maior do que o mÃ¡ximo permitido',
      minlength: 'O valor preenchido Ã© menor do que o mÃ­nimo permitido'
    },
    date: {
      format: 'dd/MM/yyyy',
      theme: 'theme-dark-blue',
      placement: 'bottom',
      locale: 'pt-br'
    },
    upload: {
      placeholder: 'Selecione um arquivo...',
      dropZonePlaceholder: 'Arraste e solte um arquivo aqui para importar.',
      autoUpload: true,
      showDropZone: true,
      showQueue: true,
      withCredentials: false,
      chunk: false,
      chunkSize: 1048576,
      chunkRetries: 3,
      maxFileSize: 4,
      selectButtonIcon: 'fa fa-folder',
      selectButtonLabel: 'Selecionar',
      removeButtonIcon: 'fa fa-trash',
      removeButtonLabel: 'Remover',
      fileTypeErrorMessage: 'A extensÃ£o [{extension}] nÃ£o Ã© permitida.',
      fileSizeErrorMessage: 'Este arquivo excede o tamanho mÃ¡ximo permitido de {maxFileSize}MB.',
      maxFileSizeLabel: 'Tamanho mÃ¡ximo permitido:',
      allowedExtensionsLabel: 'ExtensÃµes permitidas:'
    },
};

@NgModule({
    imports: [
        CommonModule,
        NgxUiHeroModule,
        NgxUiHeroDataGridModule.forRoot(dataGridSettings),
        NgxUiHeroInputFormsModule.forRoot(inputFormsConfig),
      
    ],
    declarations: [],
    providers: [],
    exports: [
        NgxUiHeroModule,
        NgxUiHeroDataGridModule,
        NgxUiHeroInputFormsModule
    ],
})
export class SharedModule { }
