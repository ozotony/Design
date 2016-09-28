var app = angular.module('myModule', ['smart-table', 'angular-loading-bar']);
//var serviceBaseDs = 'http://ds.cldng.com/';

var serviceBaseDs = 'http://localhost:60693/';



var serviceBaseIpo = 'http://ipo.cldng.com/';

var serviceBaseCld = 'http://tm.cldng.com/';

app.filter('offset', function () {
    return function (input, start) {
        start = parseInt(start, 10);
        return input.slice(start);
    };
});


app.controller('myController', ['$scope', '$http', '$rootScope', function ($scope, $http, $rootScope) {

    
    $http({
        method: 'GET',
        url: serviceBaseDs +'/Handlers/Getdata.ashx'
       // url: 'http://localhost:60693/Handlers/Getdata.ashx'
    }).success(function (data, status, headers, config) {
        var dd =data;
      
        $scope.itemsByPage = 10;
        $scope.ListAgent = data;
        $scope.displayedCollection = [].concat($scope.ListAgent);
    }).error(function (data, status, headers, config) {
        alert("error " +data)
        $scope.message = 'Unexpected Error';
    });


    //When you have entire dataset



}]);


app.controller('myController2', ['$scope', '$http', '$rootScope', function ($scope, $http, $rootScope) {

   
    $http({
        method: 'GET',
        url: serviceBaseDs +'/Handlers/Getdata2.ashx'
      //  url: 'http://localhost:60693/Handlers/Getdata2.ashx'
    }).success(function (data, status, headers, config) {
        var dd = data;

        $scope.itemsByPage = 10;
        $scope.ListAgent = data;
        $scope.displayedCollection = [].concat($scope.ListAgent);
    }).error(function (data, status, headers, config) {
        alert("error " + data)
        $scope.message = 'Unexpected Error';
    });


    //When you have entire dataset



}]);

app.controller('myController3', ['$scope', '$http', '$rootScope', function ($scope, $http, $rootScope) {
   

    $http({
        method: 'GET',
        url: serviceBaseDs +'/Handlers/Getdata3.ashx'
      //  url: 'http://localhost:60693/Handlers/Getdata3.ashx'
    }).success(function (data, status, headers, config) {
        var dd = data;

        $scope.itemsByPage = 10;
        $scope.ListAgent = data;
        $scope.displayedCollection = [].concat($scope.ListAgent);
    }).error(function (data, status, headers, config) {
        alert("error " + data)
        $scope.message = 'Unexpected Error';
    });


    //When you have entire dataset



}]);

