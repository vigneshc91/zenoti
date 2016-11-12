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
var app_constants_1 = require('./app.constants');
var app_service_1 = require('./app.service');
var AppComponent = (function () {
    function AppComponent(appService) {
        this.appService = appService;
        this.searchQuery = '';
        this.searchType = '';
        this.businessModel = {};
        this.business = [];
        this.getBusinessList();
    }
    AppComponent.prototype.filterBusinessList = function () {
        if (this.searchType == "name") {
            this.businessModel.BusinessType = "";
            this.businessModel.BusinessName = this.searchQuery;
        }
        else if (this.searchType == "type") {
            this.businessModel.BusinessName = "";
            this.businessModel.BusinessType = this.searchQuery;
        }
        else {
            this.businessModel.BusinessName = "";
            this.businessModel.BusinessType = "";
        }
        this.business = [];
        this.getBusinessList(true);
    };
    AppComponent.prototype.getBusinessList = function (load) {
        var _this = this;
        var business = {};
        if (this.businessModel.BusinessName) {
            business.BusinessName = this.businessModel.BusinessName;
        }
        else if (this.businessModel.BusinessType) {
            business.BusinessType = this.businessModel.BusinessType;
        }
        if (load) {
            business.start = this.business.length;
            business.size = app_constants_1.AppConstants.PAGINATION_SIZE;
        }
        var response;
        response = this.appService.getBusinessList(business);
        response.subscribe(function (data) {
            if (data.status) {
                if (data.result.length) {
                    _this.business = _this.business.concat(data.result);
                }
                if (data.result.length < app_constants_1.AppConstants.PAGINATION_SIZE) {
                    _this.hasMoreBusiness = false;
                }
                else {
                    _this.hasMoreBusiness = true;
                }
            }
        }, function (err) {
            console.log(err);
        });
    };
    AppComponent = __decorate([
        core_1.Component({
            selector: 'zenoti-app',
            templateUrl: 'app/app.component.html',
            providers: [app_service_1.AppService]
        }), 
        __metadata('design:paramtypes', [app_service_1.AppService])
    ], AppComponent);
    return AppComponent;
}());
exports.AppComponent = AppComponent;
//# sourceMappingURL=app.component.js.map