using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Lab5
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected override void OnPreInit(EventArgs e)
        {
            MasterPageManager.ChangeMasterPage(Request, this);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}