app.controller('myController4', ['$scope', '$http', '$rootScope', '$interval', function ($scope, $http, $rootScope,$interval) {
    var serviceBase6 = serviceBaseDs +'/Handlers/GetEmailCount4.ashx';
    var Encrypt6 = {
        vid: "2",
        vid2: "Valid"

    }


    $http({
        method: 'POST',
        url: serviceBase6,
        transformRequest: function (obj) {
            var str = [];
            for (var p in obj)
                str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
            return str.join("&");
        },
        data: Encrypt6,
        headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8;' }
    })
        .success(function (response) {
            // var a = parseInt(response);
            $rootScope.result = response;


        })
        .error(function (response) {
            var dd = response;
            //  ajaxindicatorstop();
        });

    $scope.add2 = function (dd) {

        for (var key in $rootScope.result) {

            if ($rootScope.result[key] == dd.Validation) {

                return true;
            }


        }





    }

    var serviceBase3 = serviceBaseDs +'/Handlers/GetEmailCount2.ashx';
    var Encrypt2 = {
        vid: "2",
        vid2: "Valid"
    }
    $(document).ready(function () {


        $http({
            method: 'POST',
            url: serviceBase3,
            transformRequest: function (obj) {
                var str = [];
                for (var p in obj)
                    str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
                return str.join("&");
            },
            data: Encrypt2,
            headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8;' }
        })
            .success(function (response) {
                if (response != "null") {
                    $scope.news = [
      { "firstName": response, "link": "../x_unit/profile4.aspx" }
                    ]

                }


            })
            .error(function (response) {
                var dd = response;
                //  ajaxindicatorstop();
            });


        //   alert(xname)

    });

    $scope.conf = {
        news_length: false,
        news_pos: 400, // the starting position from the right in the news container
        news_margin: 40,
        news_move_flag: true
    };


    $scope.get_news_right = function (idx) {

        if ($scope.conf.news_pos == '0') {
            $scope.conf.news_pos = 400;
        }

        var $right = $scope.conf.news_pos;
        for (var ri = 0; ri < idx; ri++) {
            if (document.getElementById('news_' + ri)) {
                $right += $scope.conf.news_margin + angular.element(document.getElementById('news_' + ri))[0].offsetWidth;
            }
        }
        return $right + 'px';

        //  return '30px';
    };

    $scope.news_move = function () {

        if ($scope.conf.news_move_flag) {
            $scope.conf.news_pos--;
            try {

                if (angular.element(document.getElementById('news_0'))[0].offsetLeft > angular.element(document.getElementById('news_strip'))[0].offsetWidth + $scope.conf.news_margin) {

                    var first_new = $scope.news[0];
                    $scope.news.push(first_new);
                    $scope.news.shift();
                    $scope.conf.news_pos += angular.element(document.getElementById('news_0'))[0].offsetWidth + $scope.conf.news_margin;
                }

            }

            catch (err) {
                // document.getElementById("demo").innerHTML = err.message;
            }
        }
    };

    $interval($scope.news_move, 50);

    var Encrypt4 = {
        vid: "2",
        vid2: "Valid"
    }

    var serviceBase = serviceBaseDs +'/Handlers/GetEmailCount.ashx';
    $(document).ready(function () {


        $http({
            method: 'POST',
            url: serviceBase,
            transformRequest: function (obj) {
                var str = [];
                for (var p in obj)
                    str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
                return str.join("&");
            },
            data: Encrypt4,
            headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8;' }
        })
            .success(function (response) {
                var dd = [];
                var a = parseInt(response);
                if (a > 0) {
                    $rootScope.xvv = true;

                }
                $rootScope.vcount = response



            })
            .error(function (response) {
                //  ajaxindicatorstop();
            });


        //   alert(xname)

    });

    $scope.BranchCollect = [];
    $scope.itemsPerPage = 10;
    $scope.currentPage = 0;
    $scope.items = [];
    $scope.isDisabled = false;
    var url3 = 'http://localhost:55482/Handlers/GetRegistration2.ashx';

    // var url3 = ' http://localhost:21936/home/GetAgent';

    var Encrypt = {
        vid: "2",
        vid2: "S_Contact"
    }



    $http({
        method: 'GET',
        url: serviceBaseDs +'/Handlers/Getdata4.ashx'
     //   url: 'http://localhost:60693/Handlers/Getdata4.ashx'
    }).success(function (data, status, headers, config) {
        var dd = data;

        $scope.itemsByPage = 10;
        $scope.ListAgent = data;
        $scope.displayedCollection = [].concat($scope.ListAgent);
    }).error(function (data, status, headers, config) {
        alert("error " + data)
        $scope.message = 'Unexpected Error';
    });


    //When you have entire dataset



}]);

app.controller('myController5', ['$scope', '$http', '$rootScope', function ($scope, $http, $rootScope) {
    

    $http({
        method: 'GET',
        url: serviceBaseDs +'/Handlers/Getdata5.ashx'
       // url: 'http://localhost:60693/Handlers/Getdata5.ashx'
    }).success(function (data, status, headers, config) {
        var dd = data;

        $scope.itemsByPage = 10;
        $scope.ListAgent = data;
        $scope.displayedCollection = [].concat($scope.ListAgent);
    }).error(function (data, status, headers, config) {
        alert("error " + data)
        $scope.message = 'Unexpected Error';
    });


    //When you have entire dataset



}]);

