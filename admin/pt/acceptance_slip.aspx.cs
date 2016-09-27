using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_pt_acceptance_slip : System.Web.UI.Page
{
    public string admin = "";
    public int back;
    public string criteria = "";
    public string criteria_type = "";
    public string dateFrom = "";
    public string dateFromArr = "";
    public string dateTo = "";
    public string dateToArr = "";
    public Int64 dis;
    public string enrolleeRS = "";
    public string enrolleeRS1 = "";
    public Int64 eu;
    public int export;
    public string kw = "";
    public string lga_id = "";
    public Int64 limit;
    public List<zues.PtInfo> lt_mi = new List<zues.PtInfo>();
    public Int64 nume;
    public string r_sectorRS = "";
    public string row_enrolleeRS;
    public string select_search = "";
    public int selectLga;
    public int vpages=0;
    public string selectzone = "";
    public string sh = "";
    public int totsearch;
    public string touch;
    public string x_enrolleeRS;
    public string xRS = "";
    public zues z = new zues();
    public List<string> pages = new List<string>();
    public List<XrowCount> pz = new List<XrowCount>();

    protected void Page_Load(object sender, EventArgs e)
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
        //Eu is the current page, Limit is the page limit and nume is the total RS count
        this.limit = 50; this.nume = this.z.getPtInfoRSCnt("4", "Certified"); Int64 pg = nume / limit; if ((pg > 0) && (nume > pg * limit)) { pg = pg + 1; }
        for (Int64 i = 1; i <= pg; i++)
        {
            string url = "<a href=\"#\" onclick=\"doPostResults(\'" + i + "\');\">" + i + "</a>";
            pages.Add(url);
        }
        if (Request.Params["eu"] != null)
        { this.eu = Convert.ToInt64(Request.Params["eu"].ToString()) - 1; }
        else { this.eu = 0; }
        this.dis = this.eu * limit + 1; limit = eu * limit + limit;
        if (Session["pwalletID"] != null)
        {
            if (Session["pwalletID"].ToString() != "")
            { this.admin = Session["pwalletID"].ToString(); }
            else
            { base.Response.Redirect("./lo.aspx"); }
        }
        else
        { base.Response.Redirect("./lo.aspx"); }

        this.Session["lt_m"] = null;
        this.Session["x_cnt"] = null;
        int kk = z.getNew_RowCount("4", "Certified").Count();
        //  this.lt_m = this.z.getNew_MarkInfoRtmRSX(this.stage, this.data_status, 0, this.max);


      //  this.Session["x_cnt"] = this.x_cnt = this.lt_m.Count;
      //  this.Session["lt_m"] = this.lt_m;
       // this.lt_mi = this.z.getPtInfoRSX2("4", "Certified", 1, 4);

        ViewState["TotalRecord"] = kk;// lt_mi.Count;// (z.getNew_RowCount("4", "Certified")).Count;// GetTotalCount();
        ViewState["NoOfRecord"] = 2;

        PopulateData(1, 2);

        AddpagingButton();
        
     //   this.lt_mi = this.z.getPtInfoRSX("4", "Certified", dis.ToString(), limit.ToString());

    }

    protected void b_click(object sender, EventArgs e)
    {
        // this is for Get data from Database on button (paging button) click
        string pageNo = ((Button)sender).CommandArgument;
        PopulateData(Convert.ToInt32(pageNo), 2);
    }
    private void AddpagingButton()
    {
        // this method for generate custom button for Custom paging in Gridview
        int totalRecord = 0;
        int noofRecord = 0;
        totalRecord = ViewState["TotalRecord"] != null ? (int)ViewState["TotalRecord"] : 0;
        noofRecord = ViewState["NoOfRecord"] != null ? (int)ViewState["NoOfRecord"] : 0;
        int pages = 0;
        if (totalRecord > 0 && noofRecord > 0)
        {
            // Count no of pages 
            pages = (totalRecord / noofRecord) + ((totalRecord % noofRecord) > 0 ? 1 : 0);
            vpages = pages;
            for (int i = 0; i < pages; i++)
            {
                Button b = new Button();
                b.Text = (i + 1).ToString();
                b.CommandArgument = (i + 1).ToString();
                b.ID = "Button_" + (i + 1).ToString();
                b.Click += new EventHandler(this.b_click);
                Panel1.Controls.Add(b);
            }
        }

    }

    protected void gvX_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "TmViewClick")
        {
            GridViewRow namingContainer = (GridViewRow)((ImageButton)e.CommandSource).NamingContainer;
            int rowIndex = namingContainer.RowIndex;
            string str = e.CommandArgument.ToString();
            base.Response.Redirect("registrar_issue.aspx?x=" + str);
        }
    }

    
    private Int32 GetTotalCount()
    {

        zues z = new zues();

        return Convert.ToInt32(this.z.getPtInfoRSCnt("4", "Certified"));

    }
    private void PopulateData(int pageNo, int noOfRecord)
    {
        eu = pageNo;
        pz = z.getNew_RowCount("4", "Certified");
        String vcount = Convert.ToString(pz.Count);
        String vstart = Convert.ToString(((pageNo - 1) * noOfRecord) + 1);
        String vend = Convert.ToString(pageNo * noOfRecord);
        XrowCount aa = (from c in pz where c.RowRanks == vstart select c).FirstOrDefault();
        XrowCount ab = (from c in pz where c.RowRanks == vend select c).FirstOrDefault();
        if (aa != null && ab != null)
        {
            pageNo = Convert.ToInt32(aa.Tblld);
            noOfRecord = Convert.ToInt32(ab.Tblld);

        }

        if (aa != null && (!(ab != null)))
        {
            pageNo = Convert.ToInt32(aa.Tblld);
            XrowCount ab2 = (from c in pz where c.RowRanks == vcount select c).FirstOrDefault();
            noOfRecord = Convert.ToInt32(ab2.Tblld);

        }

        // this.lt_m = this.z.getNew_AcceptanceManageRSX(pageNo, noOfRecord, GetTotalCount());
        // this.lt_m = this.z.getNew_AcceptanceManageRSX(pageNo, noOfRecord, GetTotalCount());

        lt_mi = this.z.getPtInfoRSX2("4", "Certified", pageNo, noOfRecord);

        List<zues.PtInfo> pp = new List<zues.PtInfo>();

        foreach (var ap in lt_mi)
        {
            if (ap.log_staff != "")
            {

                ap.doa_doc = z.getPtOfficeByMID(ap.log_staff);
            }

            else
            {
                ap.doa_doc = "None";

            }

            pp.Add(ap);

        }

        // this.Session["x_cnt"] = (z.getNew_RowCount()).Count;// GetTotalCount();
        this.nume = GetTotalCount();
        this.Session["lt_mi"] = pp;

        gvX2.DataSource = pp;
        gvX2.DataBind();
       // this.gvX.DataSource = this.lt_m;
       // this.gvX.DataBind();

    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        List<string> fulltext = new List<string>();
        string item = kword.Value.Replace("'", "");
        dateFrom = z.formatSearchDate(datepickerFrom.Value);
        dateTo = z.formatSearchDate(datepickerTo.Value);
        if ((dateTo == "") || (dateTo == null))
        {
            dateTo = DateTime.Today.Date.ToString("yyyy-MM-dd");
        }
        foreach (string str2 in item.Split(new char[] { ' ' }))
        {
            if (str2 != "")
            {
                fulltext.Add(str2);
            }
        }

        if (selectSearchCriteria.SelectedValue == "product_title")
        {
            lt_mi = z.getAdminSearchPtInfoRS("4", "Certified", selectSearchCriteria.SelectedValue, fulltext, dateFrom, dateTo);
            if (lt_mi.Count() > 0)
            {
                criteria = lt_mi.Count() + " result(s) found for search criteria (" + kword.Value + ")!!";
            }
            else
            {
                criteria = "No result found for search criteria (" + kword.Value + ")!!";
            }
        }
        else
        {
            if (fulltext.Count() == 1)
            {
                if (lt_mi.Count() > 0)
                {
                    lt_mi = z.getAdminSearchPtInfoRS("4", "Certified", selectSearchCriteria.SelectedValue, fulltext, dateFrom, dateTo);
                }
                else
                {
                    criteria = "No result found for search criteria (" + kword.Value + ")!!";
                }
            }
            else
            {
                criteria = "The Application number cannot be more one (1) !!";
            }
        }
    }

    protected void btnReloadPage_Click(object sender, EventArgs e)
    {
       // this.lt_mi = this.z.getPtInfoRSX("4", "Certified", dis.ToString(), limit.ToString());
        PopulateData(1, 2);
    }
}