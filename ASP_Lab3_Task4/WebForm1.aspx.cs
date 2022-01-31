using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace ASP_Lab3_Task1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator3_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = false;

            if (args.Value.Length < 6)
            {
                return;
            }

            var numbers = new string[] { "0","1","2","3","4","5","6","7","8","9"};

            args.IsValid = numbers.Contains(args.Value);
        }
    }
}