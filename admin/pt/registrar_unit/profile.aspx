<%@ Page Language="C#" AutoEventWireup="true" CodeFile="profile.aspx.cs" Inherits="admin_pt_registrar_unit_profile" %>

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
                <a href="../../cp.aspx?x=<% Response.Write(adminID); %>">CHANGE PASSWORD</a> 
                <a href="./profile.aspx">VIEW STATISTICS</a> 
                <a href="../preview_r.aspx?x=1&d=Invalid">INVALID APPS</a> 
                <a href="../preview_r.aspx?x=2&d=Valid">VALID APPS</a> 
                <a href="../preview_r.aspx?x=3&d=Approved">APPROVED APPS</a> 
                <a href="../preview_r.aspx?x=1&d=Disapproved">DISAPPROVED APPS</a> 
                <a href="../preview_r.aspx?x=4&d=Registrable">EXAMINED APPS</a> 
                <a href="../preview_r.aspx?x=5&d=Accepted">ACCEPTED APPS</a> 
                <a href="../preview_r.aspx?x=3&d=Refused">UN-ACCEPTED APPS</a> 
                <a href="../preview_r.aspx?x=6&d=Published">PUBLISHED APPS</a> 
                <a href="../preview_r.aspx?x=7&d=Not Opposed">UNOPPOSED APPS</a> 
                <a href="../preview_r.aspx?x=5&d=Opposed">OPPOSED APPS</a> 
                <a href="../preview_r.aspx?x=8&d=Certified">CERTIFIED APPS</a> 
                <a href="../preview_r.aspx?x=9&d=Registered">REGISTERED APPS</a>
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
        
    <table align="center" width="100%" >
        <tr>
            <td colspan="3" align="left" class="tbbg">
                WELCOME TO THE REGISTRAR UNIT</td>
        </tr>
       
        
                
        <tr>
            <td align="center" colspan="3">&nbsp;</td>
        </tr>
        
        <tr>
            <td style="width: 30%;" align="center">
                <a href="../../../cp.aspx?x=<%Response.Write(adminID);  %>">
                    <img alt="" src="../../../images/xsync.png" style="width: 100px; height: 100px" /></a></td>
            <td style="width: 30%;" align="center">
                <a href="../registrar.aspx">
                    <img alt="" src="../../../images/view.png" style="width: 100px; height: 100px" /></a></td>
            <td style="width: 30%;" align="center">
                <a href="../registrar.aspx"> 
                    <img alt="" src="../../../images/xexec.png" style="width: 100px; height: 100px" /></a></td>
        </tr>
        
        <tr>
            <td style="width: 30%;" align="center">
                <a href="../../../cp.aspx?x=<%Response.Write(adminID);  %>">CHANGE PASSWORD</a></td>
            <td style="width: 30%;" align="center">
                <a href="../registrar.aspx">VIEW APPLICATIONS</a></td>
            <td style="width: 30%;" align="center">
                <a href="../registrar.aspx">CHECK STATISTICS</a></td>
        </tr>
        
        <tr>
            <td align="center" colspan="3" class="tbbg">
                &nbsp;
                &nbsp;
                &nbsp;
            </td>
        </tr>
        
        <tr>
            <td align="center">
                &nbsp;</td>
            <td align="center">
                <a href="../registrar_c.aspx"> 
                    <img alt="" src="../../../images/xexec.png" style="width: 100px; height: 100px" /></a></td>
            <td align="center">
                &nbsp;</td>
        </tr>
        
        <tr>
            <td align="center" colspan="3">
                <a href="../registrar_c.aspx">ISSUE CERTIFICATE</a></td>
        </tr>
        
        <tr>
            <td align="center" colspan="3">
                &nbsp;</td>
        </tr>
        
        <tr>
            <td class="tbbg" colspan="3">
              
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
