app.controller("placeorder", function ($scope, $http, ajax, $location) {
    ajax.get(API_ROOT+"api/Product/GetAll", success, error);
    function success(response) {
      $scope.productInfo = response.data;
    }
    function error(error) {
      console.log(error);
    }
    function addSuccess() {
      $location.path("/orders");
    }
    $scope.addedItem = []
  
    $scope.placeorder = function() {
      $scope.productInfo.forEach(e => {
        if(e.count>0){
          var productOrder = {
            Product_id: e.Id,
            Price: e.Price,
            Quantity: e.count
          }
          $scope.addedItem.push(productOrder);
        }
      });
      console.log($scope.addedItem);
      ajax.post(API_ROOT+"api/Order/PlaceOrder",$scope.addedItem,addSuccess,error);
      $scope.addedItem = []
    }
  });