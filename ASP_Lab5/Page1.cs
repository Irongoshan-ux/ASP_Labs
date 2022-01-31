using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Lab5
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected override void OnPreInit(EventArgs e)
        {
            Page.MasterPageFile = MasterPageManager.GetMasterPage(Request);

            if (Request["btnGreen"] != null)
                Page.MasterPageFile = "~/Site2.Master";

        }

        protected void Page_PreInit()
        {
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}