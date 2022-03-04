import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Instructions } from 'src/app/Models/Instructions';
import { LoaderService } from 'src/app/Services/loader.service';
import { StepsService } from 'src/app/Services/steps.service';

@Component({
  selector: 'app-step-one',
  templateUrl: './step-one.component.html',
  styleUrls: ['./step-one.component.css']
})
export class StepOneComponent implements OnInit {

  constructor(private commonService:StepsService,private loader:LoaderService, private route: ActivatedRoute) { }
  instructions:Instructions[];

  ngOnInit() {
    
    let pageSize = this.route.snapshot.paramMap.get('value');
    this.getPageData(+pageSize);
  }

  getPageData(pageSize:number){
    this.loader.showLoader();
    this.commonService.GetFirstStep(pageSize).subscribe(result=>{
      this.instructions = result;
      console.log(result);
      this.loader.hideLoader();
    },error=>{

      this.loader.hideLoader();
    });
  }

}
