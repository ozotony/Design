<%@ Page Language="C#" AutoEventWireup="true" CodeFile="profile.aspx.cs" Inherits="admin_pt_x_unit_profile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title></title>
<link href="../../../css/style.css" rel="stylesheet" type="text/css" />    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="container">
            <div class="sidebar">                 
                <a href="./profile.aspx">PROFILE</a> 
                <a href="../../../cp.aspx?x=<% Response.Write(adminID); %>">CHANGE PASSWORD</a> 
                <a href="./profile.aspx">VIEW STATISTICS</a>                 
            </div>
            <div class="content">
                <div class="header">
                    <div class="xmenu">
                        <div class="menu">
                            <ul>
                                <li><a href="../lo.aspx">
                                    <img alt="" src="../../../images/logoff.png" width="16" height="16" />Log off</a></li>
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
                <div id="searchform">
        
    <table align="center" width="100%">
        <tr>
            <td colspan="3" align="left" class="tbbg">
                WELCOME TO THE ADMINSTRATION UNIT</td>
        </tr>
       
        
                
        <tr>
            <td align="center" colspan="3">&nbsp;</td>
        </tr>
        
        <tr>
            <td style="width: 30%;" align="center">
                <a href="../../../cp.aspx?x=<%Response.Write(adminID);  %>">
                    <img alt="" src="../../../images/xsync.png" style="width: 100px; height: 100px" /></a></td>
            <td style="width: 30%;" align="center">
                <a href="./admin_registration.aspx">
                    <img alt="" src="../../../images/view.png" style="width: 100px; height: 100px" /></a></td>
            <td style="width: 30%;" align="center">
                <a href="./admin_registration.aspx"> 
                    <img alt="" src="../../../images/xexec.png" style="width: 100px; height: 100px" /></a></td>
        </tr>
        
        <tr>
            <td style="width: 30%;" align="center">
                <a href="../../../cp.aspx?x=<%Response.Write(adminID); %>">CHANGE PASSWORD</a></td>
            <td style="width: 30%;" align="center">
                <a href="./admin_registration.aspx">MANAGE ADMINISTRATORS</a></td>
            <td style="width: 30%;" align="center">
                <a href="./admin_registration.aspx">CHECK STATISTICS</a></td>
        </tr>
        
        <tr>
            <td align="center" colspan="3">
                &nbsp;
                &nbsp;
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="tbbg" colspan="3">
              
            </td>
        </tr>

           
        <tr>
            <td style="width: 30%;" align="center">
                <a href="EditApplication.aspx">
                    <img alt="" src="../../../images/xsync.png" style="width: 100px; height: 100px" /></a></td>

            <td style="width: 30%;" align="center">
<a href="EditApplication2.html">
                    <img alt="" src="../../../images/xsync.png" style="width: 100px; height: 100px" /></a>
            </td>
             
             <td style="width: 30%;" align="center">
                 <a href="edit_status.aspx">
                    <img alt="" src="../../../images/xsync.png" style="width: 100px; height: 100px" /></a>
            </td>
           
        </tr>
        
        <tr>
            <td style="width: 30%;" align="center">
                <a href="EditApplication.aspx">EDIT APPLICATION</a></td>
            
             <td style="width: 30%;" align="center">
 <a href="EditApplication2.html">APPLICATION STATUS</a>
            </td>
            
             <td style="width: 30%;" align="center">
     <a href="edit_status.aspx">EDIT STATUS</a>
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
