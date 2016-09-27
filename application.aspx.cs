using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class application : System.Web.UI.Page
{
    public string agentemail;
    public string agentpnumber;
    public string aid = "";
    public string amt = "";
    public string cname="";
    public string gt = "";
    public string transID = "";
    public string vid = "";
    public string xapplication = "";
    public string pc = "";
    public string status = "0";

    public SortedList<string, string> sl_xx = new SortedList<string, string>();
    public List<SortedList<string, string>> lt_app = new List<SortedList<string, string>>();
    public List<SortedList<string, string>> lt_inv = new List<SortedList<string, string>>();
    public List<SortedList<string, string>> lt_pri = new List<SortedList<string, string>>();
    public pt t = new pt();

    protected string xreg_date = DateTime.Now.ToString("yyyy-MM-dd");
    protected string xvisible ="1";
  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.Session["pc"] != null)
        {
            this.pc = this.Session["pc"].ToString();
            if (this.pc == "D004") { lbl_type.Text = "NON-TEXTILE"; }
            else { lbl_type.Text = "TEXTILE"; }
        }
       
        if (this.Session["aid"] != null) { rep_code.Text = Session["aid"].ToString();  }
        if (!Page.IsPostBack)
        {
            SetInitialRow_App_gv();
            SetInitialRow_Inv_gv();
            SetInitialRow_Pri_gv();
            if (this.Session["vid"] != null)  {this.transID = this.Session["vid"].ToString();}
            this.Session["xref"] = Convert.ToInt32(this.Session["xref"]) + 1;
            if (this.Session["xref"].ToString() != "1")
            {
              //  base.Response.Redirect("./violation.aspx");
            }
            if (((this.Session["xapplication"] != null) && (this.Session["xapplication"].ToString() != "")) && (this.transID != this.Session["xapplication"].ToString()))
            {
               // base.Response.Redirect("./violation.aspx");
            }
            this.select_rep_nationality.SelectedIndex = 0x9f;
        if (this.Session["cname"] != null){  this.rep_xname.Text = Session["cname"].ToString(); }
        if (this.Session["agentemail"] != null) {this.txt_rep_email.Text = Session["agentemail"].ToString(); }
        if (this.Session["agentpnumber"] != null) { this.txt_rep_telephone.Text = Session["agentpnumber"].ToString();}
        if (this.Session["product_title"] != null){this.txt_title_of_invention.Text = Session["product_title"].ToString();}      
        }
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
                    if ((txt_name_inv.Text != "") && (txt_name_inv.Text !=null))
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

     protected void SaveAll_Click(object sender, EventArgs e)
    {
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
        else {// base.Response.Redirect("./violation.aspx");
        }
        c_ptinfo.reg_date = xreg_date;
        c_ptinfo.xvisible = xvisible;
     //   c_ptinfo.claim_no = "0";
      //  c_ptinfo.loa_no = "0";
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
        else { //base.Response.Redirect("./violation.aspx");
        }
        c_assinfo.visible = xvisible;

        c_rep.agent_code = rep_code.Text;
        c_rep.xname = rep_xname.Text;
        c_rep.nationality = select_rep_nationality.SelectedValue;
        c_rep.country="160";
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
        else { //base.Response.Redirect("./violation.aspx"); 
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
                else {// base.Response.Redirect("./violation.aspx");
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
                else { //base.Response.Redirect("./violation.aspx"); 
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
                else { //base.Response.Redirect("./violation.aspx");
                }
                c_pri.xvisible = xvisible;
                lt_xpri.Add(c_pri);
            }
        }
        //string pt_succ = t.addNewDesign(lt_xapp, lt_xpri, lt_xinv, c_ptinfo, c_assinfo, c_rep, serverpath, this.transID, this.agent, this.amt, this.log_staffID);
        // if((pt_succ!="")&&(pt_succ!=null))
        // {
        //     Session["new_ptID"] = pt_succ;
        //     Response.Redirect("./application_docs.aspx");
        // }
    }
}