app.controller('myController6', ['$scope', '$http', '$rootScope', '$interval', function ($scope, $http, $rootScope, $interval) {
    
    var serviceBase6 = serviceBaseDs +'/Handlers/GetEmailCount4.ashx';
    var Encrypt6 = {
        vid: "3",
        vid2: "Search Conducted"

    }


    $http({
        method: 'POST',
        url: serviceBase6,
        transformRequest: function (obj) {
            var str = [];
            for (var p in obj)
                str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
            return str.join("&");
        },
        data: Encrypt6,
        headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8;' }
    })
        .success(function (response) {
            // var a = parseInt(response);
            $rootScope.result = response;


        })
        .error(function (response) {
            var dd = response;
            //  ajaxindicatorstop();
        });

    $scope.add2 = function (dd) {

        for (var key in $rootScope.result) {

            if ($rootScope.result[key] == dd.ApplicantId) {

                return true;
            }


        }





    }
    $scope.BranchCollect = [];
    $scope.itemsPerPage = 10;
    $scope.currentPage = 0;
    $scope.items = [];
    $scope.isDisabled = false;
    var Encrypt2 = {
        vid: "3",
        vid2: "Search Conducted"
    }

    var serviceBase3 = serviceBaseDs +'/Handlers/GetEmailCount2.ashx';
    $(document).ready(function () {


        $http({
            method: 'POST',
            url: serviceBase3,
            transformRequest: function (obj) {
                var str = [];
                for (var p in obj)
                    str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
                return str.join("&");
            },
            data: Encrypt2,
            headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8;' }
        })
            .success(function (response) {
                if (response != "null") {
                    $scope.news = [
      { "firstName": response, "link": "../x_unit/profile4.aspx" }
                    ]

                }


            })
            .error(function (response) {
                //  ajaxindicatorstop();
            });


        //   alert(xname)

    });

    $scope.conf = {
        news_length: false,
        news_pos: 400, // the starting position from the right in the news container
        news_margin: 20,
        news_move_flag: true
    };

    $scope.get_news_right = function (idx) {
        if ($scope.conf.news_pos == '0') {
            $scope.conf.news_pos = 400;
        }


        var $right = $scope.conf.news_pos;
        for (var ri = 0; ri < idx; ri++) {
            if (document.getElementById('news_' + ri)) {
                $right += $scope.conf.news_margin + angular.element(document.getElementById('news_' + ri))[0].offsetWidth;
            }
        }
        return $right + 'px';
    };

    $scope.news_move = function () {
        if ($scope.conf.news_move_flag) {
            $scope.conf.news_pos--;
            if (angular.element(document.getElementById('news_0'))[0].offsetLeft > angular.element(document.getElementById('news_strip'))[0].offsetWidth + $scope.conf.news_margin) {
                var first_new = $scope.news[0];
                $scope.news.push(first_new);
                $scope.news.shift();
                $scope.conf.news_pos += angular.element(document.getElementById('news_0'))[0].offsetWidth + $scope.conf.news_margin;
            }
        }
    };

    $interval($scope.news_move, 50);

    var Encrypt4 = {
        vid: "3",
        vid2: "Search Conducted"
    }

    var serviceBase = serviceBaseDs +'/Handlers/GetEmailCount.ashx';
    $(document).ready(function () {


        $http({
            method: 'POST',
            url: serviceBase,
            transformRequest: function (obj) {
                var str = [];
                for (var p in obj)
                    str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
                return str.join("&");
            },
            data: Encrypt4,
            headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8;' }
        })
            .success(function (response) {
                var dd = [];
                var a = parseInt(response);
                if (a > 0) {
                    $rootScope.xvv = true;

                }
                $rootScope.vcount = response



            })
            .error(function (response) {
                //  ajaxindicatorstop();
            });


        //   alert(xname)

    });

    $http({
        method: 'GET',
        url: serviceBaseDs +'/Handlers/Getdata6.ashx'
      //  url: 'http://localhost:60693/Handlers/Getdata6.ashx'
    }).success(function (data, status, headers, config) {
        var dd = data;

        $scope.itemsByPage = 10;
        $scope.ListAgent = data;
        $scope.displayedCollection = [].concat($scope.ListAgent);
    }).error(function (data, status, headers, config) {
        alert("error " + data)
        $scope.message = 'Unexpected Error';
    });


    //When you have entire dataset



}]);

