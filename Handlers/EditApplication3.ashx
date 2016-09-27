<%@ WebHandler Language="C#" Class="EditApplication3" %>

using System;
using System.Web;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using ba2xai_cldds_backupModel;
using System.Data;

public class EditApplication3 : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
         var pp = context.Request["vid"];
        String dd = "";
        JavaScriptSerializer ser = new JavaScriptSerializer();
        
        pt zz = new pt();
        List<inventor> ds = zz.getInventors(pp);
        context.Response.ContentType = "application/json";
            context.Response.Write(ser.Serialize(ds));
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}