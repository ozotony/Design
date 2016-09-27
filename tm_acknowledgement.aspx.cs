using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class tm_acknowledgement : System.Web.UI.Page
{
    public string aid = "";
    public string amt = "";
    public string gt = "";
    public List<pt.Applicant> lt_app = new List<pt.Applicant>();
    public List<pt.PtInfo> lt_mi = new List<pt.PtInfo>();
    public List<pt.Representative> lt_rep = new List<pt.Representative>();
    public List<pt.Stage> lt_stage = new List<pt.Stage>();

    public List<pt.Assignment_info> lt_assinfo = new List<pt.Assignment_info>();
    public List<pt.Inventor> lt_inv = new List<pt.Inventor>();
    public List<pt.Priority_info> lt_xpri = new List<pt.Priority_info>();

    public string pwalletID = "";
    public pt t = new pt();
    public string validationID = "";
    public string vid = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if ((base.Request.QueryString["0001234445XXX43943OPFDSMZXUHSJFDSKFGKSDKGFSDKFSKFDKFD"] != null)&&(base.Request.QueryString["0001234445XXX43943OPFDSMZXUHSJFDSKFGKSDKGFSDKFSKFDKFD"].ToString() != ""))
        {
            this.vid = base.Request.QueryString["0001234445XXX43943OPFDSMZXUHSJFDSKFGKSDKGFSDKFSKFDKFD"].ToString();
            if (this.vid.Contains("OAI/DS/"))
            {
                this.vid = this.vid.Replace("OAI/DS/", "");
            }
            this.pwalletID = this.t.getPwalletID(this.vid);
            if (this.pwalletID != "")
            {
                this.lt_mi = this.t.getPtInfoByPwalletID(this.pwalletID);
                this.lt_rep = this.t.getRepListByUserID(this.pwalletID);
                this.lt_stage = this.t.getStageByUserID(this.pwalletID);
                this.lt_app = this.t.getApplicantByvalidationID(this.pwalletID);
                this.lt_inv = this.t.getInventorByvalidationID(this.pwalletID);
                this.lt_assinfo = this.t.getAssignment_infoByvalidationID(this.pwalletID);
                this.lt_xpri = this.t.getPriority_infoByvalidationID(this.pwalletID);

                Session["xserviceaddress"] = null;
                Session["xrepresentative"] = null;
                Session["xmarkinfo"] = null;
                Session["xapplication"] = null;
                Session["vid"] = null;
                Session["amt"] = null;
                Session["aid"] = null;
                Session["g"] = null;
                Session["pc"] = null;
                Session["new_ptID"] = null;
                Session["loa_newfilename"] = null;
                Session["claim_newfilename"] = null;
                Session["pct_newfilename"] = null;
                Session["doa_newfilename"] = null;
                Session["spec_newfilename"] = null;
                Session["txt_loa_no"] = null ;
                Session["txt_claim_no"] = null ;
                Session["txt_pct_no"] = null;
                Session["txt_doa_no"] = null;
            }
        }
        else
        {
          //  base.Response.Redirect("http://www.iponigeria.com");
        }        

       
    }
}