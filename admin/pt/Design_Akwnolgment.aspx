<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Design_Akwnolgment.aspx.cs" Inherits="admin_pt_Design_Akwnolgment" %>

<!DOCTYPE html>
<HTML>
<HEAD>
	<META HTTP-EQUIV="CONTENT-TYPE" CONTENT="text/html; charset=utf-8">
	<TITLE></TITLE>
	<META NAME="GENERATOR" CONTENT="LibreOffice 4.1.6.2 (Linux)">
	<META NAME="AUTHOR" CONTENT="ANITA">
	<META NAME="CREATED" CONTENT="20150225;122000000000000">
	<META NAME="CHANGEDBY" CONTENT="HP">
	<META NAME="CHANGED" CONTENT="20150226;134000000000000">
	<META NAME="AppVersion" CONTENT="14.0000">
	<META NAME="Company" CONTENT="Hewlett-Packard">
	<META NAME="DocSecurity" CONTENT="0">
	<META NAME="HyperlinksChanged" CONTENT="false">
	<META NAME="LinksUpToDate" CONTENT="false">
	<META NAME="ScaleCrop" CONTENT="false">
	<META NAME="ShareDoc" CONTENT="false">
    <script src="../../js/jquery-2.1.1.min.js"></script>
	<STYLE TYPE="text/css">
	<!--
		@page { size: 8.5in 11in; margin: 1in }
		P { margin-bottom: 0.08in; direction: ltr; widows: 2; orphans: 2 }
	-->

     @media print
{    
    .no-print, .no-print *
    {
        display: none !important;
    }
}
	</STYLE>
    <link href="../../css/style.css" rel="stylesheet" />
     <script src="../../js/funk.js" type="text/javascript"></script>
    <script type="text/javascript">
        function PrintContent() {
            //alert("inside")
            //w = window.open();
            //alert($('#cert').html())
            //w.document.write('<div id="cert">' + $('#cert').html() + '</div>');
            //w.print();
            //w.close();
            var el = "cert";
            var restorepage = document.body.innerHTML;
            var printcontent = document.getElementById(el).innerHTML;
           
            document.body.innerHTML = printcontent;
            window.print();
            document.body.innerHTML = restorepage;
        }

    </script>
