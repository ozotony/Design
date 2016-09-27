<%@ Page Language="C#" AutoEventWireup="true" CodeFile="s_data_details_report.aspx.cs" Inherits="admin_pt_s_data_details_report" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" type="text/css" href="../../css/style.css" />

<link rel="stylesheet" href="../../css/jquery.ui.all.css" />

<script type="text/javascript" src="../../js/jquery.js"></script>

<script type="text/javascript" src="../../js/ui/jquery.cookie.js"></script>

<script type="text/javascript" src="../../js/ui/jquery.ui.core.js"></script>

<script type="text/javascript" src="../../js/ui/jquery.ui.widget.js"></script>

<script type="text/javascript" src="../../js/ui/jquery.ui.datepicker.js"></script>

<script type="text/javascript" src="../../js/ui/jquery.ui.position.js"></script>

<script type="text/javascript" src="../../js/ui/jquery.ui.autocomplete.js"></script>

<script src="../../js/funk.js" type="text/javascript"></script>
    <STYLE TYPE="text/css">
	<!--
		@page { size: 8.5in 11in; margin: 1in }
		P { margin-bottom: 0.08in; direction: ltr; line-height: 115%; widows: 2; orphans: 2 }
		P.western { font-family: "Calibri", serif }
		P.cjk { font-family: "Calibri" }
		P.ctl { font-family: "Times New Roman" }
	-->
       @media print
{    
    .no-print, .no-print *
    {
        display: none !important;
    }
}

       body {
  margin: 0;
  padding: 0;
  width: 100%;
  font-family: Trebuchet MS;
  font-size: 10pt;
}
	</STYLE>
