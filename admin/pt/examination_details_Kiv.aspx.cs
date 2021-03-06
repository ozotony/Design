﻿using System;
using Helper;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

public partial class admin_pt_examination_details_Kiv : System.Web.UI.Page
{
    public string admin = "";
    public string admin_status = "3";
    public List<pt.Applicant> lt_app = new List<pt.Applicant>();
    public List<pt.PtInfo> lt_mi = new List<pt.PtInfo>();
    public List<pt.Stage> lt_p = new List<pt.Stage>();
    public List<pt.Stage> lt_stage = new List<pt.Stage>();
    public List<pt.Representative> lt_rep = new List<pt.Representative>();
    public List<pt.Assignment_info> lt_assinfo = new List<pt.Assignment_info>();
    public List<pt.Inventor> lt_inv = new List<pt.Inventor>();
    public List<pt.Priority_info> lt_xpri = new List<pt.Priority_info>();
    public List<zues.PtOffice> lt_tm_office = new List<zues.PtOffice>();
    public List<zues.Adminz> lt_x_admin_details = new List<zues.Adminz>();
    public List<zues.Adminz> lt_tm_admin_details = new List<zues.Adminz>();
    public string pID;
    public string rbval_text = "";
    public string search_doc_succ1 = "";
    public string search_doc_succ2 = "";
    public string search_doc_succ3 = "";
    public string succ = "";
    public pt t = new pt();
    public string xcomments = "";
    public string xofficer;
    public zues z = new zues();

    protected void Page_Load(object sender, EventArgs e)
    {
        Verify.Visible = false;
        if (this.rbValid.SelectedValue == "Accepted")
        {
            this.admin_status = "3";
            Verify.Visible = true;
        }

        if (this.rbValid.SelectedValue == "Refused")
        {
            this.admin_status = "3";
            Verify.Visible = true;
        }

        if (this.rbValid.SelectedValue == "Kiv")
        {
            this.admin_status = "3";
            Verify.Visible = true;
        }
        else if (this.rbValid.SelectedValue == "Reconduct search")
        {
            this.admin_status = "2";
            Verify.Visible = true;
        }

        else if (this.rbValid.SelectedValue == "Further Examination")
        {
            this.admin_status = "4";
            Verify.Visible = true;
        }
        if (base.Request.QueryString["x"] != null)
        {
            if (base.Session["pwalletID"] != null)
            {
                if (base.Session["pwalletID"].ToString() != "")
                {
                    this.admin = base.Session["pwalletID"].ToString();
                }
                else
                {
                    base.Response.Redirect("./lo.aspx");
                }
            }
            else
            {
                base.Response.Redirect("./lo.aspx");
            }
            this.pID = base.Request.QueryString["x"].ToString();
            this.lt_mi = this.t.getPtInfoByUserID(this.pID);
            this.lt_p = this.t.getPwalletDetailsByID(this.lt_mi[0].log_staff);
            this.lt_tm_office = this.z.getPtOfficeDetailsByID(this.lt_mi[0].log_staff);
            this.lt_rep = this.t.getRepListByUserID(this.lt_mi[0].log_staff);
            this.lt_stage = this.t.getStageByUserID(this.lt_mi[0].log_staff);
            this.lt_app = this.t.getApplicantByvalidationID(this.lt_mi[0].log_staff);
            this.lt_inv = this.t.getInventorByvalidationID(this.lt_mi[0].log_staff);
            this.lt_assinfo = this.t.getAssignment_infoByvalidationID(this.lt_mi[0].log_staff);
            this.lt_xpri = this.t.getPriority_infoByvalidationID(this.lt_mi[0].log_staff);

            xname3.Value = lt_rep[0].xemail;

            for (int i = 0; i < this.lt_tm_office.Count; i++)
            {
                this.xcomments = this.xcomments + "<tr>";
                this.xcomments = this.xcomments + "<td align=\"center\" colspan=\"2\">";
                this.xcomments = this.xcomments + "<strong>" + this.lt_tm_office[i].xcomment.ToUpper() + "</strong><br />";
                this.lt_x_admin_details = this.z.getTmAdminDetailsByID(this.lt_tm_office[i].xofficer);
                string xcomments = this.xcomments;
                this.xcomments = xcomments + "COMMENT BY: <strong>" + this.lt_x_admin_details[0].xname.ToUpper() + "( " + this.z.getRoleNameByID(this.lt_x_admin_details[0].xroleID).ToUpper() + " UNIT)</strong><br />   Date: <strong>" + this.lt_tm_office[i].reg_date.ToUpper() + "</strong>";
                this.xcomments = this.xcomments + "</td>";
                this.xcomments = this.xcomments + "</tr>";
                this.xcomments = this.xcomments + "<tr>";
                this.xcomments = this.xcomments + "<td class=\"coltbbg\" colspan=\"2\" align=\"center\">";
                this.xcomments = this.xcomments + "&nbsp;";
                this.xcomments = this.xcomments + "</td>";
                this.xcomments = this.xcomments + "</tr>";
            }
        }
        else
        {
            base.Response.Redirect("./examiners_Kiv.aspx");
        }
    }