app.controller('myController7', ['$scope', '$http', '$rootScope', function ($scope, $http, $rootScope) {
    

    $http({
        method: 'GET',
       url: serviceBaseDs +'/Handlers/Getdata7.ashx'
      //  url: 'http://localhost:60693/Handlers/Getdata7.ashx'
    }).success(function (data, status, headers, config) {
        var dd = data;

        $scope.itemsByPage = 10;
        $scope.ListAgent = data;
        $scope.displayedCollection = [].concat($scope.ListAgent);
    }).error(function (data, status, headers, config) {
        alert("error " + data)
        $scope.message = 'Unexpected Error';
    });


    //When you have entire dataset



}]);

app.controller('myController8', ['$scope', '$http', '$rootScope', function ($scope, $http, $rootScope) {
   

    $http({
        method: 'GET',
        url: serviceBaseDs +'/Handlers/Getdata8.ashx'
      //  url: 'http://localhost:60693/Handlers/Getdata8.ashx'
    }).success(function (data, status, headers, config) {
        var dd = data;

        $scope.itemsByPage = 10;
        $scope.ListAgent = data;
        $scope.displayedCollection = [].concat($scope.ListAgent);
    }).error(function (data, status, headers, config) {
        alert("error " + data)
        $scope.message = 'Unexpected Error';
    });


    //When you have entire dataset



}]);

app.controller('myController9', ['$scope', '$http', '$rootScope', function ($scope, $http, $rootScope) {

   
    $http({
        method: 'GET',
       url: serviceBaseDs +'/Handlers/Getdata9.ashx'
      //  url: 'http://localhost:60693/Handlers/Getdata9.ashx'
    }).success(function (data, status, headers, config) {
        var dd = data;

        $scope.itemsByPage = 10;
        $scope.ListAgent = data;
        $scope.displayedCollection = [].concat($scope.ListAgent);
    }).error(function (data, status, headers, config) {
        alert("error " + data)
        $scope.message = 'Unexpected Error';
    });


    //When you have entire dataset



}]);


app.controller('myController10', ['$scope', '$http', '$rootScope', function ($scope, $http, $rootScope) {

   
    $http({
        method: 'GET',
       url: serviceBaseDs +'/Handlers/Getdata10.ashx'
      //  url: 'http://localhost:60693/Handlers/Getdata10.ashx'
    }).success(function (data, status, headers, config) {
        var dd = data;

        $scope.itemsByPage = 10;
        $scope.ListAgent = data;
        $scope.displayedCollection = [].concat($scope.ListAgent);
    }).error(function (data, status, headers, config) {
        alert("error " + data)
        $scope.message = 'Unexpected Error';
    });


    //When you have entire dataset



}]);

app.controller('myController11', ['$scope', '$http', '$rootScope', function ($scope, $http, $rootScope) {
    

    $http({
        method: 'GET',
        url: serviceBaseDs +'/Handlers/Getdata11.ashx'
      //  url: 'http://localhost:60693/Handlers/Getdata11.ashx'
    }).success(function (data, status, headers, config) {
        var dd = data;

        $scope.itemsByPage = 10;
        $scope.ListAgent = data;
        $scope.displayedCollection = [].concat($scope.ListAgent);
    }).error(function (data, status, headers, config) {
        alert("error " + data)
        $scope.message = 'Unexpected Error';
    });


    //When you have entire dataset



}]);

