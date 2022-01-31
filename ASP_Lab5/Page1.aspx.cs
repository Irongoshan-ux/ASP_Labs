using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Lab5
{
    public partial class Page1WithMaster : System.Web.UI.Page
    {
        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);
        }

        protected void Page_PreInit()
        {
            this.MasterPageFile = "~Site2.Master";
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}