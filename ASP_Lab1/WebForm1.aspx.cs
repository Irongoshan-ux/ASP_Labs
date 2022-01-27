using System;
using System.Diagnostics;
using System.Web.UI;

namespace ASP_Lab1
{
    public partial class WebForm1 : Page
    {
        protected void Page_PreInit()
        {
            Debug.WriteLine("Page preinit");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page_Load<br>");

            Response.Write("Page.IsPostBack " + Page.IsPostBack + "<br>");
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("Load_Complete<br>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Button1_Click<br>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page_PreRender<br>");
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            Debug.WriteLine($"Page {nameof(WebForm1)} unloaded.");
        }

        protected void Page_Error(object sender, EventArgs e)
        {
            Response.Write("Page_Error<br>");
        }

        protected void Page_CommitTransaction(object sender, EventArgs e)
        {
            Response.Write("Page_CommitTransaction<br>");
        }

        protected void Page_AbortTransaction(object sender, EventArgs e)
        {
            Response.Write("Page_AbortTransaction<br>");
        }

        protected void Page_DataBinding(object sender, EventArgs e)
        {
            Response.Write("Page_Data_Binding<br>");
        }

        protected void Page_Disposed()
        {
            Response.Write("Page_Disposed<br>");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write(TextBox1.Text + " with ENTER <br>");
        }

        protected void TextBox1_Input()
        {
            Response.Write(TextBox1.Text + " with ENTER <br>");
        }
    }
}