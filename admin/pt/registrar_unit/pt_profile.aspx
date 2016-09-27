﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pt_profile.aspx.cs" Inherits="admin_pt_registrar_unit_pt_profile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title></title>
<link href="../../../css/style.css" rel="stylesheet" type="text/css" />    
  <link href="../../../css/bootstrap.min.css" rel="stylesheet" />   

    <style type="text/css">
        .sidebar a {
  float: left;
  padding-left: 2px;
  display: block;
  width: 150px;
 
}

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       

        <div class="container">
            <div class="sidebar"> 
                <a href="./profile_index.aspx">MAIN PROFILE</a>
                <a href="pt_profile.aspx">PROFILE</a>  
                <a href="../../../cp.aspx?x=<% Response.Write(adminID); %>">CHANGE PASSWORD</a> 
                <a href="./red.aspx">VIEW STATISTICS</a> 
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
                WELCOME TO THE REGISTRAR'S UNIT</td>
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
                    <img alt="" src="../../../images/view.png" style="width: 100px; height: 100px" /></a>
                      <br /><span class="badge alert-info"> <%Response.Write(lt_mi.Count);%> </span></td>
            <td style="width: 30%;" align="center">
                <a href="./red.aspx"> 
                    <img alt="" src="../../../images/xexec.png" style="width: 100px; height: 100px" /></a></td>
        </tr>
        
        <tr>
            <td style="width: 30%;" align="center">
                <a href="../../../cp.aspx?x=<%Response.Write(adminID);  %>">CHANGE PASSWORD</a></td>
            <td style="width: 30%;" align="center">
                <a href="../registrar.aspx"> NEW APPLICATIONS</a></td>
            <td style="width: 30%;" align="center">
                <a href="./red.aspx">CHECK STATISTICS</a></td>
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
                <a href="../registrar_r.aspx"> 
                    <img alt="" src="../../../images/xexec.png" style="width: 100px; height: 100px" /></a>
                    <br /><span class="badge alert-info"> <%Response.Write(lt_mi_r.Count);%> </span> </td>
            <td align="center">
                </td>
            <td align="center">
                <a href="../registrar_c.aspx"> 
                    <img alt="" src="../../../images/xexec.png" style="width: 100px; height: 100px" /></a>
                    &nbsp;<br /><span class="badge alert-info"> <%Response.Write(lt_mi_c.Count);%> </span></td>
        </tr>
        
        <tr>
            <td align="center">
                <a href="../registrar_r.aspx"> DEFERRED APPLICATIONS</a></td>
            <td align="center">
                &nbsp;</td>
            <td align="center">
                <a href="../registrar_c.aspx">REGISTERED APPLICATIONS</a></td>
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
