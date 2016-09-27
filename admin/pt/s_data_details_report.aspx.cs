﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_pt_s_data_details_report : System.Web.UI.Page
{
    public string admin = "";
    public string admin_status = "";
    public List<pt.Applicant> lt_app = new List<pt.Applicant>();
    public List<pt.Assignment_info> lt_assinfo = new List<pt.Assignment_info>();
    public List<pt.Inventor> lt_inv = new List<pt.Inventor>();
    public List<pt.PtInfo> lt_mi = new List<pt.PtInfo>();
    public List<pt.Stage> lt_p = new List<pt.Stage>();
    public List<pt.Representative> lt_rep = new List<pt.Representative>();
    public List<pt.Stage> lt_stage = new List<pt.Stage>();
    public List<zues.Adminz> lt_tm_admin_details = new List<zues.Adminz>();
    public List<zues.PtOffice> lt_tm_office = new List<zues.PtOffice>();
    public List<zues.Adminz> lt_x_admin_details = new List<zues.Adminz>();
    public List<pt.Priority_info> lt_xpri = new List<pt.Priority_info>();
    public string pID;
    public pt t = new pt();
    public zues z = new zues();

     
        protected void Page_Load(object sender, EventArgs e)
        {
            this.pID = base.Request.QueryString["x"].ToString();
            this.lt_mi = this.t.getPtInfoByUserID(this.pID);
            this.lt_p = this.t.getPwalletDetailsByID(this.lt_mi[0].log_staff);

            this.lt_tm_office = this.z.getPtOfficeDetailsByID(this.lt_mi[0].log_staff);

           
            this.lt_rep = this.t.getRepListByUserID(this.lt_mi[0].log_staff);
            this.lt_stage = this.t.getStageByUserID(this.lt_mi[0].log_staff);
            this.lt_app = this.t.getApplicantByvalidationID(this.lt_mi[0].log_staff);
            this.lt_inv = this.t.getInventorByvalidationID(this.lt_mi[0].log_staff);
            this.lt_assinfo = this.t.getAssignment_infoByvalidationID(this.lt_mi[0].log_staff);
            this.lt_xpri = this.t.getPriority_infoByvalidationID(this.lt_mi[0].log_staff);

            Label1.Text = lt_mi[0].title_of_invention;
            Label2.Text = lt_stage[0].validationID;
            Label3.Text = lt_mi[0].reg_number;
            Label4.Text = lt_mi[0].reg_date;
            Label5.Text = lt_app[0].xname;

            Label6.Text = lt_mi[0].xtype;

            Label7.Text = lt_mi[0].title_of_invention;

            if (Session["pwalletID"] != null)
            {

                string xid2 = Convert.ToString(Session["pwalletID"]);

                zues tt = new zues();
               zues.Adminz kk = tt.getAdminDetails(xid2);
               Label8.Text = kk.xname;
            }

        }
    }
