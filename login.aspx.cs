using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    public string adminID = "0";
    public string code_text = "";
    public string email_text = "";
    public string enable_Captcha = "1";
    public string enable_Confirm = "0";
    public string enable_Save = "1";
    public string newp = "0";
    public string newState = "0";
    public string password_text = "";
    public static string server_url = "";
    public static string remote_host = "";
    public static string remote_user = "";
    public static string server_name = "";
    public static string OriginalIP = "";
    public static string RemoteIP = "";
    public string serverpath = "";
    public zues z = new zues();
    public Odyssey ody = new Odyssey(); 

    protected void ConfirmDetails_Click(object sender, EventArgs e)
    {
        int num = 0;
        if (this.xemail.Text == "")
        {
            this.email_text = "1";
            num++;
        }
        if (this.xcode.Text == "")
        {
            this.code_text = "1";
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
        if (Session["Captcha"] != null)
        {
            str = Session["Captcha"].ToString();
        }
        if (str == this.xcode.Text.ToUpper())
        {
            this.newState = "0";
            this.enable_Save = "0";
            this.enable_Confirm = "1";
            this.enable_Captcha = "0";
            this.newp = "1";
        }
        else
        {
            this.newState = "1";
            this.xcode.Text = "";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        this.serverpath = base.Server.MapPath("~/");
        string ClientIP = GetClientIPAddress(Context.Request);
    }

    protected void Save_Click(object sender, EventArgs e)
    {
        if (this.xpassword.Text != "")
        {
            this.password_text = this.xpassword.Text;
        }
        Odyssey ody = new Odyssey();
        this.adminID = this.z.a_xadminz(this.xemail.Text, this.xpassword.Text, serverpath);

        string str = this.z.getRoleByID(this.adminID);
        if (this.adminID != "0")
        {
            string succ = z.addAdminLog(str, RemoteIP, remote_host, remote_user, server_name, server_url);
            if (succ != "")
            {
                Session["pwalletID"] = this.adminID;
                switch (str)
                {
                    case "1":
                        base.Response.Redirect("./admin/pt/x_unit/profile.aspx");
                        break;

                    case "2":
                        base.Response.Redirect("./admin/pt/search_unit/profile.aspx");
                        break;

                    case "3":
                        base.Response.Redirect("./admin/pt/verification_unit/profile.aspx");
                        break;                   

                    case "5":
                        base.Response.Redirect("./admin/pt/examiners_unit/profile.aspx");
                        break;

                    //case "5":
                    //    base.Response.Redirect("./admin/pt/examiner1_unit/profile.aspx");
                    //    break;

                    case "6":
                        base.Response.Redirect("./admin/pt/examiner2_unit/profile.aspx");
                        break;

                    case "10":
                        base.Response.Redirect("./admin/pt/registrar_unit/profile_index.aspx");
                        return;                   
                }
            }
            else
            {
                base.Response.Redirect("./login.aspx");
            }
        }

    }

    protected void xpassword_Unload(object sender, EventArgs e)
    {
        this.password_text = this.xpassword.Text;
    }

    public static string GetClientIPAddress(System.Web.HttpRequest httpRequest)
    {
        OriginalIP = "Proxy IP: " + httpRequest.ServerVariables["HTTP_X_FORWARDED_FOR"]; //original IP will be updated by Proxy/Load Balancer.
        RemoteIP = "Remote IP: " + httpRequest.ServerVariables["LOCAL_ADDR"]; //Proxy/Load Balancer IP or original IP if no proxy was used
        remote_host = "Remote Host: " + httpRequest.ServerVariables["REMOTE_HOST"];
        remote_user = "User Agent: " + httpRequest.UserAgent;
        server_name = "UserHostName: " + httpRequest.UserHostName;
        server_url = "UserHostAddress: " + httpRequest.UserHostAddress;

        if (OriginalIP != null && OriginalIP.Trim().Length > 0)
        {
            return OriginalIP + "(" + RemoteIP + ")"; //Lets return both the IPs.
        }

        return RemoteIP;
    }
}