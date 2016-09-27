using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_pt_Design_Akwnolgment : System.Web.UI.Page
{
    public string admin = "";
    public string admin_status;
    public List<pt.Address> lt_addy = new List<pt.Address>();
    public List<pt.AddressService> lt_addy_service = new List<pt.AddressService>();
    public List<pt.Applicant> lt_app = new List<pt.Applicant>();
    public List<zues.PtInfo> lt_mi = new List<zues.PtInfo>();
    public List<pt.Stage> lt_p = new List<pt.Stage>();
    public List<pt.Representative> lt_rep = new List<pt.Representative>();
    public List<pt.Stage> lt_stage = new List<pt.Stage>();
    public List<zues.Adminz> lt_tm_admin_details = new List<zues.Adminz>();
    public List<zues.PtOffice> lt_tm_office = new List<zues.PtOffice>();
    public List<zues.Adminz> lt_x_admin_details = new List<zues.Adminz>();
    public List<pt.Inventor> lt_inv = new List<pt.Inventor>();

    public List<pt.Assignment_info> lt_assinfo = new List<pt.Assignment_info>();

    public List<pt.Priority_info> lt_xpri = new List<pt.Priority_info>();
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
                  //  base.Response.Redirect("./lo.aspx");
                }
            }
            else
            {
              //  base.Response.Redirect("./lo.aspx");
            }
            this.pID = base.Request.QueryString["x"].ToString();
            this.lt_mi = this.z.getPtInfoByUserID(this.pID);
            this.lt_p = this.t.getPwalletDetailsByID(this.lt_mi[0].log_staff);
            
            this.lt_app = this.t.getApplicantByUserID(this.lt_mi[0].log_staff);
            this.lt_addy = this.t.getAddressByLog_staffID(this.lt_mi[0].log_staff);
            this.lt_addy_service = this.t.getAddressServiceByID(this.lt_mi[0].log_staff);
            this.lt_rep = this.t.getRepListByUserID(this.lt_mi[0].log_staff);
            this.lt_tm_office = this.z.getPtOfficeDetailsByID(this.lt_mi[0].log_staff);
            this.lt_stage = this.t.getStageByUserID(this.lt_mi[0].log_staff);

            this.pID = base.Request.QueryString["x"].ToString();

            this.lt_p = this.t.getPwalletDetailsByID(this.lt_mi[0].log_staff);



            this.lt_inv = this.t.getInventorByvalidationID(this.lt_mi[0].log_staff);
            this.lt_assinfo = this.t.getAssignment_infoByvalidationID(this.lt_mi[0].log_staff);
            this.lt_xpri = this.t.getPriority_infoByvalidationID(this.lt_mi[0].log_staff);

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

            }/////

        }
        else
        {
            base.Response.Redirect("./registrar_c.aspx");
        }
    }
}