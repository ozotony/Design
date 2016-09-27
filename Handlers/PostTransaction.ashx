<%@ WebHandler Language="C#" Class="PostTransaction" %>

using System;
using System.Web;
using System.Linq;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using ba2xai_cldds_backupModel;

public class PostTransaction : IHttpHandler, System.Web.SessionState.IRequiresSessionState  {
    HttpPostedFile loa_doc = null;
    HttpPostedFile doa_doc = null;
    HttpPostedFile pd_doc = null;
    HttpPostedFile rep1_pic = null;
    HttpPostedFile rep2_pic = null;
    HttpPostedFile ns_doc = null;
    HttpPostedFile rep3_pic = null;
    HttpPostedFile rep4_pic = null;
    string adminid = "";
    pt t = new pt();

    public void ProcessRequest (HttpContext context) {
        JavaScriptSerializer ser = new JavaScriptSerializer();
        var pp =( context.Request["vid"]);
        var pp2 =( context.Request["vid2"]);
        var pp3 =( context.Request["vid3"]);
         var pp4 =( context.Request["vid4"]);
        if (context.Session["pwalletID"] != null)
        {
            adminid = Convert.ToString(context.Session["pwalletID"]);

        }
        //   List<String>dd = ser.Deserialize<List<String>>(pp);

        Vapplicant[] dd = ser.Deserialize<Vapplicant[]>(pp);
        Vinventor[] dd2 = ser.Deserialize<Vinventor[]>(pp2);
        VptInfo[] dd3 = ser.Deserialize<VptInfo[]>(pp3);
        pt zz = new pt();

        ba2xai_cldds_backupEntities _db = new ba2xai_cldds_backupEntities();
        Int64 tr = Convert.ToInt64(dd3[0].xID);
        var cc = (from t1 in _db.pt_info

                  where t1.xID==tr
                  select t1).FirstOrDefault();
        List<pt.Stage> ppx  = t.getPwalletDetailsByID(cc.log_staff);

        if (context.Request.Files.Count > 0)
        {
            var files = new List<string>();
            foreach (string file in context.Request.Files)
            {
                if (file == "FileUpload")
                {

                    loa_doc = context.Request.Files[file];



                }

                if (file == "FileUpload2")
                {

                    doa_doc = context.Request.Files[file];


                }

                if (file == "FileUpload3")
                {

                    ns_doc = context.Request.Files[file];


                }

                if (file == "FileUpload4")
                {

                    pd_doc = context.Request.Files[file];


                }


                if (file == "FileUpload5")
                {

                    rep1_pic = context.Request.Files[file];


                }


                if (file == "FileUpload6")
                {

                    rep2_pic = context.Request.Files[file];


                }


                if (file == "FileUpload7")
                {

                    rep3_pic = context.Request.Files[file];


                }

                if (file == "FileUpload8")
                {

                    rep4_pic = context.Request.Files[file];


                }






            }
            string serverpath = context.Server.MapPath("~/");
            zz.UpdateTrademarkTx(dd3[0].xID, loa_doc, doa_doc, pd_doc, rep1_pic, rep2_pic, rep3_pic, rep4_pic, serverpath);
        }
        foreach (Vapplicant sd in dd)
        {
            zz.UpdateApplicant(sd);

        }

        foreach (Vinventor sd in dd2)
        {
            zz.UpdateInventor(sd);

        }

        foreach (VptInfo sd in dd3)
        {
            zz.UpdatePtInfo(sd);

        }
        t.activity_log(pp4, "Edit Application", "Update", ppx[0].ID, ppx[0].data_status);
        context.Response.ContentType = "text/plain";
        context.Response.Write("Hello World");
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}