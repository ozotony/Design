﻿<%@ WebHandler Language="C#" Class="GetData" %>

using System;
using System.Web;

public class GetData : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        System.Web.Script.Serialization.JavaScriptSerializer ser = new System.Web.Script.Serialization.JavaScriptSerializer();
        zues z2 = new zues();
     System.Collections.Generic.List<zues.PtInfo> kk=z2.getPtInfoRSX("1", "Fresh", "1", "1");


        context.Response.ContentType = "application/json";
        context.Response.Write(ser.Serialize(kk));
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}