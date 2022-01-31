using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Lab5
{
    public partial class Site2 : System.Web.UI.MasterPage
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Request.Headers["MasterPage"] == "2")
            {
                Page.MasterPageFile = "~/Site2.Master";
            }

            if (Request.Headers["MasterPage"] == "1")
            {
                Page.MasterPageFile = "~/Site1.Master";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}