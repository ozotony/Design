<%@ WebHandler Language="C#" Class="EditApplication5" %>

using System;
using System.Web;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using ba2xai_cldds_backupModel;
using System.Data;

public class EditApplication5 : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        var pp = context.Request["vid"];
        String dd = "";
        JavaScriptSerializer ser = new JavaScriptSerializer();
        
        pt zz = new pt();
        List<priority_info> ds = zz.getPriority(pp);
        context.Response.ContentType = "application/json";
            context.Response.Write(ser.Serialize(ds));
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}