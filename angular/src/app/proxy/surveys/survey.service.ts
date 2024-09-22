import type { CreateSurveyDto } from './models';
import { RestService, Rest } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { ResponseDto } from '../shared/models';

@Injectable({
  providedIn: 'root',
})
export class SurveyService {
  apiName = 'Default';
  

  createSurveyByModel = (model: CreateSurveyDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, ResponseDto>({
      method: 'POST',
      url: '/api/app/survey/survey',
      body: model,
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
