using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class appstatus : System.Web.UI.Page
{
    public string agt;
    public List<pt.PtInfo> lt_mi = new List<pt.PtInfo>();
    public List<pt.Stage> lt_pw = new List<pt.Stage>();
    public pt.Representative lt_rep = new pt.Representative();
    public string r;
    public int showt;
    public string status = "N/A";
    public string data_status = "N/A";
    public pt t = new pt();
    public zues z = new zues();

    protected void BtnCheckStatus_Click(object sender, EventArgs e)
    {
        base.Response.Redirect("./appstatus.aspx?agt=" + Session["agt"].ToString());
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (base.Request.QueryString["agt"] != null)
        {
            this.agt = base.Request.QueryString["agt"].ToString();
            Session["agt"] = Request.QueryString["agt"].ToString();
        }
        else
        {
          base.Response.Redirect("http://www.iponigeria.com");
        }
        if (Session["xvid"] != null)
        {
            this.r = Session["xvid"].ToString();
        }
    }

    protected void Save_Click(object sender, EventArgs e)
    {
        if (this.xref.Text != "")
        {
            if (this.xref.Text.Contains("OAI/DS/"))
            {
                this.xref.Text = this.xref.Text.Replace("OAI/DS/", "");
            }
            this.r = this.xref.Text;
            this.lt_pw = this.t.getStageByUserIDAcc(this.xref.Text, this.agt);
            if (this.lt_pw.Count != 0)
            {
                Session["xvid"] = this.xref.Text;
                this.lt_mi = this.t.getPtInfoByUserID(this.lt_pw[0].ID);
                this.lt_rep = this.t.getRepByUserID(this.lt_pw[0].ID);
                if (this.lt_pw[0].status == "1")
                {
                    this.status = "Verification";
                    if (lt_pw[0].data_status == "Fresh") { data_status = "Untreated"; }
                    else if (lt_pw[0].data_status == "Invalid") { data_status = "Invalid"; }
                }
                
                if (this.lt_pw[0].status == "2")
                {
                    this.status = "Examiners";
                    if (lt_pw[0].data_status == "Valid") { data_status = "being processed"; }
                }
                if (this.lt_pw[0].status == "3")
                {
                    this.status = "Acceptance";
                    if (lt_pw[0].data_status == "Registrable") { data_status = "Accepted"; }
                    else if (lt_pw[0].data_status == "Refused") { data_status = "Refused"; }
                    else if (lt_pw[0].data_status == "Non-registrable") { data_status = "not-registrable"; }
                }
               
                if (this.lt_pw[0].status == "4")
                {
                    this.status = "Registrars";
                    if (lt_pw[0].data_status == "Accepted") { data_status = "being processed"; }
                }
                if (this.lt_pw[0].status == "5")
                {
                    this.status = "Registrars";
                    if (lt_pw[0].data_status == "Registered") { data_status = "being registered"; }
                }
                this.showt = 1;
            }
            else
            {
                this.status = "N/A";
            }
        }
        else
        {
            base.Response.Write("<script language=JavaScript>alert('PLEASE ENTER A VALID REFERENCE NUMBER')</script>");
        }
    }
}