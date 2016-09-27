<%@ WebHandler Language="C#" Class="GetCountry" %>

using System;
using System.Web;

using System.Web.Script.Serialization;
using System.Collections.Generic;
using ba2xai_cldds_backupModel;
using System.Data;

public class GetCountry : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
          JavaScriptSerializer ser = new JavaScriptSerializer();
        
        pt zz = new pt();
        List<country> ds = zz.getCountry2();
        context.Response.ContentType = "application/json";
            context.Response.Write(ser.Serialize(ds));
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}