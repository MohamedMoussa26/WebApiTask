import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoaderService {

  loaderStatus: Boolean = false;

  constructor() { }

  showLoader() { this.loaderStatus = true; }
  hideLoader() {
    setTimeout(() => {
      this.loaderStatus = false;
    }, 1000);
  }

}
