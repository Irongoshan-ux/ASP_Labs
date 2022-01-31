using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Lab5
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void OnPreInit(EventArgs e)
        {
            if (Request["masterPage"] != null)
                Page.MasterPageFile = "~/Site2.Master";
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}