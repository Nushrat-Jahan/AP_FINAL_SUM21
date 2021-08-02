var app = angular.module("myApp", ["ngRoute"]);
var API_ROOT = "https://localhost:44380/";
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/demopage.html"
    })
    .when("/demo", {
        templateUrl : "views/pages/demopage.html",
        controller: 'demo'
    })
    .when("/demo2", {
        templateUrl : "views/pages/demo2.html",
          controller: 'demo2'
    })
    .when("/products", {
        templateUrl : "views/pages/products.html",
        controller: 'products'
    })
    .when("/addproducts", {
        templateUrl : "views/pages/addproducts.html",
        controller: 'addproducts'
    })
    .when("/categories", {
        templateUrl : "views/pages/categories.html",
        controller: 'categories'
    })
    .when("/addcategories", {
        templateUrl : "views/pages/addcategories.html",
        controller: 'addcategories'
    })
    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
