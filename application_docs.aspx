<%@ Page Language="C#" AutoEventWireup="true" CodeFile="application_docs.aspx.cs" Inherits="application_docs" MaintainScrollPositionOnPostback="true" %>

<%@ Register assembly="Brettle.Web.NeatUpload" namespace="Brettle.Web.NeatUpload" tagprefix="Upload" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DESIGN APPLICATION</title>
<style type="text/css">
		.ProgressBar {
			margin: 0px;
			border: 0px;
			padding: 0px;
			width: 100%;
			height: 3em;
		}
		</style>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link rel="stylesheet" href="css/jquery.ui.all.css" type="text/css"/>
<link rel="stylesheet" href="css/jquery.ui.theme.css" type="text/css"/>

<script src="js/funk.js" type="text/javascript"></script>
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
</head>
<body>
    <form id="form1" runat="server">
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
           <td colspan="3">                       
            <table style="width:100%;font-family:Calibri;" id="doc_tbl" align="center">
            <tr>
                    <td class="tbbg" colspan="3">                       
                        &nbsp;</td>
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
				ControlToValidate="fu_rep4_doc" ValidationExpression="(([^.;]*[.])+(jpg|jpeg); *)*(([^.;]*[.])+(jpg|jpeg))?$"
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
                    <td align="left">
                        &nbsp;</td>
                    <td align="left">
                        &nbsp;</td>
                    <td align="left">
                    <%if (ack_status == "0")
                      { %>
                          <asp:Button ID="btn_all_doc" runat="server" Text="Upload Documents"  
                            CssClass="button"/> 
                            <% }
                      else
                      { %>
                          <asp:Button ID="btn_ack" runat="server" Text="Print Acknowledgement Slip"  
                            CssClass="button" onclick="btn_ack_Click"/> 
                            <%} %>
                          </td>
                </tr>
                </table>
           
            </td>
            </tr>
            </table>
            
    
    </div>
    </td>
    </tr>
    </table>
    </form>
</body>
</html>

