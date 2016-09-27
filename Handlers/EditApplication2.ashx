<%@ WebHandler Language="C#" Class="EditApplication2" %>

using System;
using System.Web;
using ba2xai_cldds_backupModel;
using System.Web.Script.Serialization;
using System.Data;
using System.Collections.Generic;

public class EditApplication2 : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
         var pp = context.Request["vid"];
        String dd = "";
        JavaScriptSerializer ser = new JavaScriptSerializer();
        
        pt zz = new pt();
        List<pt_info> ds = zz.getPtInfo(pp);
        context.Response.ContentType = "application/json";
            context.Response.Write(ser.Serialize(ds));
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}