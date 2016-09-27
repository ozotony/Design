using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;

public partial class admin_pt_search_unit_profile : Page
{
    public string adminID = "";
    public long lt_mi_n = 0L;
    public long lt_mi_r = 0L;
    public zues z = new zues();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.Session["pwalletID"] != null)
        {
            if (this.Session["pwalletID"].ToString() != "")
            {
                this.adminID = this.Session["pwalletID"].ToString();
            }
            else
            {
                base.Response.Redirect("../lo.aspx");
            }
        }
        this.lt_mi_n = this.z.getPtInfoRSCnt("2", "valid");
        this.lt_mi_r = this.z.getPtInfoRSCnt("2", "Reconduct search");
    }

   
}