    protected void rbValid_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (this.rbValid.SelectedValue == "Registrable")
        {
            this.admin_status = "3";
            Verify.Visible = true;
        }

        else if (this.rbValid.SelectedValue == "Kiv")
        {
            txtName.Text = lt_rep[0].xemail;

         //   pup.ShowPopupWindow();
        }
        else
        {
            this.admin_status = "2";
            Verify.Visible = true;
        }

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        // pup.ShowPopupWindow();

     //   sendemail(TextBox1.Text, txtName.Text, txtMessage.Text);
        string ss = "aaa";
     //   comment.Visible = false;
    //    pup.HidePopupWindow();

     //   ucMessage.ShowMessage("Mail Sent Successfully", Message.Type.info.ToString());
    }
    protected void MycloseWindow(object sender, EventArgs e)
    {

    }

    public void sendemail(String vsubject, String vemail3, string vmessage)
    {
        try
        {
            int port = 0x24b;


            MailMessage mail = new MailMessage();
            mail.From =
       new MailAddress("noreply@iponigeria.com", "noreply@iponigeria.com");
            // new MailAddress("tradeservices@fsdhgroup.com");
            mail.Priority = MailPriority.High;

            mail.To.Add(
new MailAddress(vemail3));

            //    new MailAddress("ozotony@yahoo.com"));



            //mail.CC.Add(new MailAddress("Anthony.Ozoagu@firstcitygroup.com"));

            mail.Subject = vsubject;

            mail.IsBodyHtml = true;
            //String ss2 = "Dear " + px2.CompanyName + ",<br/> <br/>" + " This is to inform you that your application has been refused!! Please contact our personnel for further details .<br/> <br/>";

            ////  ss2 = ss2 + "To gain access to your account, you would need to click here <a href=\"http://88.150.164.30/IpoTest2/#/Register/" + vid + " \">click</a>   to validate your account and also make payment. " + "<br/><br/><br/>";
            //ss2 = ss2 + "Please do not reply this mail. <br/> <br/>";



            //ss2 = ss2 + "Email: info@iponigeria.com or go online to use our live feedback form <br/> <br/>";



            //ss2 = ss2 + "<b> Disclaimer: </b>This e-mail and any attachments are confidential; it must not be read, copied, disclosed or used by any person other than the above named addressees. Unauthorized use, disclosure or copying is strictly prohibited and may be unlawful. Iponigeria.com disclaims any liability for any action taken in reliance on the content of this e-mail. The comments or statements expressed in this e-mail could be personal opinions and are not necessarily  those of iponigeria.com. If you have received this email in error or think you may have done so, you may not peruse, use, disseminate, distribute or copy this message. Please notify the sender immediately and delete the original e-mail from your system.";












            //String ss = "<html> <head> </head> <body>" + ss2 + "</body> </html>";

            //  mail.Body = ss;

            mail.Body = vmessage;

            SmtpClient client = new SmtpClient("88.150.164.30");
            //  SmtpClient client = new SmtpClient("192.168.0.12");

            client.Port = port;

            //    client.Credentials = new System.Net.NetworkCredential("paymentsupport@einaosolutions.com", "Zues.4102.Hector");

            client.Credentials = new System.Net.NetworkCredential("noreply@iponigeria.com", "Einao2015@@$");



            //   new System.Net.NetworkCredential("ebusiness@firstcitygroup.com", "welcome@123");
            //   new System.Net.NetworkCredential(q60.smtp_user, q60.smtp_password);







            client.Send(mail);

        }
        catch (Exception ee)
        {


        }



    }

    protected void Verify_Click(object sender, EventArgs e)
    {
        this.succ = this.z.a_tm_office(lt_mi[0].log_staff, admin_status, this.rbValid.SelectedValue, this.comment.Text, "", "", "", this.admin);
        if (this.succ != "0")
        {
            base.Response.Write("<script language=JavaScript>alert('Data updated successfully')</script>");
            base.Response.Redirect("./examiners_Kiv.aspx");
        }
        else
        {
            base.Response.Write("<script language=JavaScript>alert('Data not verified, Please try again later')</script>");
        }
    }
}