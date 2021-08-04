app.controller("showorder", function ($scope, $http, ajax, $routeParams) {
  var id = $routeParams.id;
  ajax.get(API_ROOT + "api/Order/" + id, success, error);
  function success(response) {
    $scope.order = response.data;
    $scope.showorders = response.data.Showorders;
    console.log($scope.showOrders);
    $scope.totalprice = 0;
    $scope.showOrders.forEach((product) => {
      $scope.totalprice += product.Quantity * product.Price;
    });
  }
  function error(error) {
    console.log(error);
  }
});
