<%@ Page Language="C#" AutoEventWireup="true" CodeFile="xindex.aspx.cs" Inherits="xindex" %>
<%@ Register assembly="Brettle.Web.NeatUpload" namespace="Brettle.Web.NeatUpload" tagprefix="Upload" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

<head id="Head1" runat="server">

    <title>
DESIGN APPLICATION NOTICE
</title>
  <link href="css/style.css" rel="stylesheet" type="text/css" />

<script src="js/jquery.js" type="text/javascript"></script>

<script src="js/funk.js" type="text/javascript"></script>

    <style type="text/css">
		.ProgressBar {
			margin: 0px;
			border: 0px;
			padding: 0px;
			width: 100%;
			height: 3em;
		}
		</style>

<link rel="stylesheet" href="css/jquery.ui.all.css" type="text/css"/>
<link rel="stylesheet" href="css/jquery.ui.theme.css" type="text/css"/>


<script src="js/jquery-1.7.2.min.js" type="text/javascript"></script>
<script src="js/jquery-ui-1.8.16.custom.min.js" type="text/javascript"></script>
<script src="js/jquery.js" type="text/javascript"></script>
<script src="js/ui/jquery.cookie.js" type="text/javascript"></script>
<script src="js/ui/jquery.ui.core.js" type="text/javascript"></script>
<script src="js/ui/jquery.ui.widget.js" type="text/javascript"></script>

<script src="js/ui/jquery.ui.datepicker.js" type="text/javascript"></script>

<script language="javascript" type="text/javascript">

    $(function () {

        $(".txt_date_pri").datepicker({
            changeMonth: true,
            changeYear: true,
            showButtonPanel: true,
            dateFormat: 'yy-mm-dd',
            yearRange: 'c-100:c+0'
        });

    });
</script>

    
    <script language="javascript" type="text/javascript">
// <![CDATA[
        function Proceed_onclick() {
            window.location.href = "./application.aspx";
        }

// ]]>
    </script>
    <style type="text/css">

 p.MsoNormal
	{margin-top:0in;
	margin-right:0in;
	margin-bottom:10.0pt;
	margin-left:0in;
	line-height:115%;
	font-size:11.0pt;
	font-family:"Calibri","sans-serif";
	}
p.MsoListParagraphCxSpFirst
	{margin-top:0in;
	margin-right:0in;
	margin-bottom:0in;
	margin-left:.5in;
	margin-bottom:.0001pt;
	line-height:115%;
	font-size:11.0pt;
	font-family:"Calibri","sans-serif";
	}
p.MsoListParagraphCxSpMiddle
	{margin-top:0in;
	margin-right:0in;
	margin-bottom:0in;
	margin-left:.5in;
	margin-bottom:.0001pt;
	line-height:115%;
	font-size:11.0pt;
	font-family:"Calibri","sans-serif";
	}
p.MsoListParagraphCxSpLast
	{margin-top:0in;
	margin-right:0in;
	margin-bottom:10.0pt;
	margin-left:.5in;
	line-height:115%;
	font-size:11.0pt;
	font-family:"Calibri","sans-serif";
	}
