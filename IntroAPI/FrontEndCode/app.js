var app = angular.module('BoilerPlate', []);

app.controller('artist', ["$scope", "$http", "$window", function ($scope, $http, $window) {
    console.log("found controller");

  $scope.artists = [];
    //$http.get("http://localhost:58614/api/artist/")
   $http.get("http://localhost:58614/api/artist/")
    .then(function(response){
            console.log("response", response);
            $scope.artists.push(response.data);
        });

    $scope.delete = function(ArtistId) {
    	console.log(ArtistId);
    	$http.delete("http://localhost:58614/api/artist/" + ArtistId).then(
    		function(response){
    			$window.location.reload();
    		}
    		);
    }


    }]);



