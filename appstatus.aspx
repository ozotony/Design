﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="appstatus.aspx.cs" Inherits="appstatus" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<script src="js/jquery.js" type="text/javascript"></script>
<script src="js/funk.js" type="text/javascript"></script>

</head>
<body>
    <form id="form1" runat="server">
    <div>

    <div class="container">
    <div class="sidebar"></div>
       
        <div class="content">
                        
                     <div class="xmenu">
                         <div class="menu">
                             <ul>
                                 <li><a href="login.aspx">
                                     <img alt="" src="./images/logon.png" width="16" height="16" />Login</a></li>
                                
                             </ul>
                         </div>
                     </div>
                 
            <% if(showt==0) {%>
            <table align="center" width="100%">
             <tr>
            <td align="center" colspan="2">
             <img alt="Coat Of Arms" height="79" src="images/coat_of_arms.png" 
                        width="85" /><br />
              FEDERAL REPUBLIC OF NIGERIA<br />
                    FEDERAL MINISTRY OF INDUSTRY, TRADE AND INVESTMENT<br />
                    COMMERCIAL LAW DEPARTMENT<br />
                    TRADEMARKS, PATENTS AND DESIGNS REGISTRY<br />
                    PATENTS AND DESIGNS ACT CAP 344
                      </td>
        </tr>
        <tr>
            <td colspan="2" align="left" class="tbbg">
                &nbsp;PLEASE ENTER YOUR TRANSACTION OR APPLICATION NUMBER TO CHECK YOUR STATUS</td>
        </tr>
       
        
        <tr>
            <td align="right">
                &nbsp;
                REFERENCE /APPLICATION NUMBER: &nbsp;
                  </td>
                
            <td style="width: 50%;">
            <asp:TextBox ID="xref" runat="server" Width="200px" CssClass="textbox"></asp:TextBox>
                </td>
        </tr>
        
        <tr>
            <td class="tbbg" colspan="2">               
            </td>
        </tr>
        <tr>
            <td  colspan="2" align="center">               
                <asp:Button ID="Save" runat="server" Text="Check Status" OnClick="Save_Click" class="button" />               
            </td>
        </tr>

    </table>
            <% }%>
            <% if (showt == 1)
               {%>
               <div id="searchform">
                <table align="center" width="100%" class="form" 
                     id="table1">
                     <tr>
            <td align="center" colspan="2">
             <img alt="Coat Of Arms" height="79" src="images/coat_of_arms.png" 
                        width="85" /><br />
              FEDERAL REPUBLIC OF NIGERIA<br />
                    FEDERAL MINISTRY OF INDUSTRY, TRADE AND INVESTMENT<br />
                    COMMERCIAL LAW DEPARTMENT<br />
                    TRADEMARKS, PATENTS AND DESIGNS REGISTRY<br />
                    PATENTS AND DESIGNS ACT CAP 344
                      </td>
        </tr>                  
                   
                    <tr>
                        <td width="100%" colspan="2" class="tbbg">
                            <strong>---STATUS INFORMATION---</strong>
                        </td>
                    </tr>
                    <tr>
                        <td width="100%" align="justify" colspan="2">
                         Dear 
                            <% Response.Write(lt_rep.xname); %>, 
                            <br /> We will like to inform you that your application ("/OAI/TM/<% Response.Write(lt_pw[0].validationID); %>") is currently at the <strong>  "<% Response.Write(status); %>" Office</strong> and is currently <strong>"<% Response.Write(data_status); %>"</strong><br />
                            Regards,
                        </td>
                    </tr>
                    <tr>
                        <td class="tbbg" colspan="2">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td align="left" style="width:50%">
                            <strong>&nbsp;THE TRADEMARK REGISTRY,<br />
                                &nbsp;COMMERCIAL LAW DEPARTMENT NIGERIA,<br />
                                &nbsp;FEDERAL MINISTRY OF TRADE AND INVESTMENT,<br />
                                &nbsp;FEDERAL CAPITAL TERRITORY,<br />
                                &nbsp;ABUJA,NIGERIA </strong>
                        </td>
                        <td align="right">
                            <strong>REGISTRAR OF TRADEMARKS&nbsp;&nbsp; </strong>
                           
                        </td>
                    </tr>
                    <tr>
                        <td class="tbbg" colspan="2">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                           
                <input type="button" name="Printform" id="Printform" value="Print" onclick="printAssessment(document.getElementById('searchform'));return false" class="button" />

                        <input type="button" name="btnReprint" id="btnReprint" value="Reprint Acknowledgment Slip"  onclick="doView('./tm_ackrep.aspx?0001234445XXX43943OPFDSMZXUHSJFDSKFGKSDKGFSDKFSKFDKFD=<% Response.Write(r); %>&94384238SKFGKSDKGFSDKFSKFDKFD=<% Response.Write(agt); %>');" class="button" />

                        <asp:Button ID="BtnCheckStatus" runat="server" Text="Refresh Search"  
                                CssClass="button" Width="154px" onclick="BtnCheckStatus_Click"/>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2" class="tbbg">
                           
                            &nbsp;</td>
                    </tr>
                </table>
               </div>
            <% }%>
        </div>
     </div>   
    
    
</div>
    </form>
</body>
</html>
