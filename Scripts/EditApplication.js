﻿var app = angular.module('myModule', ['smart-table', 'angular-loading-bar', '720kb.datepicker']);
var serviceBaseDs = 'http://5.77.54.44/EinaoTestEnvironment.Design/';
app.controller('myController', ['$scope', '$http', '$rootScope', function ($scope, $http, $rootScope) {
    // GetCountries();

    //$(document).ready(function () {
    //    $("#navside").navside();

    //    $("#navside").navside({
           
    //        // 'right' or 'left'
    //        position         : 'right',
       
    //    // 'hidden' or 'fixed'
       
    //    scroll           : 'fixed'
       
   
       
    //});

    //});
    $scope.vshow = true;
    $scope.vshow2 = false;

    $scope.checked = true;
    $scope.toggle = function () {
        $scope.checked = !$scope.checked
    }

    $scope.varray = [{ name: 'TEXTILE', id: 'TEXTILE' }, { name: 'NON-TEXTILE', id: 'NON-TEXTILE' }]

    $scope.add3 = function () {
        $scope.vshow = true;
        $scope.vshow2 = false;

    }
   
    $scope.add2 = function () {
        swal({
            title: "",
            text: "Are you sure you want to update the  record",
            type: "warning",
            showCancelButton: true,
            confirmButtonColor: "#DD6B55", confirmButtonText: "UPDATE",
            cancelButtonText: "No!",
            closeOnConfirm: true,
            closeOnCancel: true
        },
function (isConfirm) {
    if (isConfirm) {
        var Applicant2 = []
        var Inventor2 = []
        var pt_info2 = []
        angular.forEach($scope.displayedCollection, function (item) {
            var Applicant = new Object();
            // if (item.description == true) {
            Applicant.ID = item.ID;
            Applicant.xname = item.xname;
            Applicant.xemail = item.xemail;
            Applicant.xmobile = item.xmobile;
            Applicant.address = item.address;

            Applicant2.push(Applicant)
            //  vcount = vcount + 1;
            //alert(item.oai_no)



        });

        angular.forEach($scope.displayedCollection3, function (item) {
            var Inventor = new Object();
            // if (item.description == true) {
            Inventor.ID = item.ID;
            Inventor.xname = item.xname;
            Inventor.xemail = item.xemail;
            Inventor.xmobile = item.xmobile;
            Inventor.address = item.address;

            Inventor2.push(Inventor)
            //  vcount = vcount + 1;
            //alert(item.oai_no)



        });



        angular.forEach($scope.displayedCollection2, function (item) {
            var pt_info = new Object();

            // if (item.description == true) {
            pt_info.xID = item.xID;
            pt_info.reg_number = item.reg_number;
            pt_info.xtype = item.xtype;
            pt_info.title_of_invention = item.title_of_invention;
            pt_info.loa_doc = item.loa_doc;
            pt_info.doa_doc = item.doa_doc;
            pt_info.ns_doc = item.ns_doc;
            pt_info.pd_doc = item.pd_doc;
            pt_info.rep_pic = item.rep_pic;
            pt_info.rep2_pic = item.rep2_pic;
            pt_info.rep3_pic = item.rep3_pic;
            pt_info.rep4_pic = item.rep4_pic;
            pt_info.reg_date = item.reg_date;
            pt_info2.push(pt_info)


        });


        var formData = new FormData();

        var xname = $("input#xname").val();
        formData.append("vid", JSON.stringify(Applicant2));
        formData.append("vid2", JSON.stringify(Inventor2));
        formData.append("vid3", JSON.stringify(pt_info2));
        formData.append("vid4", xname);

      
        var totalFiles;
        try {
            totalFiles = document.getElementById("File1").files.length;
        }
        catch (Ex) {

        }
        var totalFiles2;
        try {
            totalFiles2 = document.getElementById("File2").files.length;
        }
        catch (Ex) {

        }
        var totalFiles3;
        try {
            totalFiles3 = document.getElementById("File3").files.length;
        }
        catch (Ex) {

        }
        var totalFiles4;
        try {
            totalFiles4 = document.getElementById("File4").files.length;
        }


        catch (Ex) {

        }

        var totalFiles5;
        try {
            totalFiles5 = document.getElementById("File5").files.length;
        }


        catch (Ex) {

        }

        var totalFiles6;
        try {
            totalFiles6 = document.getElementById("File6").files.length;
        }


        catch (Ex) {

        }

        for (var i = 0; i < totalFiles; i++) {
            var file = document.getElementById("File1").files[i];



            formData.append("FileUpload", file);
        }

        for (var i = 0; i < totalFiles2; i++) {
            var file = document.getElementById("File2").files[i];



            formData.append("FileUpload2", file);
        }

        for (var i = 0; i < totalFiles3; i++) {
            var file = document.getElementById("File3").files[i];



            formData.append("FileUpload3", file);
        }

        for (var i = 0; i < totalFiles4; i++) {
            var file = document.getElementById("File4").files[i];



            formData.append("FileUpload4", file);
        }

        for (var i = 0; i < totalFiles5; i++) {
            var file = document.getElementById("File5").files[i];



            formData.append("FileUpload5", file);
        }

        for (var i = 0; i < totalFiles6; i++) {
            var file = document.getElementById("File6").files[i];



            formData.append("FileUpload6", file);
        }







        $http.post( serviceBaseDs + 'Handlers/PostTransaction.ashx', formData, {

            transformRequest: angular.identity,
            headers: { 'Content-Type': undefined }
        })
      .success(function (response) {

          //  ajaxindicatorstop();

          var kk = response

            swal("", "Record Updated Successfully", "success")
          //  window.location.assign("verify_data.aspx");

      })
      .error(function (aa) {
          var data = aa
          // ajaxindicatorstop();
            swal("","Error Occured","error")
      });

    } else {
        swal("Cancelled", "Action Canceled :)", "error");
    }
});


     

    }

    $scope.add = function () {
       
        var Encrypt = {
            vid: $scope.OnlineNumber
        }

        $http({
            method: 'POST',
            url:  serviceBaseDs + 'Handlers/EditApplication.ashx',
            transformRequest: function (obj) {
                var str = [];
                for (var p in obj)
                    str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
                return str.join("&");
            },
            data: Encrypt,
            headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8;' }
        })
            .success(function (response) {
                var dd = response;
                $scope.itemsByPage = 50;
                $scope.ListAgent = response;
                $scope.displayedCollection = [].concat($scope.ListAgent);



            })
            .error(function (response) {
                var ff = response
               // alert("error " + response)
            });


        $http({
            method: 'POST',
            url:  serviceBaseDs +  'Handlers/EditApplication2.ashx',
            transformRequest: function (obj) {
                var str = [];
                for (var p in obj)
                    str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
                return str.join("&");
            },
            data: Encrypt,
            headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8;' }
        })
        .success(function (response) {
            var dd = response;
            if (!(response.length > 0)) {

                swal("", "No Record Found ", "error");
                return;
            }
            $scope.vshow = false;
            $scope.vshow2 = true;
            $scope.itemsByPage = 50;
            $scope.ListAgent2 = response;
            $scope.displayedCollection2 = [].concat($scope.ListAgent2);

            if (response[0].loa_doc != "") {
                $scope.loa_doc =  serviceBaseDs + "admin/pt/" + response[0].loa_doc;
                $scope.show = true;

            }
            if (response[0].doa_doc != "") {
                $scope.doa_doc =  serviceBaseDs + "admin/pt/" + response[0].doa_doc;
                $scope.show2 = true;
            }
            if (response[0].ns_doc != "") {
                $scope.ns_doc =  serviceBaseDs + "admin/pt/" + response[0].ns_doc;
                $scope.show3 = true;
            }
            if (response[0].pd_doc != "") {
                $scope.pd_doc =  serviceBaseDs + "admin/pt/" + response[0].pd_doc;
                $scope.show4 = true;
            }
            if (response[0].rep_pic != "") {
                $scope.rep1_pic =  serviceBaseDs +  "admin/pt/" + response[0].rep_pic;
                $scope.show5 = true;
            }

            if (response[0].rep2_pic != "") {
                $scope.rep2_pic =  serviceBaseDs + "admin/pt/" + response[0].rep2_pic;
                $scope.show6 = true;
            }

            if (response[0].rep3_pic != "") {
                $scope.rep3_pic =  serviceBaseDs +  "admin/pt/" + response[0].rep3_pic;
                $scope.show7 = true;
            }

            if (response[0].rep4_pic != "") {
                $scope.rep4_pic = serviceBaseDs +  "admin/pt/" + response[0].rep4_pic;
                $scope.show8 = true;
            }

        })
        .error(function (response) {
            var ff = response
            // alert("error " + response)
        });



        $http({
            method: 'POST',
            url:  serviceBaseDs +  'Handlers/EditApplication3.ashx',
            transformRequest: function (obj) {
                var str = [];
                for (var p in obj)
                    str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
                return str.join("&");
            },
            data: Encrypt,
            headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8;' }
        })
 .success(function (response) {
     var dd = response;
     $scope.itemsByPage = 50;
     $scope.ListAgent3 = response;
     $scope.displayedCollection3 = [].concat($scope.ListAgent3);



 })
 .error(function (response) {
     var ff = response
     // alert("error " + response)
 });

        $http({
            method: 'POST',
            url:  serviceBaseDs +  'Handlers/EditApplication4.ashx',
            transformRequest: function (obj) {
                var str = [];
                for (var p in obj)
                    str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
                return str.join("&");
            },
            data: Encrypt,
            headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8;' }
        })
.success(function (response) {
    var dd = response;
    $scope.itemsByPage = 50;
    $scope.ListAgent4 = response;
    $scope.displayedCollection4 = [].concat($scope.ListAgent4);



})
.error(function (response) {
    var ff = response
    // alert("error " + response)
});


        $http({
            method: 'POST',
            url:  serviceBaseDs + 'Handlers/EditApplication5.ashx',
            transformRequest: function (obj) {
                var str = [];
                for (var p in obj)
                    str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
                return str.join("&");
            },
            data: Encrypt,
            headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8;' }
        })
.success(function (response) {
    var dd = response;
    $scope.itemsByPage = 50;
    $scope.ListAgent5 = response;
    $scope.displayedCollection5 = [].concat($scope.ListAgent5);
   
  

})
.error(function (response) {
    var ff = response
    // alert("error " + response)
});


    }


}]);

