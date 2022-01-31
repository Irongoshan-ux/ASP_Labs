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
            if (Request["btnGreen"] != null)
                Page.MasterPageFile = "~/Site2.Master";
        }

        protected void Page_PreInit()
        {
            if (Request.Headers["MasterPage"] == "1")
            {
                Page.MasterPageFile = "~/Site1.Master";
            }

            if (Request.Headers["MasterPage"] == "2")
            {
                Page.MasterPageFile = "~/Site2.Master";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MasterPageManager.ChangeMasterPage(Request, 2);

            var path = Page.Request.Path;
            Debug.WriteLine(Request.Headers);

            Response.Headers.Add("MasterPage", "2");

            Response.Redirect(path);
        }
    }
}