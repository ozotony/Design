using Brettle.Web.NeatUpload;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;




public partial class xindex : System.Web.UI.Page
{
    public string agent = "";
    public string agentemail = "";
    public string agentpnumber = "";
    public string aid = "";
    public string amt = "";
    public string cname = "";
    public string log_staffID = "0";
    public string pc = "";
    public string product_title = "";
    public string pwalletID = "0";
    public pt t = new pt();
    public string transID = "";
    public string vid = "";
    public string x = "";
    public string xapplication = "";
    public string xgt = "";
    public string xrep = "";
    public string xuserType = "";
    public string agentname = "";
    //added by tony 
    string serverpath = "";
    //public string agentemail;
    //public string agentpnumber;
 //   public string aid = "";
  //  public string amt = "";
 //   public string cname = "";
    public string gt = "";
  //  public string transID = "";
 //   public string vid = "";
 //   public string xapplication = "";
  //  public string pc = "";
    public string status = "0";

    public SortedList<string, string> sl_xx = new SortedList<string, string>();
    public List<SortedList<string, string>> lt_app = new List<SortedList<string, string>>();
    public List<SortedList<string, string>> lt_inv = new List<SortedList<string, string>>();
    public List<SortedList<string, string>> lt_pri = new List<SortedList<string, string>>();
 //   public pt t = new pt();

    protected string xreg_date = DateTime.Now.ToString("yyyy-MM-dd");
    protected string xvisible = "1";

    public string doc_path = "";  public string ack_status = "0";

    
    public string loa_newfilename = "0";
    public string claim_newfilename = "0";
    public string pct_newfilename = "0";

    // protected HtmlForm form1;

    public string doa_newfilename = "";
    public string ns_newfilename = "";
    public string pd_newfilename = "";
    public string rep1_newfilename = "";
    public string rep2_newfilename = "";
    public string rep3_newfilename = "";
    public string rep4_newfilename = "";
    public string hwalletID = "";
    //added 2 

   
  
    public List<pt.PtInfo> lt_mi = new List<pt.PtInfo>();
    public List<pt.Representative> lt_rep = new List<pt.Representative>();
    public List<pt.Stage> lt_stage = new List<pt.Stage>();

    public List<pt.Assignment_info> lt_assinfo = new List<pt.Assignment_info>();
  
    public List<pt.Priority_info> lt_xpri = new List<pt.Priority_info>();

    public List<pt.Applicant> lt_app2 = new List<pt.Applicant>();

    public List<pt.Inventor> lt_inv2 = new List<pt.Inventor>();
   
    public string validationID = "";
  

