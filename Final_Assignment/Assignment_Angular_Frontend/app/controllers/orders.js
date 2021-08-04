app.controller("orders", function ($scope, $http, ajax) {
  ajax.get(API_ROOT + "api/Order/GetAll", success, error);
  function success(response) {
    $scope.orders = response.data;
  }
  function error(error) {}
});
