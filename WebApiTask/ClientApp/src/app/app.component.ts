import { Component } from '@angular/core';
import { LoaderService } from './Services/loader.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  title = 'app';

  constructor(public loader:LoaderService) { }
}