app.controller('myController2', ['$scope', '$http', '$rootScope', function ($scope, $http, $rootScope) {
    // GetCountries();

    //$(document).ready(function () {
    //    $("#navside").navside();

    //    $("#navside").navside({

    //        // 'right' or 'left'
    //        position         : 'right',

    //    // 'hidden' or 'fixed'

    //    scroll           : 'fixed'



    //});

    //});

    $scope.add7 = function () {

        $scope.vshow = true;
        $scope.vshow2 = false;
    }

    $scope.add6 = function () {
     

            window.open(
      serviceBaseDs +  "admin/pt/Design_Akwnolgment.aspx?x=" + $scope.xid,
      '_blank' // <- This is what makes it open in a new window.
    );

            //    window.location.href = "http://ds.cldng.com/admin/pt/Design_Akwnolgment.aspx?x=" + xname ;

     

    }

    $scope.vshow = true;
    $scope.vshow2 = false;

    $scope.checked = true;
   

    $scope.add3 = function () {
        $scope.vshow = true;
        $scope.vshow2 = false;

    }

   

    $scope.add = function () {

        var Encrypt = {
            vid: $scope.OnlineNumber
        }

        $http({
            method: 'POST',

            url:  serviceBaseDs + 'Handlers/EditStatus.ashx',
            transformRequest: function (obj) {
                var str = [];
                for (var p in obj)
                    str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
                return str.join("&");
            },
            data: Encrypt,
            headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8;' }
        })
            .success(function (response) {
                var dd2 = response;

                var Encrypt2 = {
                    vid: response[0].applicantID
                }

                $http({
                    method: 'POST',
                 
                    url:  serviceBaseDs + 'Handlers/EditStatus2.ashx',
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
             var dst = eval("(" + response + ")"); // unescape(response.replace('\u0026', " "));
             $scope.vname = dst;

             $scope.vstatus = DesignStatus(dd2[0].status, dd2[0].data_status)

             $scope.vshow = false;
             $scope.vshow2 = true;



         })
         .error(function (response) {
             var ff = response
             // alert("error " + response)
         });

                //$scope.vstatus = DesignStatus(response[0].status, response[0].data_status)
            



            })
            .error(function (response) {
                var ff = response
                // alert("error " + response)
            });





        $http({
            method: 'POST',
            url:  serviceBaseDs + 'Handlers/EditApplication2.ashx',
            transformRequest: function (obj) {
                var str = [];
                for (var p in obj)
                    str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
                return str.join("&");
            },
            data: Encrypt,
            headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8;' }
        })
 .success(function (response) {
     $scope.xid = response[0].xID;

   //  $scope.vstatus = DesignStatus(dd2[0].status, dd2[0].data_status)



 })
 .error(function (response) {
     var ff = response
     // alert("error " + response)
 });



    }


   

}]);


