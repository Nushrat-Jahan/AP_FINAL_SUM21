
app.controller("addcategories",function($scope,ajax,$location){

    $scope.addcategories = function(){
        //$scope.Name
        var d = {
          Id:0,
          Name:$scope.Name
        };
        ajax.post("https://localhost:44380/api/Category/Add",d,
        function(response){
            $location.path("/categories");
        },
        function(err){

        });
    };
});