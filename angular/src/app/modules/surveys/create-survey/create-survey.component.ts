import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { SurveyService } from '@proxy/surveys';

@Component({
  selector: 'app-create-survey',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './create-survey.component.html',
  styleUrl: './create-survey.component.scss'
})
export class CreateSurveyComponent {

surveyForm:FormGroup;

constructor(
  private surveyService :SurveyService,
  private fb : FormBuilder
) {
 this.buildForm()
}
  buildForm() {
    this.surveyForm=this.fb.group({
      problemsAndSuggestions:new FormControl(),
      date:new FormControl('',[Validators.required]),
      parkId:new FormControl(null,[Validators.required]),
      bandId:new FormControl(null,[Validators.required]),
      gradeId:new FormControl(null,[Validators.required])
    });
  }
}
