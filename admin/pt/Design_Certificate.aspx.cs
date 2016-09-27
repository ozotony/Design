using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_pt_Design_Certificate : System.Web.UI.Page
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
        if (!(Page.IsPostBack))
        {
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
            Label1.Text = lt_app[0].xname;
            Label2.Text = lt_app[0].address;

            Label3.Text = lt_rep[0].xname;
            Label4.Text = lt_rep[0].address;
            Label5.Text = lt_mi[0].title_of_invention;

            DateTime dd2 = Convert.ToDateTime(lt_p[0].reg_date);

            Label6.Text = dd2.Day.ToString() + getDayFormat(dd2.Day.ToString());

          //  Label7.Text = dd2.ToString("MMMM");

           // Label7.Text = getDayFormat(dd2.Day.ToString());

            Label8.Text = dd2.ToString("MMM") + " " + dd2.Year.ToString();
            DateTime dd3 = DateTime.Now;

            Label9.Text = dd3.Day.ToString() + getDayFormat(dd3.Day.ToString());

          //  Label10.Text = dd3.ToString("MMMM");

           // Label10.Text = getDayFormat(dd3.Day.ToString());

            Label11.Text =dd3.ToString("MMM")  + " " + dd3.Year.ToString();

            Label12.Text ="RPD/D/NG/RD/"+ dd2.Year.ToString();

            Label13.Text = lt_p[0].validationID;
           
        }

    }

    protected string getDayFormat(string day)
    {
        //string new_day = "";
        //if(day.EndsWith("1")){ new_day="st";}
        //else if (day.EndsWith("2")) { new_day = "nd"; }
        //else if (day.EndsWith("3")) { new_day = "rd"; }
        //else  { new_day = "th"; }
        //return new_day;


        switch (day)
        {
            case "1":
            case "21":
            case "31":
                return "st";
            case "2":
            case "22":
                return "nd";
            case "3":
            case "23":
                return "rd";
            default:
                return "th";
        }
    }
}