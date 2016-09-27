<%@ WebHandler Language="C#" Class="Save_GenericApplication4" %>

using System;
using System.Web;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using System.Transactions;

public class Save_GenericApplication4 : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
         string new_hash = "";
        //  string ccode = ConfigurationManager.AppSettings["ccode"]; string xcode = ConfigurationManager.AppSettings["xcode"];

        JavaScriptSerializer ser = new JavaScriptSerializer();
        var pp = context.Request["vv"];

         if (pp==null || pp=="")
        {

            throw new Exception("Parameter is null");
        }




        

        HttpPostedFile loa_doc = null;
        HttpPostedFile fu_sup_doc = null;
        HttpPostedFile ns_doc = null;
        HttpPostedFile fu_merger_doc = null;
        HttpPostedFile rep_pic = null;
        HttpPostedFile rep2_pic = null;
        HttpPostedFile rep3_pic = null;
        HttpPostedFile rep4_pic = null;
        HttpPostedFile doa_doc = null;
        HttpPostedFile pd_doc = null;








        if (context.Request.Files.Count > 0)
        {
            var files = new List<string>();



            // interate the files and save on the server
            foreach (string file in context.Request.Files)
            {
                if (file == "FileUpload")
                {

                    loa_doc = context.Request.Files[file];
                    //  var vfile = postedFile.FileName.Replace("\"", string.Empty).Replace("'", string.Empty);
                    //   vfile = Stp(vfile);
                    //  string FileName = context.Server.MapPath("~/admin/ag_docz/" + vfile);
                    //   dd.cac_file = "/images/" + vfile;

                    //  dd.cac_file = "admin/ag_docz/" + vfile;

                    //  postedFile.SaveAs(FileName);



                }

               if (file == "FileUpload2")
                {

                    ns_doc = context.Request.Files[file];


                }

                if (file == "FileUpload3")
                {

                   doa_doc = context.Request.Files[file];


                }

                if (file == "FileUpload4")
                {

                pd_doc    = context.Request.Files[file];


                }


                if (file == "FileUpload5")
                {

                    rep_pic = context.Request.Files[file];


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
                //  dd.File_path = "/Images/Patient/" + vfile;




            }
        }

        string sp = "";

        string serverpath = context.Server.MapPath("~/");
        pt tt = new pt();
        //TransactionOptions transactionOptions = new TransactionOptions
        // {
        //     IsolationLevel = IsolationLevel.ReadCommitted,
        //     Timeout = new TimeSpan(0, 15, 0)
        // };
        // TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, transactionOptions);
        String vt = null;


        vt = tt.UpdateTrademarkTx2(pp, loa_doc, ns_doc, pd_doc, doa_doc,rep_pic,rep2_pic,rep3_pic,rep4_pic, serverpath);

        //if (vt != null)
        //{

        //    scope.Complete(); scope.Dispose();
        //}

        //else
        //{
        //    scope.Dispose();
        //    throw new Exception("Test Exception");

        //}



        //  string sp = gg.addAgent(dd);

        //   Ipong.Classes.Retriever kp = new Ipong.Classes.Retriever();



        //  sendemail(dd.Email, dd.CompName, sp);
        try
        {
            //  kp.updateRegistrationSysID4(sp, "PENDING");
        }
        catch (Exception ee)
        {

        }
        context.Response.ContentType = "application/json";
        context.Response.Write(ser.Serialize(vt));
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}