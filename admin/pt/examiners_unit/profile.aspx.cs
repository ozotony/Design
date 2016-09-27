using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_pt_examiners_unit_profile : System.Web.UI.Page
{
    public string adminID = "";
    public Int64 lt_mi = 0;
    public Int64 lt_mi_r = 0;
    public Int64 lt_mi_ra = 0;
    public Int64 lt_mi_a = 0;
    public Int64 lt_mi_Kiv = 0;
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
      //  lt_mi = this.z.getPtInfoRSCnt("2", "Valid") + this.z.getPtInfoRSCnt("3", "Registrable");

      //  lt_mi =  this.z.getPtInfoRSCnt("3", "Registrable");
        lt_mi = this.z.getPtInfoRSCnt("3", "Search Conducted");
        lt_mi_a = this.z.getPtInfoRSCnt("3", "Accepted");
        lt_mi_ra = this.z.getPtInfoRSCnt("3", "Refused");
        lt_mi_Kiv = this.z.getPtInfoRSCnt("3", "Kiv");

        lt_mi_r = this.z.getPtInfoRSCnt("3", "Re-examine");
    }
}