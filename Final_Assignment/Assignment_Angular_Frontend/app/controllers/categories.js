app.controller("categories",function($scope,$http,ajax){
    ajax.get(API_ROOT+"api/Category/GetAll",success,error);
    function success(response){
      $scope.categories=response.data;
    }
    function error(error){

    }

});