</head>
<body>
   
    <form id="form1" runat="server">
   <P "" STYLE="margin-bottom: 0.14in"><TABLE DIR="LTR" ALIGN="center" class="form" WIDTH=598 CELLPADDING=1 CELLSPACING=0>
	<COL WIDTH=122>
	<COL WIDTH=135>
	<COL WIDTH=134>
	<COL WIDTH=197>
	<TR>
		<TD COLSPAN=4  WIDTH=594 HEIGHT=33 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT COLOR="#000000"><FONT FACE="Times New Roman, serif"><FONT SIZE=2 STYLE="font-size: 9pt"><B>FEDERAL
			MINISTRY OF INDUSTRY, TRADE AND INVESTMENT<BR>COMMERCIAL LAW
			DEPARTMENT<BR>INDUSTRIAL PROPERTY OFFICE REGISTRY</B></FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=4 WIDTH=594 HEIGHT=60 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; text-indent: 0.14in; margin-top: 0.01in">

         <img src="../../images/coat_arm.png" NAME="Picture 1" ALIGN=BOTTOM WIDTH=94 HEIGHT=72 BORDER=0 />
		</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=4 WIDTH=594 HEIGHT=35 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT COLOR="#000000"><FONT FACE="Times New Roman, serif"><FONT SIZE=3><B>THIS
			REPORT IS NOT OPEN TO PUBLIC INSPECTION AND MUST NOT BE REMOVED
			FROM THE FILE</B></FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=4 WIDTH=594 HEIGHT=15 BGCOLOR="#006600" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in">
			<FONT COLOR="#ffffff"><FONT FACE="Times New Roman, serif"><FONT SIZE=4 STYLE="font-size: 15pt"><B>SEARCH
			REPORT DETAILS FOR </B></FONT></FONT></FONT><FONT ><FONT FACE="Times New Roman, serif"><FONT SIZE=4 STYLE="font-size: 15pt"><B>&quot;
               <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>  &quot;</B></FONT></FONT></FONT></P>
		</TD>
       
	</TR>
	<TR>
		<TD WIDTH=122 HEIGHT=42 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" ALIGN=RIGHT STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT COLOR="#000000"><FONT FACE="Times New Roman, serif"><FONT SIZE=3 STYLE="font-size: 13pt">SYSTEM
			APPLICATION NUMBER :&nbsp;&nbsp;</FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=135 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT >&nbsp;<FONT FACE="Times New Roman, serif"><FONT SIZE=3 STYLE="font-size: 13pt"><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=134 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" ALIGN=RIGHT STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT COLOR="#000000"><FONT FACE="Times New Roman, serif"><FONT SIZE=3 STYLE="font-size: 13pt">REGISTRATION
			NUMBER :&nbsp;&nbsp;</FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=197 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT >&nbsp;<FONT FACE="Times New Roman, serif"><FONT SIZE=3 STYLE="font-size: 13pt"><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=4 WIDTH=594 HEIGHT=16 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT COLOR="#000000"><FONT FACE="Times New Roman, serif"><FONT SIZE=3 STYLE="font-size: 13pt">FILLING/APPLICATION
			DATE</FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=4 WIDTH=594 HEIGHT=15 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT ><FONT FACE="Times New Roman, serif"><FONT SIZE=3 STYLE="font-size: 13pt"><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=4 WIDTH=594 HEIGHT=16 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT COLOR="#000000"><FONT FACE="Times New Roman, serif"><FONT SIZE=3 STYLE="font-size: 13pt">APPLICANT
			NAME</FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=4 WIDTH=594 HEIGHT=16 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT ><FONT FACE="Times New Roman, serif"><FONT SIZE=3 STYLE="font-size: 13pt"><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=4 WIDTH=594 HEIGHT=15 BGCOLOR="#006600" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in">
			<FONT COLOR="#ffffff"><FONT FACE="Times New Roman, serif"><FONT SIZE=3 STYLE="font-size: 13pt"><B>---
			DESIGNS INFORMATION ---</B></FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=259 HEIGHT=16 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" ALIGN=RIGHT STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT COLOR="#000000">&nbsp;<FONT FACE="Times New Roman, serif"><FONT SIZE=3 STYLE="font-size: 13pt">DESIGN
			TYPE :&nbsp;</FONT></FONT></FONT></P>
		</TD>
		<TD COLSPAN=2 WIDTH=333 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT ><FONT FACE="Times New Roman, serif"><FONT SIZE=3 STYLE="font-size: 13pt"><asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=259 HEIGHT=16 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" ALIGN=RIGHT STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT COLOR="#000000">&nbsp;<FONT FACE="Times New Roman, serif"><FONT SIZE=3 STYLE="font-size: 13pt">PRODUCT
			TITLE :&nbsp;&nbsp;</FONT></FONT></FONT></P>
		</TD>
		<TD COLSPAN=2 WIDTH=333 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT ><FONT FACE="Times New Roman, serif"><FONT SIZE=3 STYLE="font-size: 13pt"><asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=4 WIDTH=594 HEIGHT=15 BGCOLOR="#006600" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in">
			<FONT COLOR="#ffffff"><FONT FACE="Times New Roman, serif"><FONT SIZE=3 STYLE="font-size: 13pt"><B>---
			DESIGNS REPRESENTATION ---</B></FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=4 WIDTH=594 HEIGHT=16 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			</P>

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
        
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=4 WIDTH=594 HEIGHT=15 BGCOLOR="#006600" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in">
			<FONT COLOR="#ffffff"><FONT FACE="Times New Roman, serif"><FONT SIZE=3 STYLE="font-size: 13pt"><B>---
			ADMINISTRATIVE OFFICER ---</B></FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=4 WIDTH=594 HEIGHT=16 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT ><FONT FACE="Times New Roman, serif"><FONT SIZE=3 STYLE="font-size: 13pt"> <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label> </FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=4 WIDTH=594 HEIGHT=15 BGCOLOR="#006600" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in">
			<FONT COLOR="#ffffff">&nbsp;</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=4 WIDTH=594 HEIGHT=138 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<CENTER>
				<TABLE DIR="LTR" WIDTH=581 CELLPADDING=1 CELLSPACING=0>
					<COL WIDTH=55>
					<COL WIDTH=165>
					<COL WIDTH=126>
					<COL WIDTH=110>
					<COL WIDTH=113>
					<TR>
						<TD COLSPAN=3 WIDTH=350 HEIGHT=16 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
							<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
							<FONT COLOR="#000000"><FONT FACE="Times New Roman, serif"><FONT SIZE=4 STYLE="font-size: 13pt"><B>SEARCH
							RESULTS</B></FONT></FONT></FONT></P>
						</TD>
						<TD COLSPAN=2 WIDTH=225 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
							<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
							<FONT COLOR="#000000"><FONT FACE="Times New Roman, serif"><FONT SIZE=4 STYLE="font-size: 13pt"><B>DATE</B></FONT></FONT></FONT></P>
						</TD>
					</TR>
					<TR>
						<TD WIDTH=55 HEIGHT=34 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
							<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
							<FONT COLOR="#000000"><FONT FACE="Times New Roman, serif"><FONT SIZE=4 STYLE="font-size: 13pt"><B>SN</B></FONT></FONT></FONT></P>
						</TD>
						<TD WIDTH=165 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
							<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
							<FONT COLOR="#000000"><FONT FACE="Times New Roman, serif"><FONT SIZE=4 STYLE="font-size: 13pt"><B>DESIGNS</B></FONT></FONT></FONT></P>
						</TD>
						<TD WIDTH=126 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
							<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
							<FONT COLOR="#000000"><FONT FACE="Times New Roman, serif"><FONT SIZE=4 STYLE="font-size: 13pt"><B>DS
							NUMBER</B></FONT></FONT></FONT></P>
						</TD>
						<TD WIDTH=110 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
							<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
							<FONT COLOR="#000000"><FONT FACE="Times New Roman, serif"><FONT SIZE=4 STYLE="font-size: 13pt"><B>DATE</B></FONT></FONT></FONT></P>
						</TD>
						<TD WIDTH=113 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
							<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
							<FONT COLOR="#000000"><FONT FACE="Times New Roman, serif"><FONT SIZE=4 STYLE="font-size: 13pt"><B>APPLICANT
							NAME</B></FONT></FONT></FONT></P>
						</TD>
					</TR>
					<TR>
						<TD WIDTH=55 HEIGHT=17 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
							<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
							<BR>
							</P>
						</TD>
						<TD WIDTH=165 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
							<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
							<FONT COLOR="#000000">&nbsp;</FONT></P>
						</TD>
						<TD WIDTH=126 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
							<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
							<FONT COLOR="#000000">&nbsp;</FONT></P>
						</TD>
						<TD WIDTH=110 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
							<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
							<FONT COLOR="#000000">&nbsp;</FONT></P>
						</TD>
						<TD WIDTH=113 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
							<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
							<FONT COLOR="#000000">&nbsp;</FONT></P>
						</TD>
					</TR>
					<TR>
						<TD WIDTH=55 HEIGHT=16 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
							<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
							<BR>
							</P>
						</TD>
						<TD WIDTH=165 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
							<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
							<FONT COLOR="#000000">&nbsp;</FONT></P>
						</TD>
						<TD WIDTH=126 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
							<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
							<FONT COLOR="#000000">&nbsp;</FONT></P>
						</TD>
						<TD WIDTH=110 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
							<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
							<FONT COLOR="#000000">&nbsp;</FONT></P>
						</TD>
						<TD WIDTH=113 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
							<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
							<FONT COLOR="#000000">&nbsp;</FONT></P>
						</TD>
					</TR>
					<TR>
						<TD WIDTH=55 HEIGHT=16 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
							<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
							<BR>
							</P>
						</TD>
						<TD WIDTH=165 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
							<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
							<FONT COLOR="#000000">&nbsp;</FONT></P>
						</TD>
						<TD WIDTH=126 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
							<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
							<FONT COLOR="#000000">&nbsp;</FONT></P>
						</TD>
						<TD WIDTH=110 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
							<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
							<FONT COLOR="#000000">&nbsp;</FONT></P>
						</TD>
						<TD WIDTH=113 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
							<P "" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
							<FONT COLOR="#000000">&nbsp;</FONT></P>
						</TD>
					</TR>
				</TABLE>
			</CENTER>
			<P "" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in; margin-bottom: 0.01in; line-height: 100%">
			<BR><BR>
			</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=4 WIDTH=594 HEIGHT=15 BGCOLOR="#006600" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-bottom: 0in; line-height: 100%">
			<FONT COLOR="#ffffff">&nbsp;</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=4 WIDTH=594 HEIGHT=34 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P "" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in; margin-bottom: 0.01in; line-height: 100%">
			<FONT COLOR="#000000"><FONT FACE="Times New Roman, serif"><FONT SIZE=3><B>THIS
			REPORT IS NOT OPEN TO PUBLIC INSPECTION AND MUST NOT BE REMOVED
			FROM THE FILE</B></FONT></FONT></FONT></P>
		</TD>
	</TR>

       <tr>
           <td>

                <input id="Button1" class='no-print' type="button" onclick="printAll(); return false" value="Print Document" />
           </td>

       </tr>
</TABLE><BR><BR>
</P>
       
  

    </form>
</body>
</html>
