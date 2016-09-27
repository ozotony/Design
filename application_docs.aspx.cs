using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Brettle.Web.NeatUpload;
using System.IO;
using System.Web.UI.HtmlControls;

public partial class application_docs : System.Web.UI.Page
{
    public string serverpath; public string doc_path = ""; public string status = "0"; public string ack_status = "0";
       
    public pt t = new pt();
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


    private void upload_Clicked(object sender, EventArgs e)
    {
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
                this.status = "1";
                if (this.status == "1")
                {
                    this.ack_status = "1";
                }
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["loa_newfilename"] != null) { loa_newfilename = Session["loa_newfilename"].ToString(); }
        if (Session["claim_newfilename"] != null) { claim_newfilename = Session["claim_newfilename"].ToString(); }
        if (Session["pct_newfilename"] != null) { pct_newfilename = Session["pct_newfilename"].ToString(); }

        btn_all_doc.Click += new System.EventHandler(this.upload_Clicked);
        this.serverpath = base.Server.MapPath("~/");   
    }

    protected void btn_ack_Click(object sender, EventArgs e)
    {
        if (this.Session["vid"] != null)
        {
            base.Response.Redirect("./tm_acknowledgement.aspx?0001234445XXX43943OPFDSMZXUHSJFDSKFGKSDKGFSDKFSKFDKFD=" + Session["vid"].ToString());
        }
        else
        {
            Response.Redirect("./appstatus.aspx");
        }
    }
}