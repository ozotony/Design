<%@ WebHandler Language="C#" Class="EditApplication" %>

using System;
using System.Web;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using ba2xai_cldds_backupModel;
using System.Data;

public class EditApplication : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        var pp = context.Request["vid"];
        String dd = "";
        JavaScriptSerializer ser = new JavaScriptSerializer();
        
        pt zz = new pt();
        List<applicant> ds = zz.getApplicant(pp);
        context.Response.ContentType = "application/json";
            context.Response.Write(ser.Serialize(ds));
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}