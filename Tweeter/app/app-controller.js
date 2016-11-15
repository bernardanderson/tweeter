"use strict";

app.controller("userNameChecker", function($scope, $http) {

    $scope.tester = "This is a test";

    $scope.checkTheUserName = function() {

        $http({
            method: 'GET',
            url: '/api/TwitUsername'
        }).then(function successCallback(response) {
            console.log(response);
        }, function errorCallback(response) {
            console.log(response);
        });

        //$('#reporter').text("This has changed")
    }
});