﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditApplication.aspx.cs" Inherits="admin_pt_x_unit_EditApplication" %>

<!DOCTYPE html>

<html data-ng-app="myModule" >

<head id="Head1"  >

    <title>
        DESIGN APPLICATION NOTICE
    </title>
    <link href="../../../css/ng-mobile-menu.min.css" rel="stylesheet" />
    <link href="../../../css/style.css" rel="stylesheet" />

  
    <script src="../../../js/jquery.js"></script>


    <script src="../../../js/funk.js" type="text/javascript"></script>

    <style type="text/css">
        .ProgressBar {
            margin: 0px;
            border: 0px;
            padding: 0px;
            width: 100%;
            height: 3em;
        }
    </style>

    <link rel="stylesheet" href="../../../css/jquery.ui.all.css" type="text/css" />
    <link rel="stylesheet" href="../../../css/jquery.ui.theme.css" type="text/css" />


    <script src="../../../js/jquery-1.7.2.min.js" type="text/javascript"></script>
    <script src="../../../js/jquery-ui-1.8.16.custom.min.js" type="text/javascript"></script>
    <script src="../../../js/jquery.js" type="text/javascript"></script>
    <script src="../../../js/ui/jquery.cookie.js" type="text/javascript"></script>
    <script src="../../../js/ui/jquery.ui.core.js" type="text/javascript"></script>
    <script src="../../../js/ui/jquery.ui.widget.js" type="text/javascript"></script>
    <script src="../../../js/angular.min.js"></script>
    <!--<script src="../../../Scripts/angular.min.js"></script>-->
    <script src="../../../js/ui/jquery.ui.datepicker.js" type="text/javascript"></script>

    <link href="../../../css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../../Scripts/EditApplication.js"></script>
    <script src="../../../js/smart-table.min.js"></script>
    <script src="../../../js/loading-bar.js"></script>
    <link href="../../../css/sweet-alert.css" rel="stylesheet" />
    <link href="../../../css/loading-bar.css" rel="stylesheet" />
    <script src="../../../js/sweet-alert.min.js"></script>
    <link href="../../../css/angular-datepicker.min.css" rel="stylesheet" />
    <script src="../../../js/angular-datepicker.min.js"></script>
    <link href="../../../css/font-awesome.min.css" rel="stylesheet" />
    <!--<script src="../../../Scripts/angular-pageslide-directive.min.js"></script>
    <link href="../../../css/jasny-bootstrap.min.css" rel="stylesheet" />
    <script src="../../../Scripts/jasny-bootstrap.min.js"></script>-->
   
    
    <!--<script src="//cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.min.js"></script>-->
    <script language="javascript" type="text/javascript">
   
   
   

    $(function () {

        $(".txt_date_pri").datepicker({
            changeMonth: true,
            changeYear: true,
            showButtonPanel: true,
            dateFormat: 'yy-mm-dd',
            yearRange: 'c-100:c+0'
        });

    });
    </script>


    <script language="javascript" type="text/javascript">
// <![CDATA[
        function Proceed_onclick() {
            window.location.href = "./application.aspx";
        }

// ]]>
    </script>
    <style type="text/css">
        p.MsoNormal {
            margin-top: 0in;
            margin-right: 0in;
            margin-bottom: 10.0pt;
            margin-left: 0in;
            line-height: 115%;
            font-size: 11.0pt;
            font-family: "Calibri","sans-serif";
        }

        p.MsoListParagraphCxSpFirst {
            margin-top: 0in;
            margin-right: 0in;
            margin-bottom: 0in;
            margin-left: .5in;
            margin-bottom: .0001pt;
            line-height: 115%;
            font-size: 11.0pt;
            font-family: "Calibri","sans-serif";
        }

        p.MsoListParagraphCxSpMiddle {
            margin-top: 0in;
            margin-right: 0in;
            margin-bottom: 0in;
            margin-left: .5in;
            margin-bottom: .0001pt;
            line-height: 115%;
            font-size: 11.0pt;
            font-family: "Calibri","sans-serif";
        }

        p.MsoListParagraphCxSpLast {
            margin-top: 0in;
            margin-right: 0in;
            margin-bottom: 10.0pt;
            margin-left: .5in;
            line-height: 115%;
            font-size: 11.0pt;
            font-family: "Calibri","sans-serif";
        }

        a:link {
            color: blue;
            text-decoration: underline;
        }

        .style1 {
            color: black;
        }
    </style>

    <style>


  #sidebar-menu {

  top: 0px;

  width: 100%;

}

 