a:link
	{color:blue;
	text-decoration:underline;
        }
        .style1
        {
            color: black;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
  

<div>
    <div class="container">
        <div class="sidebar">
        </div>
        <div class="content_tm_ack">
            <div class="adminheader">
                <div class="xmenu">
                    <div class="menu">
                        <ul>
                            
                        </ul>
                    </div>
                </div>
                <div class="xlogo">
                    <div class="xlogo_l">
                    </div>
                </div>
            </div>
            <div id="searchform">
<asp:Panel ID="tt" runat="server"> 
    <table align="center" width="100%" class="form">
        <tr>
            <td align="center" >
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
            <td width="22%" align="center" bgcolor="#990033"></td>
        </tr>
        
  
        <tr>
            <td width="22%" align="center">
                <strong>&nbsp;APPLICATION PROCESS NOTICE</strong> </td>
        </tr>
        
        
        <tr>
            <td width="50%" align="left">
               
                <div align="center">Welcome to the &quot;Designs Application Section&quot;, Please kindly note and follow 
                the rules below for a successful application</div>
                &nbsp;<p class="MsoNormal" style="margin-bottom:0in;margin-bottom:.0001pt;text-align:
justify;line-height:normal">
                    <b style="mso-bidi-font-weight:normal">
                    <span style="font-family:&quot;Andalus&quot;,&quot;serif&quot;">Technical 
                    Information:<o:p></o:p></span></b></p>
                <p class="MsoListParagraphCxSpFirst" style="margin-bottom:0in;margin-bottom:.0001pt;
mso-add-space:auto;text-align:justify;text-indent:-.25in;line-height:normal;
mso-list:l0 level1 lfo1">
                    <![if !supportLists]>
                    <span style="font-family:Wingdings;
mso-fareast-font-family:Wingdings;mso-bidi-font-family:Wingdings"><span style="mso-list:Ignore">Ø<span 
                        style="font:7.0pt &quot;Times New Roman&quot;">&nbsp; </span></span></span><![endif]>
                    <span style="font-family:&quot;Andalus&quot;,&quot;serif&quot;">Once an 
                    application has been started, please do &quot;<strong>NOT</strong>&quot; click on the &quot;<strong>BACK</strong>&quot; 
                    button of the browser<o:p></o:p></span></p>
                <p class="MsoListParagraphCxSpMiddle" style="margin-bottom:0in;margin-bottom:
.0001pt;mso-add-space:auto;text-align:justify;text-indent:-.25in;line-height:
normal;mso-list:l0 level1 lfo1">
                    <![if !supportLists]>
                    <span style="font-family:
Wingdings;mso-fareast-font-family:Wingdings;mso-bidi-font-family:Wingdings">
                    <span style="mso-list:Ignore">Ø<span 
                        style="font:7.0pt &quot;Times New Roman&quot;">&nbsp; </span></span></span><![endif]>
                    <span style="font-family:&quot;Andalus&quot;,&quot;serif&quot;">Do &quot;<strong><span style="font-family:
&quot;Andalus&quot;,&quot;serif&quot;">NOT</span></strong>&quot; start &quot;<strong>MULTIPLE</strong>&quot; 
                    application on the same browser (That is, do not start multiple applications by 
                    creating &quot;<strong>multiple tabs</strong>&quot; within the same browser<o:p></o:p></span></p>
                <p class="MsoListParagraphCxSpMiddle" style="margin-bottom:0in;margin-bottom:
.0001pt;mso-add-space:auto;text-align:justify;text-indent:-.25in;line-height:
normal;mso-list:l0 level1 lfo1">
                    <![if !supportLists]>
                    <span style="font-family:
Wingdings;mso-fareast-font-family:Wingdings;mso-bidi-font-family:Wingdings">
                    <span style="mso-list:Ignore">Ø<span 
                        style="font:7.0pt &quot;Times New Roman&quot;">&nbsp; </span></span></span><![endif]>
                    <span style="font-family:&quot;Andalus&quot;,&quot;serif&quot;">If multiple 
                    applications are to be started, please do so by starting each one in a different 
                    browser<o:p></o:p></span></p>
                <p class="MsoListParagraphCxSpLast" style="margin-bottom:0in;margin-bottom:.0001pt;
mso-add-space:auto;text-align:justify;text-indent:-.25in;line-height:normal;
mso-list:l0 level1 lfo1">
                    <![if !supportLists]>
                    <span style="font-family:Wingdings;
mso-fareast-font-family:Wingdings;mso-bidi-font-family:Wingdings"><span style="mso-list:Ignore">Ø<span 
                        style="font:7.0pt &quot;Times New Roman&quot;">&nbsp; </span></span></span><![endif]>
                    <span style="font-family:&quot;Andalus&quot;,&quot;serif&quot;">During each step 
                    (or form), please click on the &quot;<strong>Save</strong>&quot; or &quot;<strong>Save and 
                    Continue</strong>&quot; button &quot;<strong>ONCE</strong>&quot; to proceed<o:p></o:p></span></p>
                <span style="font-size:11.0pt;line-height:115%;font-family:&quot;Andalus&quot;,&quot;serif&quot;;
mso-fareast-font-family:Calibri;mso-fareast-theme-font:minor-latin;mso-ansi-language:
EN-US;mso-fareast-language:EN-US;mso-bidi-language:AR-SA">This service is best used with 
                Internet Explorer 6, Firefox 2 or Safari 2 or later on a screen at least 1024 by 
                768 pixels in size. Our website requires the use of cookies and JavaScript and 
                supports the ISO 8859-1 character set<br />
                <br />
                <p class="MsoNormal">
                    <b style="mso-bidi-font-weight:normal">
                    <span style="font-family:&quot;Andalus&quot;,&quot;serif&quot;;color:red">Before 
                    Starting the Application Process, It Is Important To Have Clearly In Mind <o:p></o:p>
                    </span></b>
                </p>
                <p class="MsoListParagraphCxSpFirst">
                    <![if !supportLists]>
                    <span style="font-family:&quot;Andalus&quot;,&quot;serif&quot;;
mso-fareast-font-family:Andalus"><span style="mso-list:Ignore">1.<span 
                        style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;
                    </span></span></span><![endif]>
                    <span style="font-family:&quot;Andalus&quot;,&quot;serif&quot;">The Design you want to register; <o:p></o:p></span>
                </p>
                <p class="MsoListParagraphCxSpMiddle">
                    <![if !supportLists]><b style="mso-bidi-font-weight:
normal"><span class="style1" 
                        style="font-family: &quot;Andalus&quot;,&quot;serif&quot;; mso-fareast-font-family: Andalus;">
                    <span style="mso-list:Ignore">2.<span 
                        style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp; </span>
                    </span></span></b><![endif]>
                    <span style="font-family:&quot;Andalus&quot;,&quot;serif&quot;">The goods and/or 
                    services in connection with which you wish to register the 
                <span style="font-size:11.0pt;line-height:115%;font-family:&quot;Andalus&quot;,&quot;serif&quot;;
mso-fareast-font-family:Calibri;mso-fareast-theme-font:minor-latin;mso-ansi-language:
EN-US;mso-fareast-language:EN-US;mso-bidi-language:AR-SA">
                    <span style="font-family:&quot;Andalus&quot;,&quot;serif&quot;">Design </span>
                </span>and you are 
                    advised to specify the items for the class instead of 
                    <b style="mso-bidi-font-weight:normal"><span style="color:red"“all the goods in 
                    the class”.<o:p></o:p></span></b></span></p>
                <p class="MsoListParagraphCxSpMiddle">
                    <![if !supportLists]><span style="mso-list:Ignore">
                    <span style="font-family: &quot;Andalus&quot;,&quot;serif&quot;; mso-fareast-font-family: Andalus;">
                    3.</span><span style="font-family:
&quot;Andalus&quot;,&quot;serif&quot;;mso-fareast-font-family:Andalus;color:red"><span 
                        style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span></span></span><![endif]><span style="font-family:&quot;Andalus&quot;,&quot;serif&quot;">The acceptable 
                    unloadable formats for uploading 
                <span style="font-size:11.0pt;line-height:115%;font-family:&quot;Andalus&quot;,&quot;serif&quot;;
mso-fareast-font-family:Calibri;mso-fareast-theme-font:minor-latin;mso-ansi-language:
EN-US;mso-fareast-language:EN-US;mso-bidi-language:AR-SA">
                    <span style="font-family:&quot;Andalus&quot;,&quot;serif&quot;">Design </span>
                </span>representations are
                    <span style="color:red"><strong>jpeg and pdf formats only</strong>.<o:p></o:p></span></span></p>
                <p class="MsoListParagraphCxSpMiddle">
                    <![if !supportLists]>
                    <span style="font-family:
&quot;Andalus&quot;,&quot;serif&quot;;mso-fareast-font-family:Andalus">
                    <span style="mso-list:Ignore">4..<span 
                        style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;</span></span></span><![endif]><span style="font-family:&quot;Andalus&quot;,&quot;serif&quot;">Ensure that the 
                    name and address of proprietor are correct and properly filled<o:p></o:p></span></p>
                <p class="MsoListParagraphCxSpMiddle">
                    <![if !supportLists]>
                    <span style="font-family:
&quot;Andalus&quot;,&quot;serif&quot;;mso-fareast-font-family:Andalus">
                    <span style="mso-list:Ignore">5.<span 
                        style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span></span></span><![endif]><span style="font-family:&quot;Andalus&quot;,&quot;serif&quot;">Remember to 
                    select the local or foreign mark options<o:p></o:p></span></p>
                <p class="MsoListParagraphCxSpMiddle">
                    <![if !supportLists]>
                    <span style="font-family:
&quot;Andalus&quot;,&quot;serif&quot;;mso-fareast-font-family:Andalus">
                    <span style="mso-list:Ignore">6.<span 
                        style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span></span></span><![endif]><span style="font-family:&quot;Andalus&quot;,&quot;serif&quot;">All information 
                    entered and submitted cannot be retrieved, amended or corrected without the 
                    payment of an amendment fee. Please ensure that the information filled is 
                    correct.<o:p></o:p></span></p>
                <p class="MsoListParagraphCxSpMiddle">
                    <![if !supportLists]>
                    <span style="font-family:
&quot;Andalus&quot;,&quot;serif&quot;;mso-fareast-font-family:Andalus">
                    <span style="mso-list:Ignore">7.<span 
                        style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span></span></span><![endif]><span style="font-family:&quot;Andalus&quot;,&quot;serif&quot;">All 
                    correspondence with regards to applications filed will be sent to the agent 
                    email as specified during accreditation. <o:p></o:p></span>
                </p>
                <p class="MsoListParagraphCxSpMiddle">
                    <![if !supportLists]>
                    <span style="font-family:
&quot;Andalus&quot;,&quot;serif&quot;;mso-fareast-font-family:Andalus">
                    <span style="mso-list:Ignore">8.<span 
                        style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span></span></span><![endif]><span style="font-family:&quot;Andalus&quot;,&quot;serif&quot;">You will be 
                    issued an on-screen acknowledgment copy immediately after submission. If you do 
                    not receive your acknowledgment immediately kindly use the ‘check status’ link 
                    to re-print your acknowledgment. <o:p></o:p></span>
                </p>
                <p class="MsoListParagraphCxSpLast">
                    <![if !supportLists]>
                    <span style="font-family:&quot;Andalus&quot;,&quot;serif&quot;;
mso-fareast-font-family:Andalus"><span style="mso-list:Ignore">9.<span 
                        style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span></span></span><![endif]><span style="font-family:&quot;Andalus&quot;,&quot;serif&quot;">This form has a 
                    session of 20 minutes; ensure you complete your form within the specified period 
                    to avoid being timed out.<o:p></o:p></span></p>
                <p class="MsoNormal">
                    <span style="font-family:&quot;Andalus&quot;,&quot;serif&quot;">For more 
                    information on how to file applications using DAS, kindly send an email to
                    </span><a href="mailto:customersupport@iponoigeria.com">
                    <span style="font-family:&quot;Andalus&quot;,&quot;serif&quot;">
                    customersupport@iponoigeria.com</span></a><span 
                        style="font-family:&quot;Andalus&quot;,&quot;serif&quot;"> and all requests 
                    will be treated within 24hours Mondays- Fridays. <o:p></o:p></span>
                </p>
                </span><br />
                <br />
                <div align="center"><strong>THANK YOU FOR YOUR UNDERSTANDING</strong></div> </td>
        </tr>

         

        
        
        <tr>
            <td class="tbbg">               
                &nbsp;</td>
        </tr>
        
       
        <tr>
            <td  align="center">
                
                &nbsp; <asp:Button ID="Button1" runat="server" class="button" Text="Proceed" OnClick="Button1_Click" /></td>
        </tr>
         
    </table>
    </asp:Panel>
<asp:Panel  ID="tt2" Visible="false" runat="server">
    <table align="center" width="1200px">
            <tr >
                <td >
    <div id="searchform">                
        <table style="width:100%;font-family:Calibri;" id="applicantForm" align="center" >
            <tr align="center">
                <td colspan="2">
                    <img alt="Coat Of Arms" height="79" src="images/coat_of_arms.png" 
                        width="85" />
               </td>
            </tr>
            <tr align="center" style=" font-size:11pt;" >
                <td colspan="2">
                    FEDERAL REPUBLIC OF NIGERIA<br />
                    FEDERAL MINISTRY OF INDUSTRY, TRADE AND INVESTMENT<br />
                    COMMERCIAL LAW DEPARTMENT<br />
                    TRADEMARKS, PATENTS AND DESIGNS  REGISTRY<br />
                    PATENTS AND DESIGNS ACT CAP 344 
</td>
            </tr>
            
            <tr>
                <td colspan="2" style="font-size:18pt;line-height:115%;" align="center">
                        APPLICATION FOR A DESIGN
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    </td>
            </tr>
            <tr>
                <td colspan="2" class="tbbg_left">
                    &nbsp;APPLICANT INFORMATION >></td>
            </tr>
            <tr>
                <td width="20%">
                    &nbsp;APPLICATION TYPE:</td>
                <td>        
                        <asp:Label ID="lbl_type" runat="server" Text="" Font-Bold="true"></asp:Label>
        </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:gridview ID="gv_app" runat="server" ShowFooter="True" 
            AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" 
            ForeColor="#333333" GridLines="None" Width="100%">
           <AlternatingRowStyle BackColor="White" />
        <Columns>
        <asp:BoundField DataField="RowNumber_app" HeaderText="Sn"  HeaderStyle-Width="20%" HeaderStyle-HorizontalAlign="Left">     
            </asp:BoundField>       
          <asp:TemplateField HeaderText="Information" HeaderStyle-HorizontalAlign="Left">
            <ItemTemplate>
             NAME: <br />
                 <asp:TextBox ID="txt_name_app" runat="server" class="textbox" Width="400px"></asp:TextBox><br />
                 ADDRESS:<br />
                  <asp:TextBox ID="txt_address_app" runat="server" Width="400px" CssClass="textbox" 
                    Height="80px" TextMode="MultiLine"></asp:TextBox> <br />              
            E-MAIL: <br />
                 <asp:TextBox ID="txt_email_app" runat="server" class="textbox" Width="400px"></asp:TextBox><br />
                  MOBILE: <br />
                 <asp:TextBox ID="txt_mobile_app" runat="server" class="textbox" Width="400px"></asp:TextBox>
            </ItemTemplate>
             <FooterStyle HorizontalAlign="Right" />
            <FooterTemplate>
            Add Applicant
             <asp:Button ID="ButtonAddApp" runat="server" Text="" 
                    onclick="ButtonAddApp_Click" CssClass="plus_button" />
            </FooterTemplate>
        </asp:TemplateField>
        </Columns>
           <EditRowStyle BackColor="#7C6F57" />
           <FooterStyle Font-Bold="True" ForeColor="#006699" />
           <HeaderStyle BackColor="#999999" Font-Bold="True" ForeColor="White" />
           <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
           <RowStyle BackColor="#E3EAEB" />
           <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
</asp:gridview></td>
            </tr>
           
            <tr>
                <td colspan="2" class="tbbg_left">
                    &nbsp;DESIGN INFORMATON >></td>
            </tr>
            <tr>
                <td >
                    &nbsp;TITLE OF DESIGN:</td>
                <td>
                    <asp:TextBox ID="txt_title_of_invention" runat="server" class="textbox" Width="400px"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td>
                   &nbsp;CLASS OF DESIGN:</td>
                <td>
                    <asp:TextBox ID="txt_class_of_design" runat="server" class="textbox" Width="400px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="sub_header" align="left">
                    &nbsp;TRUE CREATOR INFORMATION >></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:gridview ID="gv_inv" runat="server" ShowFooter="True" 
            AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" 
            ForeColor="#333333" GridLines="None" Width="100%">
           <AlternatingRowStyle BackColor="White" />
        <Columns>
        <asp:BoundField DataField="RowNumber_inv" HeaderText="Sn"  HeaderStyle-Width="20%" HeaderStyle-HorizontalAlign="Left"/>        
       
          <asp:TemplateField HeaderText="Information" HeaderStyle-HorizontalAlign="Left">
            <ItemTemplate>
            NAME: <br />
                 <asp:TextBox ID="txt_name_inv" runat="server" class="textbox" Width="400px"></asp:TextBox><br />
                  ADDRESS:<br />
                 <asp:TextBox ID="txt_address_inv" runat="server" Width="400px" CssClass="textbox" 
                    Height="80px" TextMode="MultiLine"></asp:TextBox> <br />
                     E-MAIL: <br />
                 <asp:TextBox ID="txt_email_inv" runat="server" class="textbox" Width="400px"></asp:TextBox><br />
                 MOBILE: <br />
                 <asp:TextBox ID="txt_mobile_inv" runat="server" class="textbox" Width="400px"></asp:TextBox>
            </ItemTemplate>
             <FooterStyle HorizontalAlign="Right" />
            <FooterTemplate>
            Add Inventor
             <asp:Button ID="ButtonAddInv" runat="server" Text="" 
                    onclick="ButtonAddInv_Click" CssClass="plus_button" />
            </FooterTemplate>
        </asp:TemplateField>
        </Columns>
           <EditRowStyle BackColor="#7C6F57" />
           <FooterStyle BackColor="" Font-Bold="True" ForeColor="#006699" />
           <HeaderStyle BackColor="#999999" Font-Bold="True" ForeColor="White" />
           <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
           <RowStyle BackColor="#E3EAEB" />
           <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
</asp:gridview></td>
            </tr>
            <tr>
                <td colspan="2" class="tbbg_left">
                    &nbsp;ASSIGNMENT INFORMATION (if any) >></td>
            </tr>
            <tr>
                <td colspan="2" style="background-color:#999999;" align="left">
                    &nbsp;ASSIGNEE</td>
            </tr>
            <tr>
                <td>
                    &nbsp;NAME:</td>
                <td>
                    <asp:TextBox ID="txt_assignee_name" runat="server" class="textbox" 
                        Width="400px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;ADDRESS:</td>
                <td>
                <asp:TextBox ID="txt_assignee_address" runat="server" Width="400px" CssClass="textbox" 
                    Height="80px" TextMode="MultiLine"></asp:TextBox>               
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" style="background-color:#999999;" align="left">
                    &nbsp;ASSIGNOR</td>
            </tr>
            <tr>
                <td>
                    &nbsp;NAME:</td>
                <td>
                    <asp:TextBox ID="txt_assignor_name" runat="server" class="textbox" 
                        Width="400px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;ADDRESS:</td>
                <td>
                <asp:TextBox ID="txt_assignor_address" runat="server" Width="400px" CssClass="textbox" 
                    Height="80px" TextMode="MultiLine"></asp:TextBox>               
                </td>
            </tr>
            <tr>
                <td colspan="2" class="tbbg_left">
                    &nbsp;PRIORITY INFORMATION [applicable to foreign applications(convention-design) ONLY] >></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:gridview ID="gv_pri" runat="server" ShowFooter="True" 
            AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" 
            ForeColor="#333333" GridLines="None" Width="100%">
           <AlternatingRowStyle BackColor="White" />
           
        <Columns>
        <asp:BoundField DataField="RowNumber_pri" HeaderText="Sn"  HeaderStyle-Width="10%" HeaderStyle-HorizontalAlign="Left"/>        
        <asp:TemplateField HeaderText="COUNTRY" HeaderStyle-Width="35%" HeaderStyle-HorizontalAlign="Left">
            <ItemTemplate>
                 <asp:DropDownList ID="select_country_pri" runat="server" CssClass="textbox" DataSourceID="ds_Nationality" DataTextField="name"   DataValueField="ID"  >
                </asp:DropDownList>
                <asp:SqlDataSource ID="ds_Nationality" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:cldConnectionString %>" 
                    SelectCommand="SELECT * FROM [country] order by name "></asp:SqlDataSource>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="APPLICATION NUMBER" HeaderStyle-Width="35%" HeaderStyle-HorizontalAlign="Left">
            <ItemTemplate>
                <asp:TextBox ID="txt_application_no_pri" runat="server" class="textbox" Width="200px"></asp:TextBox>
            </ItemTemplate>
        </asp:TemplateField>
          <asp:TemplateField HeaderText="DATE" HeaderStyle-HorizontalAlign="Left">
            <ItemTemplate>           
                       <asp:TextBox ID="txt_date_pri" runat="server" Width="70px" CssClass="txt_date_pri" ></asp:TextBox>
            </ItemTemplate>
             <FooterStyle HorizontalAlign="Right" />
            <FooterTemplate>
             Add Priority
             <asp:Button ID="ButtonAddPri" runat="server" Text="" 
                    onclick="ButtonAddPri_Click" CssClass="plus_button" />
            </FooterTemplate>
        </asp:TemplateField>
        </Columns>
           <EditRowStyle BackColor="#7C6F57" />
           <FooterStyle BackColor="" Font-Bold="True" ForeColor="#006699" />
           <HeaderStyle BackColor="#999999" Font-Bold="True" ForeColor="White"/>
           <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
           <RowStyle BackColor="#E3EAEB" />
           <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
</asp:gridview></td>
            </tr>
            <tr>
                <td colspan="2" class="tbbg_left">
                   &nbsp;ADDRESS OF SERVICE IN NIGERIA >></td>
            </tr>
            <tr>
            <td>
                &nbsp;&nbsp;AGENT CODE:             </td>
            <td >
                <asp:TextBox ID="rep_code" runat="server" Width="400px" 
                    CssClass="textbox" ReadOnly="True"></asp:TextBox>
                                
                                   
                </td>
            </tr>
            <tr>
            <td align="left">
                &nbsp;&nbsp;NAME :
            </td>
            <td align="left" >
                <asp:TextBox ID="rep_xname" runat="server" Width="400px" CssClass="textbox" ></asp:TextBox>               
            </td>
            </tr>
            <tr>
            <td align="left">
                &nbsp;&nbsp;NATIONALITY :
            </td>
            <td align="left" >
                <asp:DropDownList ID="select_rep_nationality" runat="server" CssClass="textbox" DataSourceID="ds_Nationality" DataTextField="name" 
                    DataValueField="ID" >
                </asp:DropDownList>
                <asp:SqlDataSource ID="ds_Nationality" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:cldConnectionString %>" 
                    SelectCommand="SELECT * FROM [country] order by name">                  
                    </asp:SqlDataSource>
                     </td>
            </tr>
            <tr>
            <td colspan="2" style="background-color:#999999;">
                &nbsp;ADDRESS INFORMATION >></td>
            </tr>
            <tr>
            <td >
                &nbsp;&nbsp;COUNTRY :
            </td>
            <td >
                NIGERIA             
           </td>
            </tr>
            <tr>
            <td >
                &nbsp;&nbsp;STATE:             </td>
                  
            <td >
               
                <asp:DropDownList ID="select_rep_state" runat="server" CssClass="textbox" 
                    DataSourceID="ds_RepState" DataTextField="name" DataValueField="ID" >
                </asp:DropDownList>
                <asp:SqlDataSource ID="ds_RepState" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:cldConnectionString %>" 
                    
                    SelectCommand="SELECT DISTINCT ID, name, countryID FROM state WHERE (countryID = 160)">
                    
                </asp:SqlDataSource>                 
                           
                            
            </td>
            </tr>
            <tr>
            <td >
                &nbsp;&nbsp;ADDRESS :
            </td>
            <td >
                <asp:TextBox ID="txt_rep_address" runat="server" Width="400px" CssClass="textbox" 
                    Height="80px" TextMode="MultiLine"></asp:TextBox>               
            </td>
            </tr>
            <tr>
            <td>
              &nbsp;&nbsp;TELEPHONE: &nbsp;</td>
            <td >
            <asp:TextBox ID="txt_rep_telephone" runat="server" Width="200px" CssClass="textbox" ></asp:TextBox>
                </td>
            </tr>
            <tr>
            <td>
                &nbsp;&nbsp;E-MAIL:
                </td>
            <td >
            <asp:TextBox ID="txt_rep_email" runat="server" Width="200px" CssClass="textbox" ></asp:TextBox>
                   </td>
            </tr>
              
                <tr>
                    <td align="center" colspan="3" style="color:Red; font-size:16px;">
                        <strong>
                        NOTE: ALL ATTACHMENTS SHOULD BE OF PDF FORMAT FOR &quot;DOCUMENTS&quot; AND JPEG FORMAT 
                        FOR &quot;REPRESENTATIONS OF DESIGNS&quot; ONLY.<br />
&nbsp;DOCUMENTS AND REPRESENTATIONS SHOULD NOT EXCEED 3MB EACH!!</strong></td>
                </tr>
                <tr style="background-color:#999999;">
                    <td align="left" class="tbbg_left2" style="width:25%;">
                        &nbsp;ITEMS</td>
                    <td align="left" class="tbbg_left2" colspan="2">
                        ATTACH DOCUMENT</td>
                </tr>
                
                <tr>
                    <td align="left">
                        &nbsp;LETTER OF AUTHORIZATION OF AGENT(FORM 2) :
                    </td>
                    <td align="left" colspan="2">
                          <Upload:InputFile ID="fu_loa_doc" runat="server"  CssClass="textbox"/>
                         <asp:RegularExpressionValidator id="RegularExpressionLoa" 
				ControlToValidate="fu_loa_doc" ValidationExpression="(([^.;]*[.])+(pdf|PDF); *)*(([^.;]*[.])+(pdf|PDF))?$"
				Display="Static" ErrorMessage="DOCUMENTS ATTACHED SHOULD BE OF PDF!!"
				EnableClientScript="True"  runat="server"/>
                        </td>
                </tr>               
                

                  <tr>
                    <td align="left">
                        &nbsp;DEED OF ASSIGNMENT:</td>
                    <td align="left" colspan="2">
                         <Upload:InputFile ID="fu_doa_doc" runat="server"  CssClass="textbox"/>
                         <asp:RegularExpressionValidator id="RegularExpressionDoa" 
				ControlToValidate="fu_doa_doc" ValidationExpression="(([^.;]*[.])+(pdf|PDF); *)*(([^.;]*[.])+(pdf|PDF))?$"
				Display="Static" ErrorMessage="DOCUMENTS ATTACHED SHOULD BE OF PDF!!"
				EnableClientScript="True"  runat="server"/></td>
                </tr>

                 
               
                <tr>
                    <td align="left">
                        &nbsp;NOVELTY STATEMENT :
                    </td>
                    <td align="left" colspan="2">
                        <Upload:InputFile ID="fu_ns_doc" runat="server" CssClass="textbox" />
                         <asp:RegularExpressionValidator id="RegularExpressionNs" 
				ControlToValidate="fu_ns_doc" ValidationExpression="(([^.;]*[.])+(pdf|PDF); *)*(([^.;]*[.])+(pdf|PDF))?$"
				Display="Static" ErrorMessage="DOCUMENTS ATTACHED SHOULD BE OF PDF!!"
				EnableClientScript="True"  runat="server"/>
                        </td>
                </tr>  
               
                
                  <tr>
                    <td align="left">
                        &nbsp;PRIORITY DOCUMENT:</td>
                    <td align="left" colspan="2">
                         <Upload:InputFile ID="fu_pd_doc" runat="server" CssClass="textbox" />
                         <asp:RegularExpressionValidator id="RegularExpressionPd" 
				ControlToValidate="fu_pd_doc" ValidationExpression="(([^.;]*[.])+(pdf|PDF); *)*(([^.;]*[.])+(pdf|PDF))?$"
				Display="Static" ErrorMessage="DOCUMENTS ATTACHED SHOULD BE OF PDF!!" EnableClientScript="True"  runat="server"/></td>
                </tr>

              
                <tr>
                    <td align="left">
                        &nbsp;REPRESENTATION OF DESIGN 1: 
                    </td>
                    <td align="left" colspan="2">
                        <Upload:InputFile ID="fu_rep_doc" runat="server" CssClass="textbox" />
                         <asp:RegularExpressionValidator id="RegularExpressionRep" 
				ControlToValidate="fu_rep_doc" ValidationExpression="(([^.;]*[.])+(jpg|jpeg); *)*(([^.;]*[.])+(jpg|jpeg))?$"
				Display="Static" ErrorMessage="DOCUMENTS ATTACHED SHOULD BE OF JPG"	EnableClientScript="True"  runat="server"/>
                        </td>
                </tr>

                 <tr>
                    <td align="left">
                        REPRESENTATION OF DESIGN 2:
                    </td>
                    <td align="left" colspan="2">
                         <Upload:InputFile ID="fu_rep2_doc" runat="server"  CssClass="textbox"/>
                         <asp:RegularExpressionValidator id="RegularExpressionRep2" 
				ControlToValidate="fu_rep2_doc" ValidationExpression="(([^.;]*[.])+(jpg|jpeg); *)*(([^.;]*[.])+(jpg|jpeg))?$"
				Display="Static" ErrorMessage="DOCUMENTS ATTACHED SHOULD BE OF JPG!!"
				EnableClientScript="True"  runat="server"/></td>
                </tr>
                <tr>
                    <td align="left">
                        REPRESENTATION OF DESIGN 3:
                    </td>
                    <td align="left" colspan="2">
                         <Upload:InputFile ID="fu_rep3_doc" runat="server"  CssClass="textbox"/>
                         <asp:RegularExpressionValidator id="RegularExpressionRep3" 
				ControlToValidate="fu_rep3_doc" ValidationExpression="(([^.;]*[.])+(jpg|jpeg); *)*(([^.;]*[.])+(jpg|jpeg))?$"
				Display="Static" ErrorMessage="DOCUMENTS ATTACHED SHOULD BE OF JPG!!"
				EnableClientScript="True"  runat="server"/></td>
                </tr>
                <tr>
                    <td align="left">
                        REPRESENTATION OF DESIGN 4:
                    </td>
                    <td align="left" colspan="2">
                         <Upload:InputFile ID="fu_rep4_doc" runat="server"  CssClass="textbox"/>
                         <asp:RegularExpressionValidator id="RegularExpressionRep4" 
				ControlToValidate="fu_rep4_doc" ValidationExpression="(([^.;]*[.])+(jpg|jpeg); *)*(([^.;]*[.])+(jpg|jpeg))?$"
				Display="Static" ErrorMessage="DOCUMENTS ATTACHED SHOULD BE OF JPG!!"
				EnableClientScript="True"  runat="server"/></td>
                </tr>
                
               
                <tr>
                    <td colspan="3" align="center">
                          <Upload:ProgressBar id="pb_all_doc" runat="server" inline="true" Text="" /></td>
                </tr>

            <tr>
                <td colspan="2" align="center">
            
                 <%--<asp:Button ID="SaveAll" runat="server" Text="Submit Application"  class="button" 
                    onclick="SaveAll_Click" />--%>

                     <asp:Button ID="Button2" runat="server" Text="Submit Application"  class="button" 
                    onclick="SaveAll_Click" />
                </td>
            </tr>           
            </table>
            
    
    </div>
    </td>
    </tr>
    </table>

</asp:Panel>
<asp:Panel ID="tt3" runat="server" Visible="false">
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
                   <div style="font-size:20px;"><strong>DESIGN ACKNOWLEDGMENT FORM</strong></div> 
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
         <%             for (int app = 0; app < lt_app2.Count; app++)
             {%>
        <tr>
            <td align="left" colspan="2" style="background-color:#999999;">
                <strong>APPLICANT <%=app + 1%>>></strong></td>
        </tr>
        
        <tr>
            <td align="right">
                NAME :</td>
                <td>
                    <% Response.Write(lt_app2[app].xname); %></td>
        </tr>
        
        <tr>
            <td align="right">
                ADDRESS :</td>
                <td>
                    <% Response.Write(lt_app2[app].address); %></td>
        </tr>
        
        <tr>
            <td align="right">
                PHONE NUMBER :
            </td>
                <td>
                    <% Response.Write(lt_app2[app].xmobile); %></td>
        </tr>
        
        <tr>
            <td align="right">
                E-MAILS :</td>
                <td>
                    <% Response.Write(lt_app2[app].xemail); %></td>
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
        <%   for (int inv = 0; inv < lt_inv2.Count; inv++)
               {%>
        <tr>
            <td align="left" colspan="2" style="background-color:#999999;">
                <strong>CREATOR <%=inv+1%>>></strong></td>
        </tr>
        
        <tr>
            <td align="right">
                NAME :</td>
                <td>
                    <% Response.Write(lt_inv2[inv].xname); %></td>
        </tr>
        
        <tr>
            <td align="right">
                ADDRESS :</td>
                <td>
                    <% Response.Write(lt_inv2[inv].address); %></td>
        </tr>
        
        <tr>
            <td align="right">
                PHONE NUMBER :
            </td>
                <td>
                    <% Response.Write(lt_inv2[inv].xmobile); %></td>
        </tr>
        
        <tr>
            <td align="right">
                E-MAILS :</td>
                <td>
                    <% Response.Write(lt_inv2[inv].xemail); %></td>
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
              { %>ATTACHED<%} %></td>
        </tr>        
        <tr>
            <td align="right">
                NOVELTY STATEMENT :</td>
            <td >
                <%if (lt_mi[0].ns_doc == "")
                  { %> NOT ATTACHED<%}
                  else
                  { %>ATTACHED<%} %></td>
        </tr>        
        <tr>
            <td align="right">
                NOVELTY STATEMENT :</td>
            <td >
                  <%if (lt_mi[0].ns_doc == "")
                    { %> NOT ATTACHED<%}
                    else
                    { %>ATTACHED<%} %></td>
        </tr>
        <tr>
            <td align="right">
               PRIORITY DOCUMENT :
            </td>
            <td >
            <%if (lt_mi[0].pd_doc == "")
              { %> NOT ATTACHED<%}
              else
              { %>ATTACHED<%} %></td>
        </tr>        
        <tr>
            <td align="right">
                REPRESENTATION OF DESIGN 1 :</td>
            <td >
                <%if ((lt_mi[0].rep_pic == "") && (lt_mi[0].rep_pic == "0"))
                  { %> NOT ATTACHED<%}
                  else
                  { %><img src="<%="admin/pt/"+lt_mi[0].rep_pic  %>" height="50%"  width="50%" alt="" /><%} %></td>
        </tr>        
        <tr>
            <td align="right">
                REPRESENTATION OF DESIGN 2 :</td>
            <td >
                  <%if ((lt_mi[0].rep2_pic == "") && (lt_mi[0].rep2_pic == "0"))
                    { %> NOT ATTACHED<%}
                    else
                    { %><img src="<%="admin/pt/"+lt_mi[0].rep2_pic  %>" height="50%"  width="50%" alt="" /><%} %></td>
        </tr>
        <tr>
            <td align="right">
               REPRESENTATION OF DESIGN 3 :
            </td>
            <td >
            <%if ((lt_mi[0].rep3_pic == "") && (lt_mi[0].rep3_pic == "0"))
              { %> NOT ATTACHED<%}
              else
              { %><img src="<%="admin/pt/"+lt_mi[0].rep3_pic  %>" height="50%"  width="50%" alt="" /><%} %></td>
        </tr>
        <tr>
            <td align="right">
                REPRESENTATION OF DESIGN 4:</td>
            <td >
                  <%if ((lt_mi[0].rep4_pic == "") && (lt_mi[0].rep4_pic == "0"))
                    { %> NOT ATTACHED<%}
                    else
                    { %><img src="<%="admin/pt/"+lt_mi[0].rep4_pic  %>" height="50%"  width="50%" alt="" /><%} %></td>
        </tr>
        
        <%}%>
        <tr>
            <td class="tbbg" colspan="2" style="color: #fff; background-color: #006600; text-align: center; font-weight: bold;">
              
                &nbsp;</td>
        </tr>
        <tr>
            <td  align="center" colspan="2">
              <strong>YOUR APPLICATION HAS BEEN RECEIVED AND IS RECEIVING DUE ATTENTION</strong><br />
             <strong>TRADEMARKS, PATENTS AND DESIGNS REGISTRY 
                <br />
                COMMERCIAL LAW DEPARTMENT
                <br />
                FEDERAL MINISTRY OF INDUSTRY, TRADE AND INVESTMENT
                </strong>
                </td>
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

</asp:Panel>
        </div>
    </div>
</div>
</div>

    </form>
</body>
</html>
