﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="profile.aspx.cs" Inherits="admin_pt_verification_unit_profile" %>
<%@ Register Src="~/User_Control/Message.ascx" TagName="Message" TagPrefix="uc" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title></title>
<link href="../../../css/style.css" rel="stylesheet" type="text/css" />   
    <link href="../../../css/bootstrap.min.css" rel="stylesheet" /> 
   
    <script type="text/javascript" src="../../../App_Themes/Default/js/jquery-1.9.1.min.js"></script> 
    <script type="text/javascript" src="../../../App_Themes/Default/js/jquery.ui.effect.js"></script>

    <link href="../../../App_Themes/Default/css/layout.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        
    <div>
        <div class="header">
            <div class="leftholder">
            </div>
            <div class="xmenu">
                <div class="xmenu_m">
                    <div class="xmenu_ml">
                    </div>
                    <div class="xmenu_mm">
                        <div class="menu">
                            <ul>
                                <li><a href="../lo.aspx">
                                    <img alt="" src="../../../images/logoff.png" width="16" height="16" />Log off</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class="xmenu_mr">
                    </div>
                </div>
            </div>
            <div class="xlogoleftholder">
            </div>
            <div class="xlogo">
                <div class="xlogo_l">
                </div>
                <div class="xlogo_r">
                </div>
            </div>
        </div>
        <div class="container">
            <div class="sidebar">
               
            </div>
            <div class="content">
        
    <table align="center" width="100%" >
        <tr>
            <td colspan="3" align="left" class="tbbg">
                 
                WELCOME TO THE VERIFICATION UNIT</td>
        </tr>
       
        
                
        <tr>
            <td align="center" colspan="3">&nbsp;</td>
        </tr>
        
        <tr>
            <td style="width: 30%;" align="center">
                <a href="../../../cp.aspx?x=<%Response.Write(adminID);  %>">
                    <img alt="" src="../../../images/xsync.png" style="width: 100px; height: 100px" /></a></td>
            <td style="width: 30%;" align="center">
                <a href="../verify_data.aspx">
                    <img alt="" src="../../../images/view.png" style="width: 100px; height: 100px" /></a>
                    <br /><p><span class="badge alert-info"> <%Response.Write(lt_mi);%> </span></p></td>
            <td style="width: 30%;" align="center">
                <a href="./ved.aspx"> 
                    <img alt="" src="../../../images/xexec.png" style="width: 100px; height: 100px" /></a></td>
        </tr>
        
        <tr>
            <td style="width: 30%;" align="center">
                <a href="../../../cp.aspx?x=<%Response.Write(adminID); %>">CHANGE PASSWORD</a></td>
            <td style="width: 30%;" align="center">
                <a href="../verify_data.aspx">NEW APPLICATIONS</a></td>
            <td style="width: 30%;" align="center">
                <a href="./ved.aspx">CHECK STATISTICS</a></td>
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
                <a href="../../../cp.aspx?x=<%Response.Write(adminID);  %>">
                    <img alt="" src="../../../images/xsync.png" style="width: 100px; height: 100px" /></a>
                <br />
                <p><span class="badge alert-info"> <%Response.Write(lt_mi2);%> </span></p>
               
            </td>
            <td style="width: 30%;" align="center">
                <a href="../verify_data3.aspx">
                    <img alt="" src="../../../images/view.png" style="width: 100px; height: 100px" /></a>
                    <br />
                <p><span class="badge alert-info"> <%Response.Write(lt_mi3);%> </span></p>
               </td>
            <td style="width: 30%;" align="center">
                </td>
        </tr>
        
        <tr>
            <td style="width: 30%;" align="center">
                <a href="../verify_data2.aspx">INVALID APPLICATIONS</a></td>
            <td style="width: 30%;" align="center">
                <a href="../verify_data3.aspx">KIV APPLICATIONS</a></td>
            <td style="width: 30%;" align="center">
                
               </td>
        </tr>
    </table>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
