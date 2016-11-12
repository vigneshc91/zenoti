import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Rx';

import { ServiceResponse } from './service.response';
import { Business } from './business';
import { AppConstants } from './app.constants';

@Injectable()
export class AppService {

    private getBusinessListUrl = AppConstants.APP_URL + "home/GetBusinessList";

    constructor(private http: Http){

    }

    getBusinessList(data:Business): Observable<ServiceResponse> {
        let headers = new Headers({ 'Content-type': 'multipart/form-data' });
        let options = new RequestOptions({ headers });
        
        var formData = new FormData();
        if(data.start || data.size){
            formData.append('start', data.start);
            formData.append('size', data.size);
        }
        if(data.BusinessName){
            formData.append('business_name', data.BusinessName);
        }
        if(data.BusinessType){
            formData.append('business_type', data.BusinessType);
        }

        let xhr:XMLHttpRequest = new XMLHttpRequest();
        xhr.open('post', this.getBusinessListUrl, true);
        xhr.send(formData);
        return Observable.create(res => {
            xhr.onreadystatechange =() => {
                if(xhr.readyState == 4){
                    if(xhr.status == 200){
                        res.next(JSON.parse(xhr.response));
                    } else {
                        res.error(xhr.response);
                    }
                }
            }

        });

        // return this.http.post(this.getBusinessListUrl, formData, options)
        //                 .map((res:Response) => res.json())
        //                 .catch((error:any) => Observable.throw(error.json().error || "Server error" ));
                        
    }
}