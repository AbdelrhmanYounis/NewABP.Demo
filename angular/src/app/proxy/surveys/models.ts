import type { EntityDto } from '@abp/ng.core';

export interface CreateSurveyDto extends EntityDto<number> {
  problemsAndSuggestions?: string;
  date?: string;
  parkId: number;
  bandId: number;
  gradeId: number;
}
