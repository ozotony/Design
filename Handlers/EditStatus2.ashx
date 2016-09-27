<%@ WebHandler Language="C#" Class="EditStatus2" %>

using System;
using System.Web;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using ba2xai_cldds_backupModel;

public class EditStatus2 : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        var pp = context.Request["vid"];
        String dd = "";
        JavaScriptSerializer ser = new JavaScriptSerializer();

       zues zz = new zues();
       // List<pwallet> ds = zz.getpwallet(pp);
        String ds = zz.getSurname(pp);
       
        context.Response.ContentType = "application/json";
        context.Response.Write(ser.Serialize(ds));
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}