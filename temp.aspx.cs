using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class temp : System.Web.UI.Page
{
    public string xvalue = "";
    public string xconfirm = "0";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (selectPtType.SelectedValue == "D003")
        {
            xvalue = "22000";
        }
        else
        {
            xvalue = "20000";
        }
    }
    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        xconfirm = "1";
    }
}