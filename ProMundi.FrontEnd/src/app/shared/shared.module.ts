import { NgxUiHeroInputFormsModule, InputFormsConfig } from 'ngx-ui-hero';
import { defineLocale } from 'ngx-bootstrap/chronos';
import { ptBrLocale } from 'ngx-bootstrap/locale';
import { NgModule } from '@angular/core';
defineLocale('pt-br', ptBrLocale);

export const inputFormsConfig: InputFormsConfig = {
  currency: {
    currencyCode: 'USD',
    align: 'right',
    allowNegative: true,
    allowZero: true,
    decimal: '.',
    thousands: ',',
    precision: 2,
    prefix: '',
    suffix: ''
  },
  validationMessages: {
    invalid: '{label} is invalid',
    required: '{label} is required',
    pattern: '{label} is invalid',
    maxlength: 'The filled-in value is greater than the maximum allowed',
    minlength: 'The filled-in value is less than the minimum allowed'
  },
  date: {
    format: 'dd/MM/yyyy',
    theme: 'theme-dark-blue',
    placement: 'bottom',
    locale: 'pt-br'
  },
  upload: {
    placeholder: 'Select a file to upload...',
    dropZonePlaceholder: 'Drag & drop a file to import.',
    autoUpload: true,
    showDropZone: true,
    showQueue: true,
    withCredentials: false,
    chunk: false,
    chunkSize: 1048576,
    chunkRetries: 3,
    chunkRequestsCountInParallel: 50,
    maxFileSize: 4,
    selectButtonIcon: 'fa fa-folder',
    selectButtonLabel: 'Select',
    removeButtonIcon: 'fa fa-trash',
    removeButtonLabel: 'Remove',
    fileTypeErrorMessage: 'The file type [{extension}] is not allowed.',
    fileSizeErrorMessage: 'This file exceeds the max file size allowed of {maxFileSize}MB.',
    maxFileSizeLabel: 'Max file size:',
    allowedExtensionsLabel: 'Allowed extensions:'
  },
  multiSelect: {
    placeholder: 'Select...',
    searchPlaceholder: 'Search...',
    displayTextProperty: 'text',
    valueProperty: 'value',
    emptyMessage: 'No results found.',
    selectAllButtonLabel: 'Select all',
    clearSelectionButtonLabel: 'Clear selection',
    maxCountOfLabelsToShow: 3
  },
  monthYear: {
    placeholder: 'Select...',
    language: 'en',
    format: 'MMM/yyyy'
  },
  dropDown: {
    placeholder: 'Select...',
    searchPlaceholder: 'Search...',
    emptyResultsMessage: 'No results found at this moment.',
    displayTextProperty: 'text',
    valueProperty: 'value',
    clearSelectionButtonLabel: 'Clear',
  }
};

@NgModule({
  imports: [
    NgxUiHeroInputFormsModule.forRoot(inputFormsConfig)
  ],
})
export class SharedModule { }
