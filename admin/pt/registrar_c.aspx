<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registrar_c.aspx.cs" Inherits="admin_pt_registrar_c" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" data-ng-app="myModule">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="../../css/style.css" />

<link rel="stylesheet" href="../../css/jquery.ui.all.css" />

  <script type="text/javascript" src="../../js/jquery-2.1.1.min.js"></script>

<script type="text/javascript" src="../../js/ui/jquery.cookie.js"></script>

<script type="text/javascript" src="../../js/ui/jquery.ui.core.js"></script>

<script type="text/javascript" src="../../js/ui/jquery.ui.widget.js"></script>

<script type="text/javascript" src="../../js/ui/jquery.ui.datepicker.js"></script>

<script type="text/javascript" src="../../js/ui/jquery.ui.position.js"></script>

<script type="text/javascript" src="../../js/ui/jquery.ui.autocomplete.js"></script>

<script src="../../js/funk.js" type="text/javascript"></script>

  <link href="../../css/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../js/bootstrap.min.js"></script>
    <link href="../../css/font-awesome.min.css" rel="stylesheet" />

      <script type="text/javascript" src="../../js/angular.min.js"></script>

    <script type="text/javascript" src="../../js/AngularLogin.js"></script>

    <script type="text/javascript" src="../../js/smart-table.min.js"></script>
    <link href="../../css/loading-bar.css" rel="stylesheet" />

    <script src="../../js/loading-bar.js"></script>

<script language="javascript" type="text/javascript">
    function doPostResults(eu) {
        postwith('./examiners.aspx', { eu: eu });
    }
    </script>

<script type="text/javascript">
    $(function () {
        $("table tr:nth-child(even)").addClass("striped");
    });
</script>

<script type="text/javascript">
    $(function () {
        $("#datepickerFrom").datepicker();
    });
    $(function () {
        $("#datepickerTo").datepicker();
    });

</script>

<script type="text/javascript">
    $(function () {
        var availableTags = [""];
        $("#kword").autocomplete({
            source: availableTags
        });
    });
</script>

    <script language="javascript" type="text/javascript">
        function doPostResults(eu) {
            postwith('./verify_data.aspx', { eu: eu });
        }

	</script>
<script type="text/javascript">
    $(function () {
        $("table tr:nth-child(even)").addClass("striped");
    });
</script>

<script type="text/javascript">
    $(function () {
        $("#datepickerFrom").datepicker();
    });
    $(function () {
        $("#datepickerTo").datepicker();
    });

</script>

        <style type="text/css">

        .sidebar  {
            width: 100%;
            height:100%;

        }

         .sidebar  a {
            width: 100%;
            line-height:100%;
        }

          .container  {
            width: 100%;
            height:100%;

        }

        .tdcolheader2 {
             line-height:100%;
              height:100%;

              background: url(../images/green_header.gif) top repeat-x;
  text-align: center;
  color: #fff;
  font-weight: bold;
  font-size: 14px;
  border-radius: 10px;
        }

        td {
            height:auto;
        }



       body {
            line-height:100%;
                 }

        .content {
             width: 100%;
           
        }

        .menu { padding:0;
                
                
                width:100%;}

        .tbbg2 {
  padding: 0;
  
  width:100%;
 
  background: url(../images/green_header.gif) top repeat-x;
  background-color: #990033;
  text-align: center;
  color: #fff;
  font-weight: bold;
  border-color: #990033;
}

        input {
            color:black;
        }
        select {
            color:black;
        }
        #searchform {
min-width: 600px;
        }
    </style>
