using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_pt_registrar_unit_pt_profile : System.Web.UI.Page
{
    public string adminID = "";
    public List<zues.PtInfo> lt_mi = new List<zues.PtInfo>();
    public List<zues.PtInfo> lt_mi_c = new List<zues.PtInfo>();
    public List<zues.PtInfo> lt_mi_r = new List<zues.PtInfo>();
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
        else
        {
            base.Response.Redirect("../lo.aspx");
        }
      //  this.lt_mi = this.z.getCriRegisteredPtInfoRS("4", "Certified");

        this.lt_mi = this.z.getCriRegisteredPtInfoRS("3", "Accepted");

        
        this.lt_mi_c = this.z.getCriRegisteredPtInfoRS("5", "Registered");
        this.lt_mi_r = this.z.getCriRegisteredPtInfoRS("4", "Deferred");
    }
}