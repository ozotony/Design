using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.IO;

public partial class admin_pt_x_unit_admin_registration : System.Web.UI.Page
{
    public zues.Adminz ad = new zues.Adminz();
    public string admin = "";
    public DataSet ds = new DataSet();
    public string edit_email_text = "";
    public string edit_name_text = "";
    public string edit_telephone1_text = "";
    public string edit_telephone2_text = "";
    public string edit_xcode_text = "";
    public string email_text = "";
    public string enable_Captcha = "1";
    public string enable_Confirm = "0";
    public string enable_EditTbl = "1";
    public string enable_Save = "1";
    public string name_text = "";
    public int newState;
    public string pwalletID = "1";
    public string regID = "0";
    public string telephone1_text = "";
    public string telephone2_text = "";
    public string vID = "";
    public int x_add_succ;
    public int x_add_tbl = 1;
    public int x_del_succ;
    public int x_del_tbl = 1;
    public int x_edit_succ;
    public int x_edit_tbl = 1;
    public string xcode_text = "";
    public string xType = "0";
    public string serverpath = "";
    public string file_string = "Xavier";
    public int file_len = 1024;
    public zues z = new zues();
    public Odyssey ody = new Odyssey();
    protected void btn_menu_Click(object sender, EventArgs e)
    {
        this.x_add_tbl = 1;
        this.x_add_succ = 0;
    }

    protected void ConfirmDetails_Click(object sender, EventArgs e)
    {
        int num = 0;
        if (this.xemail.Text == "")
        {
            this.email_text = "1";
            num++;
        }
        if (this.xname.Text == "")
        {
            this.name_text = "1";
            num++;
        }
        if (num != 0)
        {
            base.Response.Write("<script language=JavaScript>alert('Please fill in the marked fileds')</script>");
        }
        else
        {
            this.doCaptcha();
        }
    }

    protected void doCaptcha()
    {
        string str = "";
        if (this.Session["Captcha"] != null)
        {
            str = this.Session["Captcha"].ToString();
        }
        if (str == this.xcode.Text.ToUpper())
        {
            this.newState = 0;
            this.enable_Save = "0";
            this.enable_Confirm = "1";
            this.enable_Captcha = "0";
        }
        else
        {
            this.newState = 1;
            this.xcode.Text = "";
        }
    }

    protected void EditBack_Click(object sender, EventArgs e)
    {
        //this.x_edit_tbl = 1;  this.x_edit_succ = 0;
        base.Response.Redirect("./admin_registration.aspx");
    }

    protected void EditRefresh_Click(object sender, EventArgs e)
    {
        base.Response.Redirect("./admin_registration.aspx");
    }

    protected void EditSave_Click(object sender, EventArgs e)
    {
        string keydir = serverpath + "\\Handlers\\bf.pke";
        if (File.Exists(keydir))
        {
            StreamReader streamReader = new StreamReader(keydir, true);
            file_string = streamReader.ReadToEnd();
            streamReader.Close();
            if (file_string != null)
            {
                string bitStrengthString = file_string.Substring(0, file_string.IndexOf("</BitStrength>") + 14);
                file_string = file_string.Replace(bitStrengthString, "");
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        if (this.z.e_regadmin(this.edit_xname.Text, ody.EncryptString(this.edit_xpass.Text, file_len, file_string), this.edit_xrole.SelectedValue, ody.EncryptString(this.edit_xemail.Text, file_len, file_string), this.edit_telephone1.Text, this.edit_telephone2.Text, "ds", this.pwalletID, this.getAdmins.SelectedValue, this.edit_status.SelectedValue) > 0)
        {
            this.x_edit_tbl = 0;
            this.x_edit_succ = 1;
        }
    }

    protected void getAdmins_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.ad = this.z.getAdminDetails(this.getAdmins.SelectedValue);
        this.edit_xname.Text = this.ad.xname;
        this.edit_xpass.Text = ody.DecryptString(this.ad.xpass, file_len, file_string);
        this.edit_xemail.Text = ody.DecryptString(this.ad.xemail, file_len, file_string);
        this.edit_telephone1.Text = this.ad.xtelephone1;
        this.edit_telephone2.Text = this.ad.xtelephone2;
        this.edit_xrole.SelectedIndex = Convert.ToInt16(z.getAdmiPriv(this.ad.xroleID)) - 1;
        this.edit_status.SelectedIndex = Convert.ToInt16(this.ad.xvisible);
        this.enable_EditTbl = "1";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        this.serverpath = base.Server.MapPath("~/");
        string keydir = serverpath + "Handlers\\bf.kez";
        if (File.Exists(keydir))
        {
            StreamReader streamReader = new StreamReader(keydir, true);
            file_string = streamReader.ReadToEnd();
            streamReader.Close();
            if (file_string != null)
            {
                string bitStrengthString = file_string.Substring(0, file_string.IndexOf("</BitStrength>") + 14);
                file_string = file_string.Replace(bitStrengthString, "");
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        if (this.Session["pwalletID"] != null)
        {
            if (this.Session["pwalletID"].ToString() != "")
            {
                this.admin = this.Session["pwalletID"].ToString();
            }
            else
            {
                base.Response.Redirect("../lo.aspx");
            }
        }
        else
        {
            base.Response.Redirect("../lo.aspx");
        }
        if (!base.IsPostBack)
        {

            this.ad = this.z.getTopAdminDetails();
            this.edit_xname.Text = this.ad.xname;
            this.edit_xpass.Text = ody.DecryptString(this.ad.xpass, file_len, file_string);
            this.edit_xemail.Text = ody.DecryptString(this.ad.xemail, file_len, file_string);
            this.edit_telephone1.Text = this.ad.xtelephone1;
            this.edit_telephone2.Text = this.ad.xtelephone2;
            this.edit_xrole.SelectedIndex = Convert.ToInt16(z.getAdmiPriv(this.ad.xroleID)) - 1;
            this.edit_status.SelectedIndex = Convert.ToInt16(this.ad.xvisible);
        }
    }

    protected void Save_Click(object sender, EventArgs e)
    {
        string keydir = serverpath + "\\Handlers\\bf.pke";
        if (File.Exists(keydir))
        {
            StreamReader streamReader = new StreamReader(keydir, true);
            file_string = streamReader.ReadToEnd();
            streamReader.Close();
            if (file_string != null)
            {
                string bitStrengthString = file_string.Substring(0, file_string.IndexOf("</BitStrength>") + 14);
                file_string = file_string.Replace(bitStrengthString, "");
            }
        }

        int len = xtelephone1.Text.Length;
        string pass = this.xtelephone1.Text.Remove(0, len - 4);
        this.regID = this.z.a_regadmin(this.xname.Text, this.xrole.SelectedValue, ody.EncryptString(this.xemail.Text, file_len, file_string), this.xtelephone1.Text, this.xtelephone2.Text, "ds", this.pwalletID, ody.EncryptString(pass, file_len, file_string));
        if (this.regID != "0")
        {
            this.x_add_tbl = 0;
            this.x_add_succ = 1;
        }
    }
}