#sidebar-menu li { border-bottom: 1px solid rgba(238, 238, 238, 0.05); }

 

#sidebar-menu a {

  text-decoration: none;

  color: #595959;

}

 

#sidebar-menu a:hover {

  text-decoration: none;

  color: #595959;

}

    </style>
</head>
<body >
   
       
      
    
    <form> 

        <div ng-controller="myController">
            <div>
                <div>

                    <table ng-show="vshow" align="center" width="100%" class="form table">
                        <tr>
                            <td align="center">

                                <img alt="Coat Of Arms" height="79" src="../../../images/coat_of_arms.png"
                                     width="85" /><br />
                                FEDERAL REPUBLIC OF NIGERIA<br />
                                FEDERAL MINISTRY OF INDUSTRY, TRADE AND INVESTMENT<br />
                                COMMERCIAL LAW DEPARTMENT<br />
                                TRADEMARKS, PATENTS AND DESIGNS REGISTRY<br />
                                PATENTS AND DESIGNS ACT CAP 344
                            </td>
                        </tr>


                        <tr>
                            <td width="22%" align="center" bgcolor="#990033">

                                <input type="text" ng-model="OnlineNumber" data-tooltip="sticky1" class="form-control" id="OnlineNumber" placeholder="Online Number">
                            </td>
                        </tr>







                        <tr>
                            <td class="tbbg">
                                <button type="button" ng-click="add()" class="btn   btn-info "><i class="fa fa-search"></i>Search</button>
                            </td>
                        </tr>




                    </table>
                </div>

                <table align="center" ng-show="vshow2">
                    <tr>
                        <td>

                            <table style="width:100%;font-family:Calibri;" id="applicantForm" align="center">


                                <tr>
                                    <td colspan="2" style="font-size:18pt;line-height:115%;" align="center">
                                        EDIT  DESIGN APPLICATION
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2"></td>
                                </tr>
                                <tr>
                                    <td colspan="2" class="tbbg_left">
                                        &nbsp;APPLICANT INFORMATION >>
                                    </td>
                                </tr>

                                <tr>
                                    <td colspan="2">
                                        <table st-table="displayedCollection" st-safe-src="ListAgent" class="table table-responsive table-bordered">
                                            <thead>
                                                <tr>

                                                    <th st-sort="oai_no" class="tbbg2">Applicant Name</th>
                                                    <th st-sort="req_type" class="tbbg2">Applicant Email</th>
                                                    <th st-sort="reg_date" class="tbbg2">Applicant Mobile Number</th>
                                                    <th st-sort="reg_no" class="tbbg2">Applicant Address</th>




                                                </tr>

                                            </thead>
                                            <tbody>
                                                <tr ng-repeat="row in displayedCollection">

                                                    <td><input id="Text1" {{row.xname}} ng-model="row.xname" type="text" />  </td>

                                                    <td><input id="Text2" {{row.xemail}} ng-model="row.xemail" type="text" /> </td>
                                                    <td><input id="Text3" {{row.xmobile}} ng-model="row.xmobile" type="text" /> </td>
                                                    <td><textarea rows="4" {{row.address}} ng-model="row.address" cols="50">  </textarea> </td>



                                                </tr>
                                            </tbody>
                                            <tfoot>
                                                <tr>
                                                    <td colspan="12" class="text-center">
                                                        <div st-pagination="" st-items-by-page="itemsByPage" st-displayed-pages="12"></div>
                                                    </td>
                                                </tr>
                                            </tfoot>
                                        </table>
                                    </td>
                                </tr>


                            </table>

                        </td>
                    </tr>

                    <tr>
                        <td>

                            <table style="width:100%;font-family:Calibri;" id="applicantForm" align="center">


                                <tr>
                                    <td colspan="2"></td>
                                </tr>
                                <tr>
                                    <td colspan="2" class="tbbg_left">
                                        &nbsp;DESIGN INFORMATION >>
                                    </td>
                                </tr>

                                <tr>
                                    <td colspan="2">
                                        <table st-table="displayedCollection2" st-safe-src="ListAgent2" class="table table-responsive table-bordered">
                                            <thead>
                                                <tr>

                                                    <th st-sort="oai_no" class="tbbg2">TITLE OF DESIGN</th>

                                                    <th st-sort="reg_date" class="tbbg2">REGISTRATION NUMBER</th>
                                                    <th st-sort="reg_no" class="tbbg2">TYPE</th>
                                                    <th st-sort="reg_no" class="tbbg2">FILING DATE</th>
                                                    <!--<th st-sort="reg_no" class="tbbg2"></th>-->




                                                </tr>

                                            </thead>
                                            <tbody>
                                                <tr ng-repeat="row in displayedCollection2">

                                                    <td><input {{row.title_of_invention}} ng-model="row.title_of_invention" type="text" />  </td>

                                                    <td><input {{row.reg_number}} ng-model="row.reg_number" type="text" /> </td>
                                                    <td>
                                                        <select class="form-control" ng-model="row.xtype" data-ng-options="c.id as c.name for c in varray">
                                                            <!--<option value="">-- Select Country --</option>-->
                                                        </select>
                                                    </td>
                                                    <td><datepicker button-next="&lt;i class='fa fa-arrow-right'&gt;&lt;/i&gt;" button-prev="&lt;i class='fa fa-arrow-left'&gt;&lt;/i&gt;" date-format="yyyy-M-d"><input {{row.reg_date}} ng-model="row.reg_date" type="text" /> </datepicker> </td>
                                                    <!--<td><button type="button" ng-click="add()" class="btn   btn-info "><i class="fa fa-search"></i>Save</button></td>-->


                                                </tr>
                                            </tbody>
                                            <tfoot>
                                                <tr>
                                                    <td colspan="12" class="text-center">
                                                        <div st-pagination="" st-items-by-page="itemsByPage" st-displayed-pages="12"></div>
                                                    </td>
                                                </tr>
                                            </tfoot>
                                        </table>
                                    </td>
                                </tr>


                            </table>

                        </td>
                    </tr>

                    <tr>
                        <td>

                            <table style="width:100%;font-family:Calibri;" id="applicantForm" align="center">




                                <tr>
                                    <td colspan="2"></td>
                                </tr>
                                <tr>
                                    <td colspan="2" class="tbbg_left">
                                        &nbsp;TRUE CREATOR INFORMATION >>
                                    </td>
                                </tr>

                                <tr>
                                    <td colspan="2">
                                        <table st-table="displayedCollection3" st-safe-src="ListAgent3" class="table table-responsive table-bordered">
                                            <thead>
                                                <tr>

                                                    <th st-sort="oai_no" class="tbbg2">Name</th>
                                                    <th st-sort="req_type" class="tbbg2"> Email</th>
                                                    <th st-sort="reg_date" class="tbbg2">Mobile Number</th>
                                                    <th st-sort="reg_no" class="tbbg2"> Address</th>
                                                    <!--<th st-sort="reg_no" class="tbbg2"></th>-->




                                                </tr>

                                            </thead>
                                            <tbody>
                                                <tr ng-repeat="row in displayedCollection3">

                                                    <td><input id="Text1" {{row.xname}} ng-model="row.xname" type="text" />  </td>

                                                    <td><input id="Text2" {{row.xemail}} ng-model="row.xemail" type="text" /> </td>
                                                    <td><input id="Text3" {{row.xmobile}} ng-model="row.xmobile" type="text" /> </td>
                                                    <td><textarea rows="4" {{row.address}} ng-model="row.address" cols="50">  </textarea> </td>
                                                    <!--<td><button type="button" ng-click="add()" class="btn   btn-info "><i class="fa fa-search"></i>Save</button></td>-->


                                                </tr>
                                            </tbody>
                                            <tfoot>
                                                <tr>
                                                    <td colspan="12" class="text-center">
                                                        <div st-pagination="" st-items-by-page="itemsByPage" st-displayed-pages="12"></div>
                                                    </td>
                                                </tr>
                                            </tfoot>
                                        </table>
                                    </td>
                                </tr>

                                <tr>
                                    <td colspan="2">
                                        <table id="doc_tbl" align="center" style="width:100%;font-family:Calibri;">
                                            <tr>
                                                <td class="tbbg" colspan="2"></td>
                                            </tr>
                                            <tr>
                                                <td align="center" colspan="2" style="color:Red; font-size:16px;"><strong><!--(NOTE: DOCUMENTS ATTACHED SHOULD  NOT BE  MORE THAN 3MB EACH!!)--></strong> </td>
                                            </tr>
                                            <tr style="background-color:#999999;">
                                                <td align="left" class="tbbg_left2" style="width:25%;">&nbsp;ITEMS</td>
                                                <td align="left" class="tbbg_left2">ATTACH DOCUMENT</td>
                                            </tr>
                                            <tr>
                                                <td align="left">&nbsp;LETTER OF AUTHORIZATION OF AGENT(FORM 2) : </td>
                                                <td align="left">
                                                    <input id="File1" type="file" /> <a target="_blank" ng-href="{{loa_doc}}" ng-if="show">View</a>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center" colspan="2"></td>
                                            </tr>
                                            <tr>
                                                <td align="left">&nbsp;DEED OF ASSIGNMENT : </td>
                                                <td align="left">
                                                    <input id="File2" type="file" /> <a target="_blank" ng-href="{{doa_doc}}" ng-if="show2">View</a>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2"></td>
                                            </tr>

                                            <tr>
                                                <td colspan="2"></td>
                                            </tr>
                                            <tr>
                                                <td align="left">&nbsp;NOVELTY STATEMENT:</td>
                                                <td align="left">
                                                    <input id="File3" type="file" /> <a target="_blank" ng-href="{{ns_doc}}" ng-if="show3">View</a>
                                                </td>
                                            </tr>


                                            <tr>
                                                <td colspan="2"></td>
                                            </tr>
                                            <tr>
                                                <td align="left">&nbsp;PRIORITY DOCUMENT :</td>
                                                <td align="left">
                                                    <input id="File4" type="file" /> <a target="_blank" ng-href="{{pd_doc}}" ng-if="show4">View</a>
                                                </td>
                                            </tr>

                                            <tr>
                                                <td colspan="2"></td>
                                            </tr>
                                            <tr>
                                                <td align="left">&nbsp;REPRESENTATION OF DESIGN 1 :</td>
                                                <td align="left">
                                                    <input id="File5" type="file" /> <a target="_blank" ng-href="{{rep1_pic}}" ng-if="show5">View</a>
                                                </td>
                                            </tr>

                                            <tr>
                                                <td align="left">&nbsp;REPRESENTATION OF DESIGN 2 :</td>
                                                <td align="left">
                                                    <input id="File6" type="file" /> <a target="_blank" ng-href="{{rep2_pic}}" ng-if="show6">View</a>
                                                </td>
                                            </tr>

                                            <tr>
                                                <td align="left">&nbsp;REPRESENTATION OF DESIGN 3 :</td>
                                                <td align="left">
                                                    <input id="File7" type="file" /> <a target="_blank" ng-href="{{rep3_pic}}" ng-if="show7">View</a>
                                                </td>
                                            </tr>

                                            <tr>
                                                <td align="left">&nbsp;REPRESENTATION OF DESIGN 4 :</td>
                                                <td align="left">
                                                    <input id="File8" type="file" /> <a target="_blank" ng-href="{{rep4_pic}}" ng-if="show8">View</a>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>

                                </tr>

                                <tr>
                                    <td><button type="button" ng-click="add2()" class="btn   btn-info "><i class="fa fa-save"></i>Update</button></td>

                                    <td><button type="button" ng-click="add3()" class="btn   btn-info "><i class="fa fa-search"></i>New Search</button></td>

                                </tr>


                            </table>

                        </td>
                    </tr>
                </table>
           
            </div>

        </div>
          <input id="xname" name="xname" type="hidden" value="<% =admin %>" />
     </form>
</body>
</html>
