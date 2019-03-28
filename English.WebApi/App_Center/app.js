/// <reference path="../Assets/angular/angular.js"/>


(function () {
    angular.module('englishonline',
        ['englishonline.lesson',
            'englishonline.common'])
        .config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/App_Center/Component/home/homeView.html",
            controller: "homeController"
        });
        $urlRouterProvider.otherwise('/admin');
    }
})();