</HEAD>
<BODY LANG="en-US" DIR="LTR">
<CENTER>
	<TABLE class="form" WIDTH=100% CELLPADDING=1 CELLSPACING=0 id="cert" >
		<%--<COL WIDTH=87*>
		<COL WIDTH=20*>
		<COL WIDTH=14*>
		<COL WIDTH=136*>--%>
		<TR>
			<TD COLSPAN=4 WIDTH=100% STYLE="border: none; padding: 0in">
				<P ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><B>FEDERAL
				MINISTRY OF INDUSTRY, TRADE AND INVESTMENT<BR>COMMERCIAL LAW DEPARTMENT,
				 INDUSTRIAL PROPERTY OFFICE REGISTRY </B></FONT></FONT>
				</P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% BGCOLOR="#006600" STYLE="border: none; padding: 0in">
				<P ALIGN=CENTER><IMG SRC="../../images/coat_arm.png"" NAME="Picture 2" ALIGN=BOTTOM WIDTH=77 HEIGHT=72 BORDER=0></P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% STYLE="border: none; padding: 0in">
				<P ALIGN=CENTER><FONT ><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><B>DESIGNS
				 REGISTRATION ACKNOWLEDGEMENT FORM</B></FONT></FONT></FONT><FONT COLOR="#ff0000"><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt">
				</FONT></FONT></FONT>
				</P>
			</TD>
		</TR>
		<TR>
			<TD WIDTH=34% >
				<P ALIGN=RIGHT>&nbsp;<FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt">FILLING/APPLICATION
				DATE : </FONT></FONT>
				</P>
			</TD>
			<TD COLSPAN=3 WIDTH=66%>
				<P><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><asp:Label ID="Label5" runat="server" Text="Label"><% Response.Write(lt_mi[0].reg_date); %></asp:Label>&nbsp;&nbsp;</FONT></FONT></P>
			</TD>
		</TR>
		<TR>
			<TD WIDTH=34% >
				<P ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt">REGISTRATION
				NUMBER : </FONT></FONT>
				</P>
			</TD>
			<TD COLSPAN=3 WIDTH=66%>
				<P ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt">ONLINE
				APPLICATION ID :</FONT></FONT></P>
			</TD>
		</TR>
		<TR>
			<TD WIDTH=34% >
				<P ALIGN=CENTER><A NAME="_GoBack"></A><FONT ><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"> <asp:Label ID="Label6" runat="server" Text="Label"><% Response.Write(lt_mi[0].reg_number); %></asp:Label></FONT></FONT></FONT></P>
			</TD>
			<TD COLSPAN=3 WIDTH=66% >
				<P ALIGN=CENTER><FONT ><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><asp:Label ID="Label7" runat="server" Text="Label"><% Response.Write("OAI/DS/"+t.ValidationIDByPwalletID(lt_mi[0].log_staff) ); %></asp:Label></FONT></FONT></FONT></P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% BGCOLOR="#1c5e55" >
				<P ALIGN=CENTER><FONT COLOR="#ffffff"><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><B>---
				APPLICANT INFORMATION ---</B></FONT></FONT></FONT></P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% >
				<P ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt">APPLICANT
				NAME:</FONT></FONT></P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% >
				<P ALIGN=CENTER><FONT ><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><% Response.Write(lt_app[0].xname); %></FONT></FONT></FONT></P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% >
				<P ALIGN=CENTER>&nbsp;</P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% >
				<P ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt">ADDRESS
				:</FONT></FONT></P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% >
				<P ALIGN=CENTER><FONT ><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><% Response.Write(lt_app[0].address); %></FONT></FONT></FONT></P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% >
				<P ALIGN=CENTER>&nbsp;</P>
			</TD>
		</TR>
		<TR>
			<TD WIDTH=34% >
				<P ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt">PHONE
				NUMBER : </FONT></FONT>
				</P>
			</TD>
			<TD COLSPAN=3 WIDTH=66% >
				<P ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt">E-MAILS
				: </FONT></FONT>
				</P>
			</TD>
		</TR>
		<TR>
			<TD WIDTH=34% >
				<P ALIGN=CENTER><FONT ><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><% Response.Write(lt_app[0].xmobile); %></FONT></FONT></FONT></P>
			</TD>
			<TD COLSPAN=3 WIDTH=66% >
				<P ALIGN=CENTER><FONT ><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><% Response.Write(lt_app[0].xemail); %></FONT></FONT></FONT></P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% >
				<P>&nbsp;</P>
			</TD>
		</TR>

           <%if(lt_xpri.Count>0){%>
       

        <TR>
			<TD COLSPAN=4 WIDTH=100% BGCOLOR="#1c5e55" >
				<P ALIGN=CENTER><FONT COLOR="#ffffff"><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><B>---
				PRIORITY INFORMATION --- </B></FONT></FONT></FONT>
				</P>
			</TD>
		</TR>
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


		<TR>
			<TD COLSPAN=4 WIDTH=100% BGCOLOR="#1c5e55" >
				<P ALIGN=CENTER><FONT COLOR="#ffffff"><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><B>---
				DESIGNS INFORMATION --- </B></FONT></FONT></FONT>
				</P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% >
				<P>&nbsp;</P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% >
				<P ALIGN=CENTER>&nbsp;&nbsp;<FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt">DESIGN
				:</FONT></FONT></P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% >
				<P ALIGN=CENTER><FONT ><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><asp:Label ID="Label9" runat="server" Text="Label"><% Response.Write(lt_mi[0].title_of_invention); %></asp:Label></FONT></FONT></FONT></P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% >
				<P ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><B>DESIGN
				TYPE</B></FONT></FONT></P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% >

				<P ALIGN=CENTER><asp:Label ID="Label8" runat="server" Text="Label"><% Response.Write(lt_mi[0].xtype); %></asp:Label><BR>
				</P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% >
				<P>&nbsp;</P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% BGCOLOR="#1c5e55" >
				<P ALIGN=CENTER><FONT COLOR="#ffffff"><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><B>---
				DESIGN REPRESENTATION --- </B></FONT></FONT></FONT>
				</P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% >
				<P>&nbsp;</P>
			</TD>
		</TR>
		 <tr>
            <td align="right">
                REPRESENTATION OF DESIGN 1 :</td>
            <td >
                 <% if ((lt_mi[0].rep_pic != "")&&(lt_mi[0].rep_pic != "0"))
               {
                   Response.Write("<a href=" + lt_mi[0].rep_pic + " target='_blank'><img src=\"" + lt_mi[0].rep_pic + "\" height=\"200px\" width=\"200px\" /></a>");        
         }  else { Response.Write("NONE"); 
               } %></td>
        </tr>        
        <tr>
            <td align="right">
                REPRESENTATION OF DESIGN 2:</td>
            <td >
                    <% if ((lt_mi[0].rep2_pic != "") && (lt_mi[0].rep2_pic != "0"))
               {
                   Response.Write("<a href=" + lt_mi[0].rep2_pic + " target='_blank'><img src=\"" + lt_mi[0].rep2_pic + "\" height=\"200px\" width=\"200px\" /></a>");        
         }  else { Response.Write("NONE"); 
               } %></td>
        </tr>
        <tr>
            <td align="right">
              REPRESENTATION OF DESIGN 3 :
            </td>
            <td >
            <% if ((lt_mi[0].rep3_pic != "") && (lt_mi[0].rep3_pic != "0"))
               {
                   Response.Write("<a href=" + lt_mi[0].rep3_pic + " target='_blank'><img src=\"" + lt_mi[0].rep4_pic + "\" height=\"200px\" width=\"200px\" /></a>");        
         }  else { Response.Write("NONE"); 
               } %></td>
        </tr>        
        <tr>
            <td align="right">
                REPRESENTATION OF DESIGN 4 :</td>
            <td >
                 <% if ((lt_mi[0].rep4_pic != "") && (lt_mi[0].rep4_pic != "0"))
               {
                        Response.Write("<a href=" + lt_mi[0].rep4_pic + " target='_blank'> <img src=\""+ lt_mi[0].rep3_pic + "\" height=\"200px\" width=\"200px\" /></a>");        
         }  else { Response.Write("NONE"); 
               } %></td>
        </tr>
		<TR>
			<TD COLSPAN=4 WIDTH=100% >
				<P>&nbsp;</P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% BGCOLOR="#1c5e55" >
				<P ALIGN=CENTER><FONT COLOR="#ffffff"><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><B>---
				ACCREDITED AGENT ACCESS INFORMATION --- </B></FONT></FONT></FONT>
				</P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% >
				<P>&nbsp;</P>
			</TD>
		</TR>
		<TR>
			<TD WIDTH=34% >
				<P ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt">AGENT
				CODE : </FONT></FONT>
				</P>
			</TD>
			<TD COLSPAN=3 WIDTH=66% >
				<P ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt">NAME
				: </FONT></FONT>
				</P>
			</TD>
		</TR>
		<TR>
			<TD WIDTH=34% >
				<P ALIGN=CENTER><FONT ><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><% Response.Write(lt_rep[0].agent_code); %> </FONT></FONT></FONT></P>
			</TD>
			<TD COLSPAN=3 WIDTH=66% >
				<P ALIGN=CENTER><FONT ><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><% Response.Write(lt_rep[0].xname); %></FONT></FONT></FONT></P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% BGCOLOR="#1c5e55" >
				<P ALIGN=CENTER><FONT >&nbsp;<FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><B>ADDRESS
				: </B></FONT></FONT></FONT>
				</P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% >
				<P>                                                              
				       &nbsp;<FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><asp:Label ID="Label11" runat="server" Text="Label"><% Response.Write(lt_rep[0].address); %></asp:Label></FONT></FONT></P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% >
				<P><BR>
				</P>
			</TD>
		</TR>
		<TR>
			<TD WIDTH=34% >
				<P ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt">PHONE
				NUMBER : </FONT></FONT>
				</P>
			</TD>
			<TD COLSPAN=3 WIDTH=66% >
				<P ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt">E-MAIL
				: </FONT></FONT>
				</P>
			</TD>
		</TR>
		<TR>
			<TD WIDTH=34% >
				<P ALIGN=CENTER><FONT ><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><% Response.Write(lt_rep[0].xmobile); %></FONT></FONT></FONT></P>
			</TD>
			<TD COLSPAN=3 WIDTH=66% >
				<P ALIGN=CENTER><FONT ><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><% Response.Write(lt_rep[0].xemail); %></FONT></FONT></FONT></P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% BGCOLOR="#1c5e55" >
				<P ALIGN=CENTER><FONT COLOR="#ffffff"><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><B>---
				PAYMENT INFORMATION --- </B></FONT></FONT></FONT>
				</P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% >
				<P>&nbsp;</P>
			</TD>
		</TR>
		<TR>
			<TD WIDTH=34% >
				<P ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt">TRANSACTION
				ID : </FONT></FONT>
				</P>
			</TD>
			<TD COLSPAN=3 WIDTH=66% >
				<P ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt">TRANSACTION
				AMOUNT : </FONT></FONT>
				</P>
			</TD>
		</TR>
		<TR>
			<TD WIDTH=34% >
				<P ALIGN=CENTER><FONT ><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><% Response.Write(lt_stage[0].validationID); %></FONT></FONT></FONT></P>
			</TD>
			<TD COLSPAN=3 WIDTH=66% >
				<P ALIGN=CENTER><FONT ><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><% Response.Write(lt_stage[0].amt); %>  NGN</FONT></FONT></FONT></P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% BGCOLOR="#1c5e55">
				<P ALIGN=CENTER><FONT COLOR="#ffffff">&nbsp;</FONT></P>
			</TD>
		</TR>
		<TR>
			<TD COLSPAN=4 WIDTH=100% >
				<P ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><BR></FONT></FONT><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><B>Your
				application has been received and is receiving due
				attention</B></FONT></FONT><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><BR></FONT></FONT><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><B>REGISTRAR
				(COMMERCIAL LAW DEPARTMENT NIGERIA)</B></FONT></FONT><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt">
				</FONT></FONT>
				</P>
			</TD>
		</TR>
	<tr>

       <td>
 
            

       </td>


	</tr>
	</TABLE>
     <input type="button" name="Printform" id="Printform"  class='no-print' value="Print" onclick="printAll(); return false" class="button" />  
    
</CENTER>
<P STYLE="margin-bottom: 0.14in; line-height: 100%"><BR><BR>
</P>
</BODY>
</HTML>
