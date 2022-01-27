using System;
using System.Web.UI;

namespace ASP_Lab2
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label5.Text = "";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var startDate = Calendar1.SelectedDate.Date;
            var endDate = Calendar2.SelectedDate.Date;

            if (endDate < startDate || string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                Label5.Text = "Вы ошиблись";
                return;
            }

            Label5.Visible = true;

            double years = (endDate - startDate).Days / 360.0;

            var credit = double.Parse(TextBox1.Text);

            var percents = int.Parse(ListBox1.SelectedValue);

            double percent = percents / 100.0;

            Label5.Text = "Сумма процентов по кредиту: " +
                (credit * percent * years).ToString();
        }
    }
}