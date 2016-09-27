<%@ WebHandler Language="C#" Class="EditStatus" %>

using System;
using System.Web;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using ba2xai_cldds_backupModel;

public class EditStatus : IHttpHandler {

    public void ProcessRequest(HttpContext context)
    {
        var pp = context.Request["vid"];
        String dd = "";
        JavaScriptSerializer ser = new JavaScriptSerializer();

        pt zz = new pt();
        List<pwallet> ds = zz.getpwallet(pp);
        context.Response.ContentType = "application/json";
        context.Response.Write(ser.Serialize(ds));
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}