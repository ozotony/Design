using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_pt_rejection_slip_details : System.Web.UI.Page
{
    public string admin = "";
    public string admin_status;
    public List<pt.Stage> lt_p = new List<pt.Stage>();
    public List<zues.Adminz> lt_tm_admin_details = new List<zues.Adminz>();
    public List<zues.PtOffice> lt_tm_office = new List<zues.PtOffice>();
    public List<pt.Applicant> lt_app = new List<pt.Applicant>();
    public List<pt.PtInfo> lt_mi = new List<pt.PtInfo>();
    public List<pt.Representative> lt_rep = new List<pt.Representative>();
    public List<pt.Stage> lt_stage = new List<pt.Stage>();
    public List<pt.Assignment_info> lt_assinfo = new List<pt.Assignment_info>();
    public List<pt.Inventor> lt_inv = new List<pt.Inventor>();
    public List<pt.Priority_info> lt_xpri = new List<pt.Priority_info>();
    public string pID;
    public string rbval_text = "";
    public string search_doc_succ1 = "";
    public string search_doc_succ2 = "";
    public string search_doc_succ3 = "";
    public string succ = "";
    public pt t = new pt();
    public string xofficer;
    public string xreason = "";
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
                    base.Response.Redirect("./lo.aspx");
                }
            }
            else
            {
                base.Response.Redirect("./lo.aspx");
            }
            this.pID = this.t.getPwalletIDByMID(base.Request.QueryString["x"].ToString());
            this.lt_p = this.t.getPwalletDetailsByID(this.pID);
            this.lt_stage = this.t.getStageByUserID(this.pID);
            this.lt_mi = this.t.getPtInfoByUserID(this.pID);
            this.lt_app = this.t.getApplicantByvalidationID(this.pID);
            this.lt_rep = this.t.getRepListByUserID(this.pID);
            this.lt_inv = this.t.getInventorByvalidationID(this.pID);
            this.lt_assinfo = this.t.getAssignment_infoByvalidationID(this.pID);
            this.lt_xpri = this.t.getPriority_infoByvalidationID(this.pID);
            this.lt_tm_office = this.z.getPtOfficeDetailsByID(this.pID);
            this.lt_tm_admin_details = this.z.getTmAdminDetailsByID(this.lt_tm_office[0].xofficer);
            xreason = lt_tm_office[lt_tm_office.Count - 1].xcomment;
        }
        else
        {
            base.Response.Redirect("./rejection_slip.aspx");
        }
    }
}