import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Observable } from 'rxjs/Rx';

import { AppConstants } from './app.constants';
import { ServiceResponse } from './service.response';
import { Business } from './business';
import { AppService } from './app.service';

@Component({
  selector: 'zenoti-app',
  templateUrl: 'app/app.component.html',
  providers: [ AppService ]
})

export class AppComponent { 

    business: Business[];
    businessModel: Business;
    hasMoreBusiness: boolean;
    searchQuery: string = '';
    searchType: string = '';

    constructor(private appService:AppService){
        this.businessModel = {};
        this.business = [];
        this.getBusinessList();
    }

    filterBusinessList(){
        if(this.searchType == "name"){
            this.businessModel.BusinessType = "";
            this.businessModel.BusinessName = this.searchQuery;
        } else if(this.searchType == "type"){
            this.businessModel.BusinessName = "";
            this.businessModel.BusinessType = this.searchQuery;
        } else {
            this.businessModel.BusinessName = "";
            this.businessModel.BusinessType = "";
        }
        this.business = [];
        this.getBusinessList(true);
    }

    getBusinessList(load?:boolean){
        let business: Business = {};
        if(this.businessModel.BusinessName){
            business.BusinessName = this.businessModel.BusinessName;
        } else if(this.businessModel.BusinessType){
            business.BusinessType = this.businessModel.BusinessType;
        }
        if(load){
            business.start = this.business.length;
            business.size = AppConstants.PAGINATION_SIZE;
        }
        let response:Observable<ServiceResponse>;

        response = this.appService.getBusinessList(business);
        response.subscribe(
            data => {
                if(data.status){
                    if(data.result.length){
                        this.business = this.business.concat(data.result);
                    }
                    if(data.result.length < AppConstants.PAGINATION_SIZE){
                        this.hasMoreBusiness = false;
                    } else {
                        this.hasMoreBusiness = true;
                    }
                }
            },
            err => {
                console.log(err);
            }
        );
    }

}
