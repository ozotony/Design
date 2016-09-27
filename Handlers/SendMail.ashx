<%@ WebHandler Language="C#" Class="SendMail" %>

using System;
using System.Web;
using System.Web.Script.Serialization;

public class SendMail : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        JavaScriptSerializer ser = new JavaScriptSerializer();
        var pp2 = context.Request["vid"];
        var pp4 = context.Request["vid2"];
        var pp5 = context.Request["vid3"];
        pt aa = new pt();
            aa.sendemail(pp4, pp2, pp5);
        context.Response.ContentType = "application/json";
        context.Response.Write(ser.Serialize("ok"));
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}