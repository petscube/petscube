import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';

 
export class HttphelperService {

  constructor(private http: HttpClient) { }
  get<T>(url:string):Observable<T>
  {
    return this.http.get<T>(url)
    .pipe(
      catchError(this.handleError())
    );
    
  }
  authorizedGet<T>(url:string){
    let header = new HttpHeaders().set(
      "Authorization",
       localStorage.getItem("token")
    );
    return this.http.get<T>(url,{headers:header})
    .pipe(
      catchError(this.handleError())
    );
  }
  post(url:string, data:any)
  {
     this.http.post(url,data).pipe(
      catchError(this.handleError())
    );
  }
  private handleError() {
    return (error: any): Observable<any> => {
  
      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead
  
      // TODO: better job of transforming error for user consumption
     // this.log(`${operation} failed: ${error.message}`);
  
      // Let the app keep running by returning an empty result.
      return of(null);
    };
  }
}
