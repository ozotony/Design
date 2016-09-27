using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        pt pk = new pt();

        List<pt.PtInfo> dd = pk.getPtInfoBy();


        foreach(var dx in dd) {

            pk.updatePtReg2(dx.xID, dx);
        }
    }
}