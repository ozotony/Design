<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tm_ackrep.aspx.cs" Inherits="tm_ackrep" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ACKNOWLEDGEMENT SLIP</title>
    <script language="javascript" type="text/javascript">
        // <![CDATA[
        function IpoDashboard_onclick() {
            window.location.href = "http://www.iponigeria.com/userarea/dashboard";
        }

        // ]]>
</script>

<link href="css/print_style.css" rel="stylesheet" type="text/css" />

<script src="js/jquery.js" type="text/javascript"></script>

<script src="js/funk.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       
            <table align="left" width="1000px" style="float:left;">
            <tr >
                <td >
            <div id="searchform">

    <table align="center" width="1000px" class="form" >    
        <tr>
            <td colspan="2" align="center" >
             <img alt="Coat Of Arms" height="79" src="images/coat_of_arms.png" 
                        width="85" /><br />
              FEDERAL REPUBLIC OF NIGERIA<br />
                    FEDERAL MINISTRY OF INDUSTRY, TRADE AND INVESTMENT<br />
                    COMMERCIAL LAW DEPARTMENT<br />
                    TRADEMARKS, PATENTS AND DESIGNS  REGISTRY<br />
                    PATENTS AND DESIGNS ACT CAP 344 <br />
                   <div style="font-size:20px;"><strong>ACKNOWLEDGMENT FORM</strong></div> 
            </td>
        </tr>       
        
        <%if (lt_mi.Count > 0)
          { %>
        <tr>
            <td width="100%" align="right" colspan="2" class="sub_header">
                </td>
        </tr>
        
        <tr>
            <td width="50%" align="right">
                &nbsp;FILLING/APPLICATION DATE :             </td>
            <td>
               
                <asp:Label ID="Label1" runat="server" Text="Label"><% Response.Write(lt_mi[0].reg_date); %></asp:Label>&nbsp;</td>
        </tr>
        
        <tr>
            <td align="right">
                REGISTRATION NUMBER :
            </td>
                <td>
                  <asp:Label ID="Label2" runat="server" Text="Label"><% Response.Write(lt_mi[0].reg_number); %></asp:Label>
                    </td>
        </tr>
         <tr>
            <td align="right"> 
                                &nbsp;
                                ONLINE APPLICATION ID : </td>
            <td>
                 
                <asp:Label ID="Label6" runat="server" Text="Label"><% Response.Write("OAI/DS/"+t.ValidationIDByPwalletID(lt_mi[0].log_staff) ); %></asp:Label></td>
        </tr>
         <tr>
            <td colspan="2" class="tbbg">
                --- 
                DESIGN INFORMATION --- </td>
        </tr>
        
        <tr>
            <td align="right">
                &nbsp;DESIGN TYPE :</td>
                <td>
                 
                  <asp:Label ID="Label3" runat="server" Text="Label"><% Response.Write(lt_mi[0].xtype); %></asp:Label></td>
        </tr>
        <tr>
            <td align="right">
                &nbsp;TITLE OF DESIGN :
            </td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Label"><% Response.Write(lt_mi[0].title_of_invention); %></asp:Label></td>
        </tr>
        <tr>
            <td align="right">
                TRANSACTION ID :
                </td>
            <td>
                <% Response.Write(lt_stage[0].validationID); %></td>
        </tr>
        
        <tr>
            <td align="right">
                TRANSACTION AMOUNT :
                </td>
            <td>
                <% Response.Write(lt_stage[0].amt); %>  NGN
                </td>
        </tr>  
        <%}%>      
       <%if (lt_app.Count > 0)
         {
            %>
        <tr>
            <td class="tbbg" colspan="2">
                --- APPLICANT INFORMATION ---</td>
        </tr>
         <%             for (int app = 0; app < lt_app.Count; app++)
             {%>
        <tr>
            <td align="left" colspan="2" style="background-color:#999999;">
                <strong>APPLICANT <%=app + 1%>>></strong></td>
        </tr>
        
        <tr>
            <td align="right">
                NAME :</td>
                <td>
                    <% Response.Write(lt_app[app].xname); %></td>
        </tr>
        
        <tr>
            <td align="right">
                ADDRESS :</td>
                <td>
                    <% Response.Write(lt_app[app].address); %></td>
        </tr>
        
        <tr>
            <td align="right">
                PHONE NUMBER :
            </td>
                <td>
                    <% Response.Write(lt_app[app].xmobile); %></td>
        </tr>
        
        <tr>
            <td align="right">
                E-MAILS :</td>
                <td>
                    <% Response.Write(lt_app[app].xemail); %></td>
        </tr>
        
       
         <%
             }
         }%>
         <%if (lt_inv.Count > 0)
           {
              %>
        <tr>
            <td class="tbbg" colspan="2">
                --- TRUE CREATOR INFORMATION ---</td>
        </tr>
        <%   for (int inv = 0; inv < lt_inv.Count; inv++)
               {%>
        <tr>
            <td align="left" colspan="2" style="background-color:#999999;">
                <strong>CREATOR <%=inv+1%>>></strong></td>
        </tr>
        
        <tr>
            <td align="right">
                NAME :</td>
                <td>
                    <% Response.Write(lt_inv[inv].xname); %></td>
        </tr>
        
        <tr>
            <td align="right">
                ADDRESS :</td>
                <td>
                    <% Response.Write(lt_inv[inv].address); %></td>
        </tr>
        
        <tr>
            <td align="right">
                PHONE NUMBER :
            </td>
                <td>
                    <% Response.Write(lt_inv[inv].xmobile); %></td>
        </tr>
        
        <tr>
            <td align="right">
                E-MAILS :</td>
                <td>
                    <% Response.Write(lt_inv[inv].xemail); %></td>
        </tr>
        <%
               }
           }%>
        <%if(lt_assinfo.Count>0){ %>
        <tr>
            <td class="tbbg" colspan="2">
                --- ASSIGNMENT INFORMATION ---</td>
        </tr>
        
        <tr>
            <td align="left" colspan="2" style="background-color:#999999;">
                <strong>ASSIGNEE >></strong></td>
        </tr>
        
        <tr>
            <td align="right">
                NAME :</td>
                <td>
                    <% Response.Write(lt_assinfo[0].assignee_name); %></td>
        </tr>
        
        <tr>
            <td align="right">
                ADDRESS :</td>
                <td>
                    <% Response.Write(lt_assinfo[0].assignee_address); %></td>
        </tr>
        
       <tr>
            <td align="left" colspan="2" style="background-color:#999999;">
                <strong>ASSIGNOR >></strong></td>
        </tr>
        
        <tr>
            <td align="right">
                NAME :</td>
                <td>
                    <% Response.Write(lt_assinfo[0].assignor_name); %></td>
        </tr>
        
       
       
        <tr>
            <td align="right">
                ADDRESS&nbsp; :</td>
                <td>
                     <% Response.Write(lt_assinfo[0].assignor_address); %></td>
        </tr>
        <%} %>
        <%if(lt_xpri.Count>0){%>
        <tr>
            <td colspan="2" class="tbbg">
                --- PRIORITY INFORMATION ---</td>
        </tr>
        <tr>
            <td colspan="2" style="border:0px outset silver; padding: 0px;">
                <table width="100%">
                <tr style="background-color:#999999;">
                <td style="width:10%;">
                    <strong>S/N</strong></td>
                <td style="width:30%;">
                    <strong>COUNTRY</strong></td>
                <td style="width:30%;">
                    <strong>APPLICATION NUMBER</strong></td>
                <td style="width:30%;">
                    <strong>DATE</strong></td>
                </tr>

                 <%
                     for (int pri = 0; pri <lt_xpri.Count; pri++)
              {%>
                <tr >
                <td>
                <%=pri + 1%>
                </td>
                <td>
                    <% Response.Write(t.getCountryName(lt_xpri[pri].countryID)); %></td>
                <td>
                    <% Response.Write(lt_xpri[pri].app_no); %></td>
                <td>
                    <% Response.Write(lt_xpri[pri].xdate); %></td>
                </tr>
                 <%
              }
          %>
                </table></td>
        </tr>
        <%
          }%>
        <%if (lt_rep.Count > 0)
          { %>
        <tr>
            <td colspan="2" class="tbbg">
                --- ADDRESS OF SERVICE IN NIGERIA ---
            </td>
        </tr>
        <tr>
            <td align="right">
                                ATTORNEY CODE :
                </td>
            <td>
                 <asp:Label ID="Label9" runat="server" Text="Label"><% Response.Write(lt_rep[0].agent_code); %></asp:Label>
                     </td>
        </tr>        
        
        
        <tr>
            <td align="right">
                                ATTORNEY NAME :</td>
            <td>
                <% Response.Write(lt_rep[0].xname); %></td>
        </tr>
        
        
        <tr>
            <td align="right">
                NATIONALITY :</td>
            <td>
                <% Response.Write(t.getCountryName(lt_rep[0].nationality)); %></td>
        </tr>
        
        
        <tr>
            <td align="right">
                COUNTRY :</td>
            <td>
               <% Response.Write(t.getCountryName(lt_rep[0].country)); %></td>
        </tr>
        
        
        <tr>
            <td align="right">
                STATE :</td>
            <td>
               <% Response.Write(t.getStateName(lt_rep[0].state)); %></td>
        </tr>
        
        
        <tr>
            <td align="right">
                &nbsp;ADDRESS :
                </td>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Label"><% Response.Write(lt_rep[0].address); %></asp:Label></td>
        </tr>
        
        
        <tr>
            <td align="right">
                PHONE NUMBER : </td>
            <td>
                <% Response.Write(lt_rep[0].xmobile); %></td>
        </tr>
        
        
        <tr>
            <td align="right">
                E-MAIL : </td>
            <td>
                <% Response.Write(lt_rep[0].xemail); %></td>
        </tr>
        <tr>
            <td colspan="2" class="tbbg">
                --- DOCUMENTS ATTACHED ---
            </td>
        </tr>
        <tr>
            <td align="right">
               LETTER OF AUTHORIZATION OF AGENT(FORM 2) :
            </td>
            <td >
            <%if (lt_mi[0].loa_doc == "")
              { %> NOT ATTACHED<%}
              else
              { %> ATTACHED<%} %></td>
        </tr>        
        <tr>
            <td align="right">
                NOVELTY STATEMENT :</td>
            <td >
                <%if (lt_mi[0].ns_doc == "")
                  { %> NOT ATTACHED<%}
                  else
                  { %> ATTACHED<%} %></td>
        </tr>        
        <tr>
            <td align="right">
                NOVELTY STATEMENT :</td>
            <td >
                  <%if (lt_mi[0].ns_doc == "")
                    { %> NOT ATTACHED<%}
                    else
                    { %> ATTACHED<%} %></td>
        </tr>
        <tr>
            <td align="right">
               PRIORITY DOCUMENT :
            </td>
            <td >
            <%if (lt_mi[0].pd_doc == "")
              { %> NOT ATTACHED<%}
              else
              { %> ATTACHED<%} %></td>
        </tr>        
        <tr>
            <td align="right">
                REPRESENTATION OF DESIGN 1 :</td>
            <td >
                <%if ((lt_mi[0].rep_pic == "") && (lt_mi[0].rep_pic == "0"))
                  { %> NOT ATTACHED<%}
                  else
                  { %> <img src="<%=lt_mi[0].rep_pic  %>" height="50%" width="50%" alt="" /><%} %></td>
        </tr>        
        <tr>
            <td align="right">
                REPRESENTATION OF DESIGN 2 :</td>
            <td >
                  <%if ((lt_mi[0].rep2_pic == "") && (lt_mi[0].rep2_pic == "0"))
                    { %> NOT ATTACHED<%}
                    else
                    { %> <img src="<%=lt_mi[0].rep2_pic  %>" height="50%" width="50%" alt="" /><%} %></td>
        </tr>
        <tr>
            <td align="right">
               REPRESENTATION OF DESIGN 3 :
            </td>
            <td >
            <%if ((lt_mi[0].rep3_pic == "") && (lt_mi[0].rep3_pic == "0"))
              { %> NOT ATTACHED<%}
              else
              { %> <img src="<%=lt_mi[0].rep3_pic  %>" height="50%" width="50%" alt="" /><%} %></td>
        </tr>
        <tr>
            <td align="right">
                REPRESENTATION OF DESIGN 4:</td>
            <td >
                  <%if ((lt_mi[0].rep4_pic == "") && (lt_mi[0].rep4_pic == "0"))
                    { %> NOT ATTACHED<%}
                    else
                    { %> <img src="<%=lt_mi[0].rep4_pic  %>" height="50%" width="50%" alt="" /><%} %></td>
        </tr>
        
        <%}%>
        <tr>
            <td class="tbbg" colspan="2" style="color: #fff; background-color: #006600; text-align: center; font-weight: bold;">
              
                &nbsp;</td>
        </tr>
        <tr>
            <td  align="center" colspan="2">
              
             <strong>YOUR APPLICATION HAS BEEN ACCEPTED AND WAITING CERTIFICATE PROCESSING</strong><br />
             <strong>REGISTRAR 
                <br />
                COMMERCIAL LAW DEPARTMENT NIGERIA</strong></td>
        </tr>
        
         
    </table>
        </div>
        </td>
        </tr>
        </table>
       <br /> 
<div style="float:left;width:100%;">    
                <input type="button" name="Printform" id="Printform" value="Print" onclick="printAll(); return false" class="button" />
                <input type="button" name="IpoDashboard" id="IpoDashboard" value="Back to Dashboard" class="button" onclick="return IpoDashboard_onclick()" />
        </div>
</div>
    </form>
</body>
</html>

