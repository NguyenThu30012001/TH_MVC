
/// <reference path="../angular.min.js" />
//myap.controller("MyController", function ($scope) { //Khai báo 1 controller có tên MyController


//myap.controller("SanPhamController", function ($scope, $http) {
//    $http({
//        method: "get",
//        url: "/Sanpham/GetSanPham"

//    }).then(function Success(d)
//    {
//        $scope.SanPhams = d.data.sp;

//    }, function error() { });
//});

var myap = angular.module('MyApp', []);  //Khai báo 1 module có tên MyApp  
myap.controller("SanPhamController", function ($scope, $http) {
    var maLoai = "L001";//localStorage.getItem("MaLoai") 
    $http({
        method: "get",
        url: '/Sanpham/GetSanPhamLoai',
        params: { maloai: maLoai }
    }).then(function Success(d) {
        $scope.SanPhams = d.data;

    }, function error()
        {
            alert('Lấy sản phẩm lỗi');
    });
    



    //$http.get('/Sanpham/GetSanPham',
    //    {
    //        params: {maloai:MaLoai,}
    //    })
});







    var u = { name: "", pass: "" }

    $scope.User = u;

    $scope.MyClick = funtion()
    {
        alert("Hello");
    }


    $scope.Login = function () {
        if (($scope.User.name == 'hue') && ($scope.User.pass == '123')) {
            alert("Bạn đã đăng nhập")
        }
        else {
            alert("Đăng nhập không thành công")

        }
    };