    protected void Page_Load(object sender, EventArgs e)
    {
       if (!(Page.IsPostBack))
       {
            this.Session["vid"] = null;
            this.Session["amt"] = null;
            this.Session["aid"] = null;
            this.Session["gt"] = null;
            this.Session["pc"] = null;
            this.Session["agentemail"] = null;
            this.Session["agentname"] = null;
            this.Session["agentpnumber"] = null;
            this.Session["product_title"] = null;
            this.Session["xapplication"] = null;
            this.Session["pwalletID"] = null;
            this.Session["log_staffID"] = null;
            this.Session["xapplication"] = null;
            this.Session["log_staffID"] = this.log_staffID;

            serverpath = base.Server.MapPath("~/");
            this.transID = base.Request.Params["transID"];
            this.amt = base.Request.Params["amt"];
            this.agent = base.Request.Params["agent"];
            this.xgt = base.Request.Params["xgt"];
            this.pc = base.Request.Params["pc"];
            if (Request.Form["hwalletID"] != null) { this.hwalletID = Request.Form["hwalletID"]; }
            if ((base.Request.Params["agentname"] != null) && (base.Request.Params["agentname"].Contains("%26")))
            {
                this.agentname = base.Request.Params["agentname"].Replace("%26", "&");
            }
            else
            {
                this.agentname = base.Request.Params["agentname"];
            }
            this.agentemail = base.Request.Params["agentemail"];
            this.agentpnumber = base.Request.Params["agentpnumber"];
            if ((base.Request.Params["product_title"] != null) && (base.Request.Params["product_title"].Contains("%26")))
            {
                this.product_title = base.Request.Params["product_title"].Replace("%26", "&");
            }
            else
            {
                this.product_title = base.Request.Params["product_title"];
            }

            if ((this.transID != "") && (this.amt != "") && (this.agent != "") && (this.xgt != "") && (this.agentname != "") && (this.agentemail != "") && (this.agentpnumber != "") && (this.product_title != "") && (this.pc != ""))
            {
                if (this.Session["xapplication"] != null)
                {
                    this.xapplication = this.Session["xapplication"].ToString();
                    if (this.xapplication != this.transID)
                    {

                    }
                }
                else
                {
                    this.Session["xapplication"] = this.transID;
                }
                this.Session["vid"] = this.transID;
                this.Session["amt"] = this.amt;
                this.Session["aid"] = this.agent;
                this.Session["gt"] = this.xgt;
                this.Session["pc"] = this.pc;
                this.Session["agentemail"] = this.agentemail;
                this.Session["agentname"] = this.agentname;
                this.Session["agentpnumber"] = this.agentpnumber;
                this.Session["product_title"] = this.product_title;
                Session["hwalletID"] = this.hwalletID;

                if (this.Session["pc"] != null)
                {
                    this.pc = this.Session["pc"].ToString();
                    if (this.pc == "D002") { lbl_type.Text = "NON-TEXTILE"; }
                    else { lbl_type.Text = "TEXTILE"; }
                }

                if (this.Session["aid"] != null) { rep_code.Text = Session["aid"].ToString(); }
                Int32 cID = this.t.getStageIDByvalidationID(this.transID.Trim());
                if (cID > 0)
                {

                    Response.Redirect("./xreturn.aspx");
                }

            }
            else
            {
                base.Response.Redirect("http://www.iponigeria.com/userarea/dashboard");
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        tt.Visible = false;
        tt2.Visible = true;


        SetInitialRow_App_gv();
        SetInitialRow_Inv_gv();
        SetInitialRow_Pri_gv();
        if (this.Session["vid"] != null) { this.transID = this.Session["vid"].ToString(); }
        this.Session["xref"] = Convert.ToInt32(this.Session["xref"]) + 1;
        if (this.Session["xref"].ToString() != "1")
        {
            //  base.Response.Redirect("./violation.aspx");
        }
        if (((this.Session["xapplication"] != null) && (this.Session["xapplication"].ToString() != "")) && (this.transID != this.Session["xapplication"].ToString()))
        {
            // base.Response.Redirect("./violation.aspx");
        }
        this.select_rep_nationality.SelectedValue = "160";
        if (this.Session["agentname"] != null) { this.rep_xname.Text = Session["agentname"].ToString(); }
        if (this.Session["agentemail"] != null) { this.txt_rep_email.Text = Session["agentemail"].ToString(); }
        if (this.Session["agentpnumber"] != null) { this.txt_rep_telephone.Text = Session["agentpnumber"].ToString(); }
        if (this.Session["product_title"] != null) { this.txt_title_of_invention.Text = Session["product_title"].ToString(); }  

    }

    private void SetInitialRow_App_gv()
    {
        DataTable dt = new DataTable();
        DataRow dr = null;
        dt.Columns.Add(new DataColumn("RowNumber_app", typeof(string)));
        dt.Columns.Add(new DataColumn("app_Column1", typeof(string)));
        dr = dt.NewRow();
        dr["RowNumber_app"] = 1;
        dr["app_Column1"] = string.Empty;
        // dr["Column3"] = string.Empty;
        dt.Rows.Add(dr);
        //Store the DataTable in ViewState
        ViewState["AppTable"] = dt;
        gv_app.DataSource = dt;
        gv_app.DataBind();
    }
    private void SetInitialRow_Inv_gv()
    {
        DataTable dt = new DataTable();
        DataRow dr = null;
        dt.Columns.Add(new DataColumn("RowNumber_inv", typeof(string)));
        dt.Columns.Add(new DataColumn("inv_Column2", typeof(string)));
        dr = dt.NewRow();
        dr["RowNumber_inv"] = 1;
        dr["inv_Column2"] = string.Empty;
        dt.Rows.Add(dr);
        //Store the DataTable in ViewState
        ViewState["InvTable"] = dt;
        gv_inv.DataSource = dt;
        gv_inv.DataBind();
    }
    private void SetInitialRow_Pri_gv()
    {
        DataTable dt = new DataTable();
        DataRow dr = null;
        dt.Columns.Add(new DataColumn("RowNumber_pri", typeof(string)));
        dt.Columns.Add(new DataColumn("pri_Column2", typeof(string)));
        dt.Columns.Add(new DataColumn("pri_Column3", typeof(string)));
        dt.Columns.Add(new DataColumn("pri_Column4", typeof(string)));
        dr = dt.NewRow();
        dr["RowNumber_pri"] = 1;
        dr["pri_Column2"] = string.Empty;
        dr["pri_Column3"] = string.Empty;
        dr["pri_Column4"] = string.Empty;
        dt.Rows.Add(dr);
        //Store the DataTable in ViewState
        ViewState["PriTable"] = dt;
        gv_pri.DataSource = dt;
        gv_pri.DataBind();
    }

    private void AddNewRowToGrid_App_gv()
    {
        int rowIndex = 0;
        if (ViewState["AppTable"] != null)
        {
            DataTable dtCurrentTable = (DataTable)ViewState["AppTable"];
            DataRow drCurrentRow = null;
            if (dtCurrentTable.Rows.Count > 0)
            {
                for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                {
                    TextBox txt_name_app = (TextBox)gv_app.Rows[rowIndex].Cells[1].FindControl("txt_name_app");
                    TextBox txt_address_app = (TextBox)gv_app.Rows[rowIndex].Cells[1].FindControl("txt_address_app");
                    TextBox txt_email_app = (TextBox)gv_app.Rows[rowIndex].Cells[1].FindControl("txt_email_app");
                    TextBox txt_mobile_app = (TextBox)gv_app.Rows[rowIndex].Cells[1].FindControl("txt_mobile_app");

                    drCurrentRow = dtCurrentTable.NewRow();
                    drCurrentRow["RowNumber_app"] = i + 1;

                    dtCurrentTable.Rows[i - 1]["app_Column1"] = txt_name_app.Text;
                    dtCurrentTable.Rows[i - 1]["app_Column1"] = txt_address_app.Text;
                    dtCurrentTable.Rows[i - 1]["app_Column1"] = txt_email_app.Text;
                    dtCurrentTable.Rows[i - 1]["app_Column1"] = txt_mobile_app.Text;
                    SortedList<string, string> sl_x = new SortedList<string, string>();
                    sl_x["txt_name_app"] = txt_name_app.Text;
                    sl_x["txt_address_app"] = txt_address_app.Text;
                    sl_x["txt_email_app"] = txt_email_app.Text;
                    sl_x["txt_mobile_app"] = txt_mobile_app.Text;
                    lt_app.Add(sl_x);
                    rowIndex++;
                }
                Session["lt_app"] = lt_app;
                dtCurrentTable.Rows.Add(drCurrentRow);
                ViewState["AppTable"] = dtCurrentTable;
                gv_app.DataSource = dtCurrentTable;
                gv_app.DataBind();
            }
        }
        else
        {
            Response.Write("ViewState is null");
        }
        //Set Previous Data on Postbacks
        SetPreviousData_App_gv();
    }
    private void AddNewRowToGrid_Inv_gv()
    {
        int rowIndex = 0;
        if (ViewState["InvTable"] != null)
        {
            DataTable dtCurrentTable = (DataTable)ViewState["InvTable"];
            DataRow drCurrentRow = null;
            if (dtCurrentTable.Rows.Count > 0)
            {
                for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                {
                    TextBox txt_name_inv = (TextBox)gv_inv.Rows[rowIndex].Cells[1].FindControl("txt_name_inv");
                    TextBox txt_address_inv = (TextBox)gv_inv.Rows[rowIndex].Cells[1].FindControl("txt_address_inv");
                    TextBox txt_email_inv = (TextBox)gv_inv.Rows[rowIndex].Cells[1].FindControl("txt_email_inv");
                    TextBox txt_mobile_inv = (TextBox)gv_inv.Rows[rowIndex].Cells[1].FindControl("txt_mobile_inv");

                    drCurrentRow = dtCurrentTable.NewRow();
                    drCurrentRow["RowNumber_inv"] = i + 1;

                    dtCurrentTable.Rows[i - 1]["inv_Column2"] = txt_name_inv.Text;
                    dtCurrentTable.Rows[i - 1]["inv_Column2"] = txt_address_inv.Text;
                    dtCurrentTable.Rows[i - 1]["inv_Column2"] = txt_email_inv.Text;
                    dtCurrentTable.Rows[i - 1]["inv_Column2"] = txt_mobile_inv.Text;
                    SortedList<string, string> sl_x = new SortedList<string, string>();
                    sl_x["txt_name_inv"] = txt_name_inv.Text;
                    sl_x["txt_address_inv"] = txt_address_inv.Text;
                    sl_x["txt_email_inv"] = txt_email_inv.Text;
                    sl_x["txt_mobile_inv"] = txt_mobile_inv.Text;
                    lt_inv.Add(sl_x);
                    rowIndex++;
                }
                Session["lt_inv"] = lt_inv;
                dtCurrentTable.Rows.Add(drCurrentRow);
                ViewState["InvTable"] = dtCurrentTable;
                gv_inv.DataSource = dtCurrentTable;
                gv_inv.DataBind();
            }
        }
        else
        {
            Response.Write("ViewState is null");
        }
        //Set Previous Data on Postbacks
        SetPreviousData_Inv_gv();
    }
    private void AddNewRowToGrid_Pri_gv()
    {
        int rowIndex = 0;
        if (ViewState["PriTable"] != null)
        {
            DataTable dtCurrentTable = (DataTable)ViewState["PriTable"];
            DataRow drCurrentRow = null;
            if (dtCurrentTable.Rows.Count > 0)
            {
                for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                {
                    DropDownList select_country_pri = (DropDownList)gv_pri.Rows[rowIndex].Cells[1].FindControl("select_country_pri");
                    TextBox txt_application_no_pri = (TextBox)gv_pri.Rows[rowIndex].Cells[2].FindControl("txt_application_no_pri");
                    TextBox txt_date_pri = (TextBox)gv_pri.Rows[rowIndex].Cells[3].FindControl("txt_date_pri");

                    drCurrentRow = dtCurrentTable.NewRow();
                    drCurrentRow["RowNumber_pri"] = i + 1;

                    dtCurrentTable.Rows[i - 1]["pri_Column2"] = select_country_pri.Text;
                    dtCurrentTable.Rows[i - 1]["pri_Column3"] = txt_application_no_pri.Text;
                    dtCurrentTable.Rows[i - 1]["pri_Column4"] = txt_date_pri.Text;
                    SortedList<string, string> sl_x = new SortedList<string, string>();
                    sl_x["select_country_pri"] = select_country_pri.Text;
                    sl_x["txt_application_no_pri"] = txt_application_no_pri.Text;
                    sl_x["txt_date_pri"] = txt_date_pri.Text;
                    lt_pri.Add(sl_x);

                    rowIndex++;
                }
                Session["lt_pri"] = lt_pri;
                dtCurrentTable.Rows.Add(drCurrentRow);
                ViewState["PriTable"] = dtCurrentTable;

                gv_pri.DataSource = dtCurrentTable;
                gv_pri.DataBind();
            }
        }
        else
        {
            Response.Write("ViewState is null");
        }
        //Set Previous Data on Postbacks
        SetPreviousData_Pri_gv();
    }

    protected void SetLatestRowsFromGrid_App_gv()
    {
        int rowIndex = 0;
        lt_app.Clear();
        if (ViewState["AppTable"] != null)
        {
            DataTable dtCurrentTable = (DataTable)ViewState["AppTable"];
            DataRow drCurrentRow = null;
            if (dtCurrentTable.Rows.Count > 0)
            {
                for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                {
                    TextBox txt_name_app = (TextBox)gv_app.Rows[rowIndex].Cells[1].FindControl("txt_name_app");
                    TextBox txt_address_app = (TextBox)gv_app.Rows[rowIndex].Cells[1].FindControl("txt_address_app");
                    TextBox txt_email_app = (TextBox)gv_app.Rows[rowIndex].Cells[1].FindControl("txt_email_app");
                    TextBox txt_mobile_app = (TextBox)gv_app.Rows[rowIndex].Cells[1].FindControl("txt_mobile_app");

                    drCurrentRow = dtCurrentTable.NewRow();
                    drCurrentRow["RowNumber_app"] = i + 1;

                    dtCurrentTable.Rows[i - 1]["app_Column1"] = txt_name_app.Text;
                    dtCurrentTable.Rows[i - 1]["app_Column1"] = txt_address_app.Text;
                    dtCurrentTable.Rows[i - 1]["app_Column1"] = txt_email_app.Text;
                    dtCurrentTable.Rows[i - 1]["app_Column1"] = txt_mobile_app.Text;
                    SortedList<string, string> sl_x = new SortedList<string, string>();
                    sl_x["txt_name_app"] = txt_name_app.Text;
                    sl_x["txt_address_app"] = txt_address_app.Text;
                    sl_x["txt_email_app"] = txt_email_app.Text;
                    sl_x["txt_mobile_app"] = txt_mobile_app.Text;
                    if ((txt_name_app.Text != "") && (txt_name_app.Text != null))
                    {
                        lt_app.Add(sl_x);
                    }
                    rowIndex++;
                }
                Session["lt_app"] = lt_app;
                dtCurrentTable.Rows.Add(drCurrentRow);
                ViewState["AppTable"] = dtCurrentTable;
            }
        }
        else
        {
            Response.Write("ViewState is null");
        }
        //Set Previous Data on Postbacks
        // SetPreviousData_App_gv();
    }
    protected void SetLatestRowsFromGrid_Inv_gv()
    {
        int rowIndex = 0; lt_inv.Clear();
        if (ViewState["InvTable"] != null)
        {
            DataTable dtCurrentTable = (DataTable)ViewState["InvTable"];
            DataRow drCurrentRow = null;
            if (dtCurrentTable.Rows.Count > 0)
            {
                for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                {
                    TextBox txt_name_inv = (TextBox)gv_inv.Rows[rowIndex].Cells[1].FindControl("txt_name_inv");
                    TextBox txt_address_inv = (TextBox)gv_inv.Rows[rowIndex].Cells[1].FindControl("txt_address_inv");
                    TextBox txt_email_inv = (TextBox)gv_inv.Rows[rowIndex].Cells[1].FindControl("txt_email_inv");
                    TextBox txt_mobile_inv = (TextBox)gv_inv.Rows[rowIndex].Cells[1].FindControl("txt_mobile_inv");

                    drCurrentRow = dtCurrentTable.NewRow();
                    drCurrentRow["RowNumber_inv"] = i + 1;

                    dtCurrentTable.Rows[i - 1]["inv_Column2"] = txt_name_inv.Text;
                    dtCurrentTable.Rows[i - 1]["inv_Column2"] = txt_address_inv.Text;
                    dtCurrentTable.Rows[i - 1]["inv_Column2"] = txt_email_inv.Text;
                    dtCurrentTable.Rows[i - 1]["inv_Column2"] = txt_mobile_inv.Text;
                    SortedList<string, string> sl_x = new SortedList<string, string>();
                    sl_x["txt_name_inv"] = txt_name_inv.Text;
                    sl_x["txt_address_inv"] = txt_address_inv.Text;
                    sl_x["txt_email_inv"] = txt_email_inv.Text;
                    sl_x["txt_mobile_inv"] = txt_mobile_inv.Text;
                    if ((txt_name_inv.Text != "") && (txt_name_inv.Text != null))
                    {
                        lt_inv.Add(sl_x);
                    }
                    rowIndex++;
                }
                Session["lt_inv"] = lt_inv;
                dtCurrentTable.Rows.Add(drCurrentRow);
                ViewState["InvTable"] = dtCurrentTable;
            }
        }
        else
        {
            Response.Write("ViewState is null");
        }
        //Set Previous Data on Postbacks
        // SetPreviousData_Inv_gv();
    }
    protected void SetLatestRowsFromGrid_Pri_gv()
    {
        int rowIndex = 0; lt_pri.Clear();
        if (ViewState["PriTable"] != null)
        {
            DataTable dtCurrentTable = (DataTable)ViewState["PriTable"];
            DataRow drCurrentRow = null;
            if (dtCurrentTable.Rows.Count > 0)
            {
                for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                {
                    DropDownList select_country_pri = (DropDownList)gv_pri.Rows[rowIndex].Cells[1].FindControl("select_country_pri");
                    TextBox txt_application_no_pri = (TextBox)gv_pri.Rows[rowIndex].Cells[2].FindControl("txt_application_no_pri");
                    TextBox txt_date_pri = (TextBox)gv_pri.Rows[rowIndex].Cells[3].FindControl("txt_date_pri");

                    drCurrentRow = dtCurrentTable.NewRow();
                    drCurrentRow["RowNumber_pri"] = i + 1;

                    dtCurrentTable.Rows[i - 1]["pri_Column2"] = select_country_pri.Text;
                    dtCurrentTable.Rows[i - 1]["pri_Column3"] = txt_application_no_pri.Text;
                    dtCurrentTable.Rows[i - 1]["pri_Column4"] = txt_date_pri.Text;
                    SortedList<string, string> sl_x = new SortedList<string, string>();
                    sl_x["select_country_pri"] = select_country_pri.Text;
                    sl_x["txt_application_no_pri"] = txt_application_no_pri.Text;
                    sl_x["txt_date_pri"] = txt_date_pri.Text;
                    if ((txt_application_no_pri.Text != "") && (txt_application_no_pri.Text != null))
                    {
                        lt_pri.Add(sl_x);
                    }

                    rowIndex++;
                }
                Session["lt_pri"] = lt_pri;
                dtCurrentTable.Rows.Add(drCurrentRow);
                ViewState["PriTable"] = dtCurrentTable;
            }
        }
        else
        {
            Response.Write("ViewState is null");
        }
        //Set Previous Data on Postbacks
        // SetPreviousData_Pri_gv();
    }

    private void SetPreviousData_App_gv()
    {
        int rowIndex = 0;
        if (lt_app.Count > 0)
        {
            for (int i = 0; i < lt_app.Count; i++)
            {
                TextBox txt_name_app = (TextBox)gv_app.Rows[rowIndex].Cells[1].FindControl("txt_name_app");
                TextBox txt_address_app = (TextBox)gv_app.Rows[rowIndex].Cells[1].FindControl("txt_address_app");
                TextBox txt_email_app = (TextBox)gv_app.Rows[rowIndex].Cells[1].FindControl("txt_email_app");
                TextBox txt_mobile_app = (TextBox)gv_app.Rows[rowIndex].Cells[1].FindControl("txt_mobile_app");
                txt_name_app.Text = lt_app[i]["txt_name_app"];
                txt_address_app.Text = lt_app[i]["txt_address_app"];
                txt_email_app.Text = lt_app[i]["txt_email_app"];
                txt_mobile_app.Text = lt_app[i]["txt_mobile_app"];

                rowIndex++;
            }
        }
    }
    private void SetPreviousData_Inv_gv()
    {
        int rowIndex = 0;
        if (lt_inv.Count > 0)
        {
            for (int i = 0; i < lt_inv.Count; i++)
            {
                TextBox txt_name_inv = (TextBox)gv_inv.Rows[rowIndex].Cells[1].FindControl("txt_name_inv");
                TextBox txt_address_inv = (TextBox)gv_inv.Rows[rowIndex].Cells[1].FindControl("txt_address_inv");
                TextBox txt_email_inv = (TextBox)gv_inv.Rows[rowIndex].Cells[1].FindControl("txt_email_inv");
                TextBox txt_mobile_inv = (TextBox)gv_inv.Rows[rowIndex].Cells[1].FindControl("txt_mobile_inv");
                txt_name_inv.Text = lt_inv[i]["txt_name_inv"];
                txt_address_inv.Text = lt_inv[i]["txt_address_inv"];
                txt_email_inv.Text = lt_inv[i]["txt_email_inv"];
                txt_mobile_inv.Text = lt_inv[i]["txt_mobile_inv"];
                rowIndex++;
            }
        }
    }
    private void SetPreviousData_Pri_gv()
    {
        int rowIndex = 0;
        if (lt_pri.Count > 0)
        {
            for (int i = 0; i < lt_pri.Count; i++)
            {
                DropDownList select_country_pri = (DropDownList)gv_pri.Rows[rowIndex].Cells[1].FindControl("select_country_pri");
                TextBox txt_application_no_pri = (TextBox)gv_pri.Rows[rowIndex].Cells[2].FindControl("txt_application_no_pri");
                TextBox txt_date_pri = (TextBox)gv_pri.Rows[rowIndex].Cells[3].FindControl("txt_date_pri");

                select_country_pri.Text = lt_pri[i]["select_country_pri"];
                txt_application_no_pri.Text = lt_pri[i]["txt_application_no_pri"];
                txt_date_pri.Text = lt_pri[i]["txt_date_pri"];
                rowIndex++;
            }
        }
    }

    protected void ButtonAddApp_Click(object sender, EventArgs e)
    {
        AddNewRowToGrid_App_gv();
    }
    protected void ButtonAddInv_Click(object sender, EventArgs e)
    {
        AddNewRowToGrid_Inv_gv();
    }
    protected void ButtonAddPri_Click(object sender, EventArgs e)
    {
        AddNewRowToGrid_Pri_gv();
    }

    protected void SaveAll2_Click(object sender, EventArgs e)
    {
        TransactionOptions transactionOptions = new TransactionOptions
        {


            IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted,

            Timeout = TimeSpan.FromMinutes(10.0)
        };
        TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, transactionOptions);
       try {

           this.transID = this.Session["vid"].ToString();
           this.amt = this.Session["amt"].ToString();
           this.agent = this.Session["aid"].ToString();
           this.xgt = this.Session["gt"].ToString();
           this.pc = this.Session["pc"].ToString();
           this.agentemail = this.Session["agentemail"].ToString();
           this.agentname = this.Session["agentname"].ToString();
           this.agentpnumber = this.Session["agentpnumber"].ToString();
           this.product_title = this.Session["product_title"].ToString();

           serverpath = base.Server.MapPath("~/");
         //  this.pwalletID = this.t.addPwallet(serverpath, this.transID, this.agent, this.amt, this.log_staffID);
               if (this.pwalletID != "0")
               {

         this.Session["pwalletID"] = this.pwalletID;
              }
        SetLatestRowsFromGrid_App_gv(); SetLatestRowsFromGrid_Inv_gv(); SetLatestRowsFromGrid_Pri_gv();

        pt.PtInfo c_ptinfo = new pt.PtInfo();
        pt.Assignment_info c_assinfo = new pt.Assignment_info();
        pt.Representative c_rep = new pt.Representative();

        List<pt.Applicant> lt_xapp = new List<pt.Applicant>();
        List<pt.Inventor> lt_xinv = new List<pt.Inventor>();
        List<pt.Priority_info> lt_xpri = new List<pt.Priority_info>();

        c_ptinfo.reg_number = "";
        c_ptinfo.xtype = lbl_type.Text;
        c_ptinfo.title_of_invention = txt_title_of_invention.Text;
        c_ptinfo.pt_class = txt_class_of_design.Text;
        if (Session["pwalletID"] != null)
        {
            c_ptinfo.log_staff = Session["pwalletID"].ToString();
        }
        else
        {// base.Response.Redirect("./violation.aspx");
        }
        c_ptinfo.reg_date = xreg_date;
        c_ptinfo.xvisible = xvisible;
       // c_ptinfo.claim_no = "0";
       // c_ptinfo.loa_no = "0";
      //  c_ptinfo.pct_no = "0";
      //  c_ptinfo.doa_no = "0";

        c_assinfo.assignee_name = txt_assignee_name.Text;
        c_assinfo.assignee_address = txt_assignee_address.Text;
        c_assinfo.assignor_name = txt_assignor_name.Text;
        c_assinfo.assignor_address = txt_assignor_address.Text;
        if (Session["pwalletID"] != null)
        {
            c_assinfo.log_staff = Session["pwalletID"].ToString();
        }
        else
        { //base.Response.Redirect("./violation.aspx");
        }
        c_assinfo.visible = xvisible;

        c_rep.agent_code = rep_code.Text;
        c_rep.xname = rep_xname.Text;
        c_rep.nationality = select_rep_nationality.SelectedValue;
        c_rep.country = "160";
        c_rep.state = select_rep_state.SelectedValue;
        c_rep.address = txt_rep_address.Text;
        c_rep.xmobile = txt_rep_telephone.Text;
        c_rep.xemail = txt_rep_email.Text;
        c_rep.reg_date = xreg_date;
        c_rep.visible = xvisible;
        if (Session["pwalletID"] != null)
        {
            c_rep.log_staff = Session["pwalletID"].ToString();
        }
        else
        { //base.Response.Redirect("./violation.aspx"); 
        }

        lt_app = (List<SortedList<string, string>>)Session["lt_app"];
        lt_inv = (List<SortedList<string, string>>)Session["lt_inv"];
        lt_pri = (List<SortedList<string, string>>)Session["lt_pri"];

        if (lt_app.Count > 0)
        {
            for (int i = 0; i < lt_app.Count; i++)
            {
                pt.Applicant c_app = new pt.Applicant();
                c_app.xname = lt_app[i]["txt_name_app"];
                c_app.address = lt_app[i]["txt_address_app"];
                c_app.xemail = lt_app[i]["txt_email_app"];
                c_app.xmobile = lt_app[i]["txt_mobile_app"];
                if (Session["pwalletID"] != null)
                {
                    c_app.log_staff = Session["pwalletID"].ToString();
                }
                else
                {// base.Response.Redirect("./violation.aspx");
                }
                c_app.visible = xvisible;
                lt_xapp.Add(c_app);
            }
        }

        if (lt_inv.Count > 0)
        {
            for (int i = 0; i < lt_inv.Count; i++)
            {
                pt.Inventor c_inv = new pt.Inventor();
                c_inv.xname = lt_inv[i]["txt_name_inv"];
                c_inv.address = lt_inv[i]["txt_address_inv"];
                c_inv.xemail = lt_inv[i]["txt_email_inv"];
                c_inv.xmobile = lt_inv[i]["txt_mobile_inv"];
                if (Session["pwalletID"] != null)
                {
                    c_inv.log_staff = Session["pwalletID"].ToString();
                }
                else
                { //base.Response.Redirect("./violation.aspx"); 
                }
                c_inv.visible = xvisible;
                lt_xinv.Add(c_inv);
            }
        }

        if (lt_pri.Count > 0)
        {
            for (int i = 0; i < lt_pri.Count; i++)
            {
                pt.Priority_info c_pri = new pt.Priority_info();
                c_pri.countryID = lt_pri[i]["select_country_pri"];
                c_pri.app_no = lt_pri[i]["txt_application_no_pri"];
                c_pri.xdate = lt_pri[i]["txt_date_pri"];
                if (Session["pwalletID"] != null)
                {
                    c_pri.log_staff = Session["pwalletID"].ToString();
                }
                else
                { //base.Response.Redirect("./violation.aspx");
                }
                c_pri.xvisible = xvisible;
                lt_xpri.Add(c_pri);
            }
        }
        string pt_succ = t.addNewDesign(lt_xapp, lt_xpri, lt_xinv, c_ptinfo, c_assinfo, c_rep, serverpath, this.transID, this.agent, this.amt, this.log_staffID);
        if ((pt_succ != "") && (pt_succ != null))
        {
            Session["new_ptID"] = pt_succ;

            if (this.Session["new_ptID"] != null)
            {
                this.doc_path = base.Server.MapPath("~/") + "admin/pt/docz/" + this.Session["new_ptID"].ToString() + "/";
                if (!Directory.Exists(this.doc_path))
                {
                    Directory.CreateDirectory(this.doc_path);
                }
                if (base.IsValid && this.fu_loa_doc.HasFile)
                {
                    this.loa_newfilename = Path.Combine(this.doc_path, this.fu_loa_doc.FileName.Replace(" ", "_"));
                    this.fu_loa_doc.MoveTo(this.loa_newfilename, MoveToOptions.Overwrite);
                }
                if (base.IsValid && this.fu_doa_doc.HasFile)
                {
                    this.doa_newfilename = Path.Combine(this.doc_path, this.fu_doa_doc.FileName.Replace(" ", "_"));
                    this.fu_doa_doc.MoveTo(this.doa_newfilename, MoveToOptions.Overwrite);
                }
                if (base.IsValid && this.fu_ns_doc.HasFile)
                {
                    this.ns_newfilename = Path.Combine(this.doc_path, this.fu_ns_doc.FileName.Replace(" ", "_"));
                    this.fu_ns_doc.MoveTo(this.ns_newfilename, MoveToOptions.Overwrite);
                }
                if (base.IsValid && this.fu_pd_doc.HasFile)
                {
                    this.pd_newfilename = Path.Combine(this.doc_path, this.fu_pd_doc.FileName.Replace(" ", "_"));
                    this.fu_pd_doc.MoveTo(this.pd_newfilename, MoveToOptions.Overwrite);
                }
                if (base.IsValid && this.fu_rep_doc.HasFile)
                {
                    this.rep1_newfilename = Path.Combine(this.doc_path, this.fu_rep_doc.FileName.Replace(" ", "_"));
                    this.fu_rep_doc.MoveTo(this.rep1_newfilename, MoveToOptions.Overwrite);
                }
                if (base.IsValid && this.fu_rep2_doc.HasFile)
                {
                    this.rep2_newfilename = Path.Combine(this.doc_path, this.fu_rep2_doc.FileName.Replace(" ", "_"));
                    this.fu_rep2_doc.MoveTo(this.rep2_newfilename, MoveToOptions.Overwrite);
                }
                if (base.IsValid && this.fu_rep3_doc.HasFile)
                {
                    this.rep3_newfilename = Path.Combine(this.doc_path, this.fu_rep3_doc.FileName.Replace(" ", "_"));
                    this.fu_rep3_doc.MoveTo(this.rep3_newfilename, MoveToOptions.Overwrite);
                }
                if (base.IsValid && this.fu_rep4_doc.HasFile)
                {
                    this.rep4_newfilename = Path.Combine(this.doc_path, this.fu_rep4_doc.FileName.Replace(" ", "_"));
                    this.fu_rep4_doc.MoveTo(this.rep4_newfilename, MoveToOptions.Overwrite);
                }
                this.loa_newfilename = this.loa_newfilename.Replace(base.Server.MapPath("~/") + "admin/pt/", "");
                this.doa_newfilename = this.doa_newfilename.Replace(base.Server.MapPath("~/") + "admin/pt/", "");
                this.ns_newfilename = this.ns_newfilename.Replace(base.Server.MapPath("~/") + "admin/pt/", "");
                this.pd_newfilename = this.pd_newfilename.Replace(base.Server.MapPath("~/") + "admin/pt/", "");
                this.rep1_newfilename = this.rep1_newfilename.Replace(base.Server.MapPath("~/") + "admin/pt/", "");
                this.rep2_newfilename = this.rep2_newfilename.Replace(base.Server.MapPath("~/") + "admin/pt/", "");
                this.rep3_newfilename = this.rep3_newfilename.Replace(base.Server.MapPath("~/") + "admin/pt/", "");
                this.rep4_newfilename = this.rep4_newfilename.Replace(base.Server.MapPath("~/") + "admin/pt/", "");
                this.Session["loa_newfilename"] = this.loa_newfilename;
                this.Session["doa_newfilename"] = this.doa_newfilename;
                this.Session["ns_newfilename"] = this.ns_newfilename;
                this.Session["pd_newfilename"] = this.pd_newfilename;
                this.Session["rep1_newfilename"] = this.rep1_newfilename;
                this.Session["rep2_newfilename"] = this.rep2_newfilename;
                this.Session["rep3_newfilename"] = this.rep3_newfilename;
                this.Session["rep4_newfilename"] = this.rep4_newfilename;
                if (this.t.updatePtDocz(this.loa_newfilename, this.doa_newfilename, this.ns_newfilename, this.pd_newfilename, this.rep1_newfilename, this.rep2_newfilename, this.rep3_newfilename, this.rep4_newfilename, this.Session["new_ptID"].ToString()) != "0")
                {
                   // this.status = "1";
                   
                        this.ack_status = "1";

                        ws_payx.payx ws_p = new ws_payx.payx();

                        string hp = Session["hwalletID"].ToString();

                        if (Session["hwalletID"] != "")
                        {
                            int status2 = ws_p.UpdateHwallet(Session["hwalletID"].ToString(), "Used", xreg_date, Session["product_title"].ToString());

                            if (status2 > 0)
                            {

                                scope.Complete();
                                scope.Dispose();
                            }
                            else
                            {
                                scope.Dispose();

                                Response.Redirect("http://ipo.cldng.com/a_login.aspx");


                            }

                        }

                        else
                        {
                            scope.Complete();
                            scope.Dispose();
                        }
                        if (Session["vid"] != null) { vid = Session["vid"].ToString(); }

                        if (this.vid.Contains("OAI/DS/"))
                        {
                            this.vid = this.vid.Replace("OAI/DS/", "");
                        }
                        pwalletID = t.getPwalletID(vid);
                        if (pwalletID != "")
                        {
                            this.lt_mi = this.t.getPtInfoByPwalletID(pwalletID);
                            this.lt_rep = this.t.getRepListByUserID(pwalletID);
                            this.lt_stage = this.t.getStageByUserID(pwalletID);
                            this.lt_app2 = this.t.getApplicantByvalidationID(pwalletID);
                            this.lt_inv2 = this.t.getInventorByvalidationID(pwalletID);
                            this.lt_assinfo = this.t.getAssignment_infoByvalidationID(pwalletID);
                            this.lt_xpri = this.t.getPriority_infoByvalidationID(pwalletID);

                            tt2.Visible = false;

                            tt3.Visible = true;


                        }
                   
                }
            }

          
           // Response.Redirect("./application_docs.aspx");
        }

    }
    catch(Exception ee ) {
        scope.Dispose();
}
    }
}