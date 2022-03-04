import { Component, OnInit } from '@angular/core';
import { LoaderService } from 'src/app/Services/loader.service';
import { StepsService } from 'src/app/Services/steps.service';

@Component({
  selector: 'app-step-two',
  templateUrl: './step-two.component.html',
  styleUrls: ['./step-two.component.css']
})
export class StepTwoComponent implements OnInit {


  message: string;

  constructor(private commonService: StepsService, private loader: LoaderService) { }

  ngOnInit() {
    this.getPageData();
  }

  getPageData() {
    this.loader.showLoader();
    this.commonService.GetTaskDetails().subscribe(result => {
      this.message = result;
      console.log(result);
      this.loader.hideLoader();
    }, error => {
      this.loader.hideLoader();
    });
  }

}
