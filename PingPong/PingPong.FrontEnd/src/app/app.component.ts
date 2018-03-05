import { Component } from '@angular/core';
import { Http, Response, Headers, RequestOptions, RequestMethod } from '@angular/http';
import { Observable } from "rxjs/Rx";

@Component({
  selector: 'my-app',
  template: `<button (click)="OnClick()">Enviar mensaje Ping</button>`,
})
export class AppComponent {
  private urlService: string = "http://localhost:50003/";

  constructor(private http: Http) {

  }

  OnClick() {
    this.get('api/ping').subscribe(
      result => {
        alert("PINGMESSAGE Enviado");
      },
      error => console.log(error)
    )
  }

  get(apiUrl: string) {
    return this.http.get(this.urlService + apiUrl)
      .map(this.extractData)
      .catch(this.handleError)
  }

  private extractData(res: Response) {
    let body = res.json();
    return body || {};
  }

  private handleError(error: Response | any) {
    let errMsg: string;
    if (error instanceof Response) {
      const body = error.json() || '';
      const err = body.error || JSON.stringify(body);
      errMsg = `${error.status} - ${error.statusText || ''} ${err}`;
    } else {
      errMsg = error.message ? error.message : error.toString();
    }
    console.error(errMsg);
    return Observable.throw(errMsg);
  }

}
