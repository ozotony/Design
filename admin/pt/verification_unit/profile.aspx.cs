using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_pt_verification_unit_profile : System.Web.UI.Page
{
    public string adminID = "";
    public Int64 lt_mi = 0;
    public Int64 lt_mi2 = 0;
    public Int64 lt_mi3 = 0;
    public zues z = new zues();

    protected void Page_Load(object sender, EventArgs e)
    {
      //  ucMessage.ShowMessage("Click on the buttons to show different messages. ", Message.Type.info.ToString());
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

        lt_mi = this.z.getPtInfoRSCnt("1", "Fresh");

        lt_mi2 = this.z.getPtInfoRSCnt("1", "Invalid");

        lt_mi3 = this.z.getPtInfoRSCnt("1", "Kiv");


    }
}