using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Lab3_Task4_Updated
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label10.Visible = false;
        }

        protected void LengthValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = args.Value.Length >= 20;
        }

        protected void CustomValidator10_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = false;

            if (args.Value.Length < 6)
            {
                return;
            }

            var numbers = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            foreach(var number in numbers)
            {
                if (args.Value.Contains(number))
                {
                    args.IsValid = true;
                    return;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid) Label10.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";

            Response.Redirect(nameof(WebForm2), false);
        }
    }
}