</head>
<body ng-controller="myController13">
    <form id="form1" runat="server">
   <div>
  <div class="container">
        <div class="col-lg-3 col-md-3 col-sm-3 sidebar"> 
        <div >
            <a href="./registrar_unit/pt_profile.aspx">PROFILE</a><br /> <a href="../../cp.aspx?x=<% Response.Write(admin); %>">CHANGE PASSWORD</a> <a href="./registrar_unit/red.aspx">VIEW STATISTICS</a>
        </div>
            </div>
        <div class="col-lg-9 col-md-9 col-sm-9"> 
        <div class="content">
            <table> 
                <tr>
                    <td> 
            <div class="row"> 
            <div class="header">
                <div class="xmenu">
                    <div class="menu">
                        <ul>
                            <li><a href="./lo.aspx">
                                <img alt="" src="../../images/logoff.png" width="16" height="16" />Log off</a></li>
                        </ul>
                    </div>
                </div>
                <div class="xlogo">
                    <div class="xlogo_l">
                    </div>
                    <div class="xlogo_r">
                    </div>
                </div>
            </div>

                </div>
                        </td>
                    </tr>
                <tr> 
           <td>
            <div id="searchform2" class="row">
            <table width="100%"  class=" table form table-responsive">
          <tr >
            <td   class="tbbg2"> &nbsp;  WELCOME TO THE  REGISTRAR'S UNIT</td>
          </tr>
          <tr class="stripedout">
            <td  align="center">
            &nbsp;<asp:Button ID="btnReloadPage" runat="server" class="button" 
                    onclick="btnReloadPage_Click" Text="RELOAD PAGE" />
              </td>
          </tr>
         
         <tr>
            <td  class="tbbg2">&nbsp;PLEASE SEARCH FOR ENTRIES BELOW</td>
          </tr>
          
          <tr class="stripedout">
            <td  align="center" ><%Response.Write(criteria); %></td>
          </tr>
          
          <tr  >
            <td  align="center" >
               

            </td>
          </tr>         
         
          <tr class="stripedout">
            <td align="center">            
                <asp:Button ID="btnSearch" runat="server" Visible="false" Text="SEARCH" class="button" 
                      />
                <br />
               <%-- <strong>Pages <% Response.Write(eu + 1);%> of <%if (pages.Count < 1) { Response.Write("1"); } else { Response.Write(pages.Count); }%> . Total records = <%=nume %> </strong>--%>
              </td>
            </tr>          
         
          <tr >
            <td  align="center"><%--<strong><% foreach (string s in pages) { Response.Write(s + " "); }%></strong>--%></td>
            </tr>
          <tr >
            <td   align="center">&nbsp;</td>
            </tr>
                </table>
                </div>
                </td>
                </tr>
       <%--  <% if (criteria_type == "tm_type")
            { %>
          <% }%>
              
          <% if (criteria_type == "status")
            { %>
         <% }%>--%>
     <%--    <table class="table form table-responsive">
            <tr >
            <td  class="tbbg2">S/N</td>
            <td class="tbbg2">FILE NUMBER</td>
             <td class="tbbg2">OAI NUMBER</td>
            <td  class="tbbg2">PRODUCT TITLE</td>
             <td  class="tbbg2">APPLICANT NAME</td>
            <td  class="tbbg2">DS TYPE</td>
            <td  class="tbbg2">FILING DATE</td>
            <td  class="tbbg2">STATUS</td>
           
            <td  class="tbbg2">VIEW</td>
            <td  class="tbbg2">VIEW NEW TAB</td>
            </tr>
           <%if (lt_mi.Count > 0)
             {
                 int sn = Convert.ToInt32(dis.ToString());
                 for (int i = 0; i < lt_mi.Count; i++)
                 { %> 
        <tr>
            <td align="center">
                <%=sn %>
            </td>
            <td align="center">
                <%=lt_mi[i].reg_number.ToString() %>
            </td>
              <td align="center">
                <%=lt_mi[i].ApplicantId.ToString() %>
            </td>
            <td  align="center">
                <%= lt_mi[i].title_of_invention.ToString() %>
            </td>

            <td  align="center">
                <%= lt_mi[i].ApplicantName.ToString() %>
            </td>
            <td align="center">
                <%= lt_mi[i].xtype.ToString() %>
            </td>
            
            <td align="center">
                <%= lt_mi[i].reg_date.ToString() %>
            </td>
            <td align="center">
                <% if (z.getPtOfficeByMID(lt_mi[i].log_staff) != "") { Response.Write(z.getPtOfficeByMID(lt_mi[i].log_staff)); } else { Response.Write("None"); }%></td>
            
            
            <td align="center">
               <a href="registrar_details.aspx?x=<%= lt_mi[i].xID.ToString() %>"><i class="fa fa-link"></i></a>
            </td>

            <td align="center">
               <a target="_blank" href="registrar_details.aspx?x=<%= lt_mi[i].xID.ToString() %>"><i class="fa fa-external-link"></i></a>
            </td>
        </tr>
        <% sn++; } 
             }%>
                   
          </table>--%>
                <tr> 
                     
                    <td> 
                        <div class="row">
                        <table st-table="displayedCollection" st-safe-src="ListAgent" class="table form table-responsive   table-striped">
        <thead>
            <tr>
                 <th  class="tbbg2">S/N</th>
                <th st-sort="Rdno" class="tbbg2">RD NUMBER</th>
                <th st-sort="reg_number" class="tbbg2">FILE NUMBER</th>
                <th st-sort="ApplicantId" class="tbbg2">OAI NUMBER</th>

                 <th  st-sort="title_of_invention" class="tbbg2">PRODUCT TITLE</th>
             <th st-sort="ApplicantName" class="tbbg2">APPLICANT NAME</th>
            <th st-sort="xtype" class="tbbg2">DS TYPE</th>
            <th st-sort="reg_date" class="tbbg2">FILING DATE</th>
            <th st-sort="Office"  class="tbbg2">STATUS</th>
                 <th  class="tbbg2">View</th>
                <th  class="tbbg2">Open New Tab</th>
                <th class="tbbg2">View Acceptance</th>
                 <th class="tbbg2">View Acknowledgement</th>
                <th class="tbbg2">View Certificate</th>
            </tr>
            <tr>
                <th colspan="14"><input st-search="" class="form-control" placeholder="global search ..." type="text" /></th>
            </tr>
        </thead>
        <tbody>
            <tr ng-repeat="row in displayedCollection">
               
                <td align="center">{{row.Sn}}</td>
                 <td align="center">{{row.Rdno}}</td>
                <td align="center">{{row.reg_number}}</td>
                <td align="center">{{row.ApplicantId}}</td>
                <td align="center">{{row.title_of_invention}}</td>
                 <td align="center">{{row.ApplicantName}}</td>
                  <td align="center">{{row.xtype}}</td>
                 <td align="center">{{row.reg_date}}</td>
                 <td align="center">{{row.Office}}</td>

                <td align="center">
               <a href="registrar_c_details.aspx?x={{row.xID}}"><i class="fa fa-link"></i></a>
            </td>

                 <td align="center">
               
               <a target="_blank" class="icon-bar" href="registrar_c_details.aspx?x={{row.xID}}"> <i class="fa fa-external-link"></i></a>
            </td>

                 <td align="center">
               
                <a target="_blank"  href="Acceptance_Letter.aspx?x={{row.xID}}">ACC</a>
            </td>
                
                  <td align="center">
               
                 <a target="_blank"  href="Design_Akwnolgment.aspx?x={{row.xID}}">ACK</a>
            </td>

                 <td align="center">
               
                <a target="_blank"  href="Design_Certificate.aspx?x={{row.xID}}">CERT</a>
            </td>
                


              
            </tr>
        </tbody>
        <tfoot>
            <tr>
                <td colspan="14" class="text-center">
                    <div st-pagination="" st-items-by-page="itemsByPage" st-displayed-pages="7"></div>
                </td>
            </tr>
        </tfoot>
    </table>
                            </div>
                        </td>
                    </tr>
        
               
                </table>
           
    </div>
            </div>
</div>
</div>
    </form>
</body>
</html>
