using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Lab5
{
    public partial class Site2 : System.Web.UI.MasterPage
    {
        protected void Page_PreInit()
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.MasterPageFile = "~/Site2.Naster";
        }
    }
}