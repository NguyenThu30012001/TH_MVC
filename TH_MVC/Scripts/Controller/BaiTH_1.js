/// <reference path="../angular.min.js" />
var myap = angular.module("MyApp", []);
myap.controller("GPTB2Controller", function ($scope, $rootScope) {

    $rootScope.tacgia = "Chu Thị Minh Huệ";

    $scope.MyClick = funtion()
    {
        alert("Hello");
    }
    $scope.GiaiPhuongTrinh = function () {

        var delta = $scope.PT.b * $scope.PT.b - 4 * $scope.PT.a * $scope.PT.c;
        alert(delta);
        if (delta < 0) {
            $scope.PT.KL = "PT vo nghiem";
        }
        else if (delta == 0) {
            $scope.PT.KL = "PT có nghiem kep";
            $scope.PT.X = - $scope.PT.b / 2 * $scope.PT.a;
        }
        else if (delta > 0) {
            $scope.PT.KL = "PT có nghiệm lần lượt là";
            $scope.PT.X1 = (- $scope.PT.b + Math.sqrt(delta)) / 2 * $scope.PT.a;
            $scope.PT.X2 = (- $scope.PT.b - Math.sqrt(delta)) / 2 * $scope.PT.a;
        }
    }

});


myap.controller("PhepToan", function ($scope, $rootScope) {
    $rootScope.tacgia = "Chu Thị Minh Huệ";
    $scope.Tinh = function () {
        if ($scope.P.pt == "+") {
            $scope.P.KQ = Number($scope.P.a) + Number($scope.P.b);
        }
        else if ($scope.P.pt == "-") {
            $scope.P.KQ = Number($scope.P.a) - Number($scope.P.b);
        }
        else if ($scope.P.pt == "*") {
            $scope.P.KQ = Number($scope.P.a) * Number($scope.P.b);
        }
        else if ($scope.P.pt == "/") {
            $scope.P.KQ = Number($scope.P.a) / Number($scope.P.b);
        }
    };
});



myap.controller("UserController", function ($scope) {
    var us = [{ name: "A", pas: "123" }, { name: "B", pas: "123" }, { name: "C", pas: "123" }];
    $scope.Users = us;
});