function DesignStatus(status, data_status) {
  
    var User_Status = new Object();
    User_Status.data_status = "NA"
    User_Status.status="NA"
    try {
        if (status == "1") {
            User_Status.status = "Payment Verification Office";
            if (data_status == "Fresh") {
                User_Status.data_status = "Untreated";
            }
            else if (data_status == "Invalid") {
                User_Status.data_status = "Invalid";
            }
            else if (data_status == "V_Contact") {
                User_Status.data_status = "Being processed";
            }
        }
        if (status == "2") {
            User_Status.status = "Search Office";
            if (data_status == "Valid") {
                User_Status.data_status = "Successfully reviewed";
            }
            else if (data_status == "S_Contact") {
                User_Status.data_status = "Being processed";
            }
        }
        if (status == "3") {
            User_Status.status = "Examiner 1 Office";
            if (data_status == "Further Search") {
                User_Status.data_status = "Further search required";
                User_Status.status = "Search Office";
            }
            else if (data_status == "E_Contact") {
                User_Status.data_status = "Being processed";
            }
            else if (data_status == "Search Conducted") {
                User_Status.data_status = "Successfully reviewed";
            }
            else if (data_status == "Refused") {
                User_Status.data_status = "Refused";
            }
        }
        if (status == "4") {
            User_Status.status = "Approving Office";
            if (data_status == "Not-Patentable") {
                User_Status.data_status = "Not-patentable";
                User_Status.status = "Examiner 1 Office";
            }
            else if (data_status == "A_Contact") {
                User_Status.data_status = "Being processed";
            }
            else if (data_status == "Futher Review") {
                User_Status.data_status = "Successfully reviewed";
            }
            else if (data_status == "Certified") {
                User_Status.data_status = "Certified";
            }
        }
        if (status == "5") {
            User_Status.status = "Registrars Office";
            if (data_status == "Review Patent") {
                User_Status.data_status = "Being reviewed";
                User_Status.status = "Approving Office";
            }
            else if (data_status == "R_Contact") {
                User_Status.data_status = "Being processed";
            }
            else if (data_status == "Patentable") {
                User_Status.data_status = "Successfully reviewed";
            }
            else if (data_status == "Accepted") {
                User_Status.data_status = "Successfully reviewed";
            }
        }
        if (status == "6") {
            User_Status.status = "Registrars Office";
            if (data_status == "Grant Patent") {
                User_Status.data_status = "Granted";
            }
        }



    
    }

    catch (ee) {


    }
    return User_Status;

}