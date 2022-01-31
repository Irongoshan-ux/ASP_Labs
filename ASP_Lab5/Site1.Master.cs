using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Lab5
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_PreInit()
        {
            this.MasterPageFile = "~/Site2.Naster";
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var path = Page.Request.Path;

            Response.Redirect(path);
        }
    }
}