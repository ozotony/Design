<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Acceptance_Letter.aspx.cs" Inherits="admin_pt_Acceptance_Letter" %>

<!DOCTYPE html>

<HTML>
<HEAD>
	<META HTTP-EQUIV="CONTENT-TYPE" CONTENT="text/html; charset=utf-8">
	<TITLE></TITLE>
	<META NAME="GENERATOR" CONTENT="LibreOffice 4.0.5.2 (Linux)">
	<META NAME="AUTHOR" CONTENT="ANITA">
	<META NAME="CREATED" CONTENT="20150225;13060000">
	<META NAME="CHANGEDBY" CONTENT="HP">
	<META NAME="CHANGED" CONTENT="20150226;14350000">
	<STYLE TYPE="text/css">
	<!--
		@page { size: 8.5in 11in; margin-right: 1.31in; margin-top: 1in; margin-bottom: 1in }
		P { margin-bottom: 0.08in; direction: ltr; color: #000000; line-height: 115%; widows: 2; orphans: 2 }
		P.western { font-family: "Calibri", sans-serif; font-size: 11pt; so-language: en-US }
		P.cjk { font-family: "Calibri", sans-serif; font-size: 11pt }
		P.ctl { font-family: "Times New Roman", serif; font-size: 11pt; so-language: ar-SA }
	-->

    @media print
{    
    .no-print, .no-print *
    {
        display: none !important;
    }
}
	</STYLE>
    <script src="../../js/funk.js" type="text/javascript"></script>

     
</HEAD>
<BODY LANG="en-US" TEXT="#000000" DIR="LTR">
<%--<TABLE align="center"  WIDTH=722 CELLPADDING=1 CELLSPACING=0 STYLE="page-break-before: always">
	<COL WIDTH=414>
	<COL WIDTH=304>
	<TR>
       
		<TD COLSPAN=2 WIDTH=720 HEIGHT=39 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2><B>FEDERAL
			MINISTRY OF TRADE AND INVESTMENT<BR>COMMERCIAL LAW
			DEPARTMENT<BR>INDUSTRIAL PROPERTY OFFICE REGISTRY </B></FONT></FONT>
			</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=73 BGCOLOR="#008000" STYLE="border: none; padding: 0in">
			<P LANG="en-US" CLASS="western" ALIGN=CENTER> <img src="../../images/coat_arm.png"  ALIGN=BOTTOM WIDTH=90 HEIGHT=84 BORDER=0/> </P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=39 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2><B><BR>ACCEPTANCE
			LETTER </B></FONT></FONT><FONT FACE="Times New Roman, serif"><FONT SIZE=2><BR>&nbsp;
			</FONT></FONT>
			</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=11 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=RIGHT>&nbsp;</P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=414 HEIGHT=12 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2><B>FILLING/APPLICATION
			DATE: </B></FONT></FONT>
			</P>
		</TD>
		<TD WIDTH=304 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2><B>REGISTRATION
			NUMBER: </B></FONT></FONT>
			</P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=414 HEIGHT=11 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><FONT COLOR="#ff0000"><FONT FACE="Times New Roman, serif"><FONT SIZE=2>(filing
			date)</FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=304 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><FONT COLOR="#ff0000"><FONT FACE="Times New Roman, serif"><FONT SIZE=2>(Ds
			number)</FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=11 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=RIGHT>&nbsp;</P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=414 HEIGHT=12 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2><B>ONLINE
			APPLICATION ID: </B></FONT></FONT>
			</P>
		</TD>
		<TD WIDTH=304 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2><B>AGENT
			CODE: </B></FONT></FONT>
			</P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=414 HEIGHT=11 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><FONT COLOR="#ff0000"><FONT FACE="Times New Roman, serif"><FONT SIZE=2>(transaction
			id)</FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=304 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><FONT COLOR="#ff0000"><FONT FACE="Times New Roman, serif"><FONT SIZE=2>(Agent
			code)</FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=11 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=RIGHT>&nbsp;</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=12 BGCOLOR="#1c5e55" STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><FONT COLOR="#ffffff"><FONT FACE="Times New Roman, serif"><FONT SIZE=2><B>---
			APPLICANT INFORMATION ---</B></FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=11 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER>&nbsp;</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=11 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2><B>APPLICANT
			NAME: </B></FONT></FONT>
			</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=12 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><FONT COLOR="#ff0000"><FONT FACE="Times New Roman, serif"><FONT SIZE=2>(Applicant
			name)</FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=11 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=RIGHT>&nbsp;</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=11 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2><B>ADDRESS:
			</B></FONT></FONT>
			</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=12 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><FONT COLOR="#ff0000"><FONT FACE="Times New Roman, serif"><FONT SIZE=2>(applicant
			address)</FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=11 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=RIGHT>&nbsp;</P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=414 HEIGHT=11 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2><B>PHONE
			NUMBER: </B></FONT></FONT>
			</P>
		</TD>
		<TD WIDTH=304 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2><B>E-MAIL:
			</B></FONT></FONT>
			</P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=414 HEIGHT=12 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><FONT COLOR="#ff0000"><FONT FACE="Times New Roman, serif"><FONT SIZE=2>(applicant
			phone number)</FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=304 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><FONT COLOR="#ff0000"><FONT FACE="Times New Roman, serif"><FONT SIZE=2>(applicant
			email address)</FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=11 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER>&nbsp;</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=11 STYLE="border: none; padding: 0in">
			<P CLASS="western"><BR>
			</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><BR>
			</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=12 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2><B>DESIGN:
			</B></FONT></FONT><FONT FACE="Times New Roman, serif"><FONT SIZE=2>&nbsp;</FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=25 STYLE="border: none; padding: 0in">
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#ff0000">
			                                                                  
			                            <FONT FACE="Times New Roman, serif"><FONT SIZE=2>(product
			title)</FONT></FONT></FONT></P>
			<P CLASS="western"><BR>
			</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=12 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><FONT FACE="Times New Roman, serif"><FONT SIZE=2>DESIGN
			REPRESENTATION&nbsp; </FONT></FONT>
			</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=11 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-bottom: 0in"><FONT COLOR="#ff0000"><FONT FACE="Times New Roman, serif"><FONT SIZE=2>DEVICE!!
			</FONT></FONT></FONT>
			</P>
			<P CLASS="western" ALIGN=CENTER><BR>
			</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=11 BGCOLOR="#1c5e55" STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER><FONT COLOR="#ffffff">&nbsp; </FONT>
			</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=11 STYLE="border: none; padding: 0in">
			<P CLASS="western">&nbsp;</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=68 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-bottom: 0.17in"><FONT FACE="Times New Roman, serif"><FONT SIZE=2><B>Your
			Design has been accepted and will be published/advertised in
			accordance with the Designs Act </B></FONT></FONT>
			</P>
			<P CLASS="western" ALIGN=CENTER><FONT COLOR="#ff0000"><FONT FACE="Times New Roman, serif"><FONT SIZE=2><B>(ADMIN
			SIGNATURE)</B></FONT></FONT></FONT><FONT FACE="Times New Roman, serif"><FONT SIZE=2><B><BR><BR>SADIQ
			MOHAMMED (FOR THE REGISTRAR) </B></FONT></FONT>
			</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=720 HEIGHT=11 STYLE="border: none; padding: 0in">
			<P CLASS="western" ALIGN=CENTER>&nbsp; 
			</P>
		</TD>
	</TR>
</TABLE>
<P CLASS="western" ALIGN=CENTER STYLE="margin-bottom: 0in; border-top: 1px solid #000000; border-bottom: none; border-left: none; border-right: none; padding-top: 0.01in; padding-bottom: 0in; padding-left: 0in; padding-right: 0in; display: none; line-height: 100%">
<FONT FACE="Arial, sans-serif"><FONT SIZE=2>Bottom of Form</FONT></FONT></P>
<P CLASS="western" ALIGN=CENTER STYLE="margin-bottom: 0in; border-top: none; border-bottom: 1px solid #000000; border-left: none; border-right: none; padding-top: 0in; padding-bottom: 0.01in; padding-left: 0in; padding-right: 0in; display: none; line-height: 100%">
<FONT FACE="Arial, sans-serif"><FONT SIZE=2>Top of Form</FONT></FONT></P>
<TABLE WIDTH=6 CELLPADDING=1 CELLSPACING=0>
	<COL WIDTH=4>
	<TR>
		<TD WIDTH=4 STYLE="border: none; padding: 0in">
			<P CLASS="western"><BR>
			</P>
		</TD>
	</TR>
</TABLE>
<P CLASS="western" STYLE="margin-bottom: 0.14in"><BR><BR>
</P>--%>
<TABLE align="center" WIDTH=738 CELLPADDING=1 CELLSPACING=0 id="cert">
	<COL WIDTH=487>
	<COL WIDTH=245>
	<TR>
		<TD COLSPAN=2 WIDTH=734 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in 0.02in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><B>FEDERAL
			MINISTRY OF INDUSTRY, TRADE AND INVESTMENT<BR>COMMERCIAL LAW
			DEPARTMENT<BR>INDUSTRIAL PROPERTY OFFICE REGISTRY</B></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=734 BGCOLOR="#008000" STYLE="border: 1px solid #008000; padding: 0.01in 0.02in">
			<P LANG="en-US" CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
		<img src="../../images/coat_arm.png"  ALIGN=BOTTOM WIDTH=64 HEIGHT=60 BORDER=0/>	</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=734 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in 0.02in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT COLOR="#000000"><FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><B><BR>ACCEPTANCE
			LETTER</B></FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt">&nbsp;<BR>&nbsp;</FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=487 BGCOLOR="#ffffff" STYLE="border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: none; padding-top: 0.01in; padding-bottom: 0.01in; padding-left: 0.02in; padding-right: 0in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><B>FILLING/APPLICATION
			DATE:</B></FONT></FONT></P>
		</TD>
		<TD WIDTH=245 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><B>REGISTRATION
			NUMBER:</B></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=487 BGCOLOR="#ffffff" STYLE="border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: none; padding-top: 0.01in; padding-bottom: 0.01in; padding-left: 0.02in; padding-right: 0in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> </FONT></FONT></P>
		</TD>
		<TD WIDTH=245 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT COLOR="#000000"><FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label> </FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=734 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in 0.02in">
			<P CLASS="western" ALIGN=RIGHT STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			&nbsp;</P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=487 BGCOLOR="#ffffff" STYLE="border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: none; padding-top: 0.01in; padding-bottom: 0.01in; padding-left: 0.02in; padding-right: 0in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><B>ONLINE
			APPLICATION ID:</B></FONT></FONT></P>
		</TD>
		<TD WIDTH=245 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><B>AGENT
			CODE:</B></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=487 BGCOLOR="#ffffff" STYLE="border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: none; padding-top: 0.01in; padding-bottom: 0.01in; padding-left: 0.02in; padding-right: 0in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT COLOR="#000000"><FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label> </FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=245 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label> </FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=734 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in 0.02in">
			<P CLASS="western" ALIGN=RIGHT STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			&nbsp;</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=734 BGCOLOR="#1c5e55" STYLE="border: 1px solid #000000; padding: 0.01in 0.02in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT COLOR="#ffffff"><FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><B>---
			APPLICANT INFORMATION ---</B></FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=734 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in 0.02in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			&nbsp;</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=734 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in 0.02in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><B>APPLICANT
			NAME:</B></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=734 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in 0.02in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label> </FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=734 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in 0.02in">
			<P CLASS="western" ALIGN=RIGHT STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			&nbsp;</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=734 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in 0.02in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><B>ADDRESS:</B></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=734 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in 0.02in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><asp:Label ID="Label6" runat="server" Text="Label"></asp:Label> </FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=734 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in 0.02in">
			<P CLASS="western" ALIGN=RIGHT STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			&nbsp;</P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=487 BGCOLOR="#ffffff" STYLE="border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: none; padding-top: 0.01in; padding-bottom: 0.01in; padding-left: 0.02in; padding-right: 0in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><B>PHONE
			NUMBER:</B></FONT></FONT></P>
		</TD>
		<TD WIDTH=245 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><B>E-MAIL:</B></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=487 BGCOLOR="#ffffff" STYLE="border-top: 1px solid #000000; border-bottom: 1px solid #000000; border-left: 1px solid #000000; border-right: none; padding-top: 0.01in; padding-bottom: 0.01in; padding-left: 0.02in; padding-right: 0in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><asp:Label ID="Label7" runat="server" Text="Label"></asp:Label> </FONT></FONT></P>
		</TD>
		<TD WIDTH=245 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><asp:Label ID="Label8" runat="server" Text="Label"></asp:Label> </FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=734 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in 0.02in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			&nbsp;</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=734 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in 0.02in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT COLOR="#000000"><FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><B>DESIGN:&nbsp;</B></FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt">&nbsp;</FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=734 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in 0.02in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><asp:Label ID="Label9" runat="server" Text="Label"></asp:Label> </FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=734 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in 0.02in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			&nbsp;</P>
		</TD>
	</TR>
		<TR>
		<TD COLSPAN=4 WIDTH=594 HEIGHT=16 BGCOLOR="#ffffff" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			</P>

             <tr>
            <td align="right" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
                REPRESENTATION OF DESIGN 1 :</td>
            <td STYLE="border: 1px solid #000001; padding: 0.01in 0.02in" >
                 <% if ((lt_mi[0].rep_pic != "")&&(lt_mi[0].rep_pic != "0"))
               {
                   Response.Write("<a href=" + lt_mi[0].rep_pic + " target='_blank'><img src=\"" + lt_mi[0].rep_pic + "\" height=\"200px\" width=\"200px\" /></a>");        
         }  else { Response.Write("NONE"); 
               } %></td>
        </tr>        
        <tr>
            <td align="right" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
                REPRESENTATION OF DESIGN 2:</td>
            <td  STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
                    <% if ((lt_mi[0].rep2_pic != "") && (lt_mi[0].rep2_pic != "0"))
               {
                   Response.Write("<a href=" + lt_mi[0].rep2_pic + " target='_blank'><img src=\"" + lt_mi[0].rep2_pic + "\" height=\"200px\" width=\"200px\" /></a>");        
         }  else { Response.Write("NONE"); 
               } %></td>
        </tr>
        <tr>
            <td align="right" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
              REPRESENTATION OF DESIGN 3 :
            </td>
            <td STYLE="border: 1px solid #000001; padding: 0.01in 0.02in" >
            <% if ((lt_mi[0].rep3_pic != "") && (lt_mi[0].rep3_pic != "0"))
               {
                   Response.Write("<a href=" + lt_mi[0].rep3_pic + " target='_blank'><img src=\"" + lt_mi[0].rep4_pic + "\" height=\"200px\" width=\"200px\" /></a>");        
         }  else { Response.Write("NONE"); 
               } %></td>
        </tr>        
        <tr>
            <td align="right" STYLE="border: 1px solid #000001; padding: 0.01in 0.02in">
                REPRESENTATION OF DESIGN 4 :</td>
            <td STYLE="border: 1px solid #000001; padding: 0.01in 0.02in" >
                 <% if ((lt_mi[0].rep4_pic != "") && (lt_mi[0].rep4_pic != "0"))
               {
                        Response.Write("<a href=" + lt_mi[0].rep4_pic + " target='_blank'> <img src=\""+ lt_mi[0].rep3_pic + "\" height=\"200px\" width=\"200px\" /></a>");        
         }  else { Response.Write("NONE"); 
               } %></td>
        </tr>
        
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=734 BGCOLOR="#1c5e55" STYLE="border: 1px solid #000000; padding: 0.01in 0.02in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT COLOR="#ffffff">&nbsp;</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=734 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in 0.02in">
			<P CLASS="western" STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			&nbsp;</P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=734 BGCOLOR="#ffffff" STYLE="border: 1px solid #000000; padding: 0.01in 0.02in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.01in; margin-right: 0.01in; margin-top: 0.01in">
			<FONT COLOR="#000000"><FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><B>Your Designs has been accepted and will be published/advertised in accordance with the Patent &Designs Act &nbsp;<BR><BR></B></FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><SPAN LANG="en-US"><B>
          <%-- <img src="../../images/Sig4.jpg" ALIGN=BOTTOM WIDTH=137 HEIGHT=72 BORDER=0 />     </B></SPAN></FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><B><BR><BR>Hadiza B. Ibrahim(FOR THE REGISTRAR)</B></FONT></FONT></FONT></P>--%>
             <img src="../../images/hadiza.jpg" ALIGN=BOTTOM WIDTH=137 HEIGHT=72 BORDER=0 />     </B></SPAN></FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Trebuchet MS, sans-serif"><FONT SIZE=1 STYLE="font-size: 8pt"><B><BR><BR>Hadiza B. Ibrahim(FOR THE REGISTRAR)</B></FONT></FONT></FONT></P>
		</TD>
	</TR>
    <tr>
        <td>
           
        </td>

    </tr>
</TABLE>

     <input id="Button1" type="button" class='no-print' onclick="printAll(); return false" value="Print Document" />
     
<P CLASS="western" STYLE="margin-bottom: 0.14in"><BR><BR>
</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in"><BR><BR>
</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in">&nbsp;</P>

<P CLASS="western" STYLE="margin-bottom: 0.14in"><BR><BR>
</P>
</BODY>
</HTML>
