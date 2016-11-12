"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require('@angular/core');
var http_1 = require('@angular/http');
var Rx_1 = require('rxjs/Rx');
var app_constants_1 = require('./app.constants');
var AppService = (function () {
    function AppService(http) {
        this.http = http;
        this.getBusinessListUrl = app_constants_1.AppConstants.APP_URL + "home/GetBusinessList";
    }
    AppService.prototype.getBusinessList = function (data) {
        var headers = new http_1.Headers({ 'Content-type': 'multipart/form-data' });
        var options = new http_1.RequestOptions({ headers: headers });
        var formData = new FormData();
        if (data.start || data.size) {
            formData.append('start', data.start);
            formData.append('size', data.size);
        }
        if (data.BusinessName) {
            formData.append('business_name', data.BusinessName);
        }
        if (data.BusinessType) {
            formData.append('business_type', data.BusinessType);
        }
        var xhr = new XMLHttpRequest();
        xhr.open('post', this.getBusinessListUrl, true);
        xhr.send(formData);
        return Rx_1.Observable.create(function (res) {
            xhr.onreadystatechange = function () {
                if (xhr.readyState == 4) {
                    if (xhr.status == 200) {
                        res.next(JSON.parse(xhr.response));
                    }
                    else {
                        res.error(xhr.response);
                    }
                }
            };
        });
        // return this.http.post(this.getBusinessListUrl, formData, options)
        //                 .map((res:Response) => res.json())
        //                 .catch((error:any) => Observable.throw(error.json().error || "Server error" ));
    };
    AppService = __decorate([
        core_1.Injectable(), 
        __metadata('design:paramtypes', [http_1.Http])
    ], AppService);
    return AppService;
}());
exports.AppService = AppService;
//# sourceMappingURL=app.service.js.map