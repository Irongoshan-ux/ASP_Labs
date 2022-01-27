using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Lab3_Task1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Password_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value.Length < 6)
            {
                args.IsValid = false; 
                return;
            }

            var numbers = new string[] { "0","1","2","3","4","5","6","7","8","9"};

            if (numbers.Contains(args.Value))
            {
                args.IsValid = true;
            }
        }
    }
}