app.controller('myController12', ['$scope', '$http', '$rootScope', function ($scope, $http, $rootScope) {
    

    $http({
        method: 'GET',
        url: serviceBaseDs +'/Handlers/Getdata12.ashx'
     //   url: 'http://localhost:60693/Handlers/Getdata12.ashx'
    }).success(function (data, status, headers, config) {
        var dd = data;

        $scope.itemsByPage = 10;
        $scope.ListAgent = data;
        $scope.displayedCollection = [].concat($scope.ListAgent);
    }).error(function (data, status, headers, config) {
        alert("error " + data)
        $scope.message = 'Unexpected Error';
    });


    //When you have entire dataset



}]);

app.controller('myController13', ['$scope', '$http', '$rootScope', function ($scope, $http, $rootScope) {

    
    $http({
        method: 'GET',
        url: serviceBaseDs +'/Handlers/Getdata13.ashx'
      //  url: 'http://localhost:60693/Handlers/Getdata13.ashx'
    }).success(function (data, status, headers, config) {
        var dd = data;

        $scope.itemsByPage = 10;
        $scope.ListAgent = data;
        $scope.displayedCollection = [].concat($scope.ListAgent);
    }).error(function (data, status, headers, config) {
        alert("error " + data)
        $scope.message = 'Unexpected Error';
    });


    //When you have entire dataset



}]);

app.controller('myController14', ['$scope', '$http', '$rootScope', function ($scope, $http, $rootScope) {
    

    $http({
        method: 'GET',
        url: serviceBaseDs +'/Handlers/Getdata14.ashx'
     //   url: 'http://localhost:60693/Handlers/Getdata14.ashx'
    }).success(function (data, status, headers, config) {
        var dd = data;

        $scope.itemsByPage = 10;
        $scope.ListAgent = data;
        $scope.displayedCollection = [].concat($scope.ListAgent);
    }).error(function (data, status, headers, config) {
        alert("error " + data)
        $scope.message = 'Unexpected Error';
    });


    //When you have entire dataset



}]);

app.controller('myController15', ['$scope', '$http', '$rootScope', function ($scope, $http, $rootScope) {
   

    $http({
        method: 'GET',
       url: serviceBaseDs +'/Handlers/Getdata15.ashx'
       // url: 'http://localhost:60693/Handlers/Getdata15.ashx'
    }).success(function (data, status, headers, config) {
        var dd = data;

        $scope.itemsByPage = 10;
        $scope.ListAgent = data;
        $scope.displayedCollection = [].concat($scope.ListAgent);
    }).error(function (data, status, headers, config) {
        alert("error " + data)
        $scope.message = 'Unexpected Error';
    });


    //When you have entire dataset



}]);










function ajaxindicatorstart(text) {

    if (jQuery('body').find('#resultLoading').attr('id') != 'resultLoading') {

        jQuery('body').append('<div id="resultLoading" style="display:none"><div><img src="../ajax-loader.jpg"><div>' + text + '</div></div><div class="bg"></div></div>');

    }



    jQuery('#resultLoading').css({

        'width': '100%',

        'height': '100%',

        'position': 'fixed',

        'z-index': '10000000',

        'top': '0',

        'left': '0',

        'right': '0',

        'bottom': '0',

        'margin': 'auto'

    });



    jQuery('#resultLoading .bg').css({

        'background': '#000000',

        'opacity': '0.7',

        'width': '100%',

        'height': '100%',

        'position': 'absolute',

        'top': '0'

    });



    jQuery('#resultLoading>div:first').css({

        'width': '250px',

        'height': '75px',

        'text-align': 'center',

        'position': 'fixed',

        'top': '0',

        'left': '0',

        'right': '0',

        'bottom': '0',

        'margin': 'auto',

        'font-size': '16px',

        'z-index': '10',

        'color': '#ffffff'



    });



    jQuery('#resultLoading .bg').height('100%');

    jQuery('#resultLoading').fadeIn(300);

    jQuery('body').css('cursor', 'wait');

}

function ajaxindicatorstop() {

    jQuery('#resultLoading .bg').height('100%');

    jQuery('#resultLoading').fadeOut(300);

    jQuery('body').css('cursor', 'default');

}
