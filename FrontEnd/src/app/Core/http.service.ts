import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders  } from '@angular/common/http';
import { Observable, throwError, Subscription } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
@Injectable({
  providedIn: 'root'
})
export class HttpService {

  location: string;
  methodName: string;
  className = (<any>this).constructor.name;
  requestHeaders = { headers: new HttpHeaders({ 'Content-Type': 'application/json'}) }; // ... Set content type to JSON
  constructor(private http: HttpClient) {
    this.location = 'https://localhost:44339/'//location.protocol + '//' + location.hostname + (location.port ? ':' + location.port : '') + '/' ;
  }
 observe = new Subscription();
/**
 *
 *
 * @param {string} url
 * 
 * @returns {Observable<any>}
 * @memberof HttpService
 */
public Get(url: string): Observable<any> {
    try {

      return this.http.get<any>(this.location + url ).pipe(catchError(err => {
                                      return throwError(err);
                                      }));
          } finally {
                    //  return this.http.get(this.getBaseUrl() + config.API_URL + url);
   }
}
public Post( url: string,submitted_data: any): Observable<any> {
  let result: string | Observable<any> | Observable<Object>;

  try {
    const bodyString = JSON.stringify(submitted_data);
   // header.append('Content-Type', 'multipart/form-data');
    //header.append('Accept', 'application/json');
    //let options = new RequestOptions({ headers: headers });
    this.requestHeaders = { headers: new HttpHeaders({ 'Content-Type': 'multipart/form-data'}) }; // ... Set content type to JSON

              result = this.http.post(this.location + url, submitted_data)
                                 .pipe(map((data: any) => (data.data || data)), catchError(this.handleErrors));
        return result;
  } catch (error) {
  } finally {}
}

private handleErrors(error: any): Observable<any> {
  const errors: string[] = [];
  let msg = '';

  msg = 'message: ' + error.message;
  //msg += ' - exceptionMessage: ' + error.error.exceptionMessage;
  msg += ' - status: ' + error.status;
  errors.push(msg);

  console.error('An error occurred', errors);

  return throwError(errors);
}
}