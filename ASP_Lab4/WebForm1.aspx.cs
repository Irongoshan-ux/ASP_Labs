using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Lab4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Random random;

        public WebForm1()
        {
            random = new Random();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Application.AllKeys.Contains("Mistakes"))
            {
                Application.Add("Mistakes", 0);
            }
        }

        public double GetResult(string operation,
                                double value1,
                                double value2)
        {
            switch (operation)
            {
                case "+": return value1 + value2;
                case "-": return value1 - value2;
                case "*": return value1 * value2;
                case "/": return value1 / value2;

                default: throw new ArgumentException("Invalid operation");
            }
        }

        public string GetOperator(Operations operation)
        {
            switch (operation)
            {
                case Operations.Sum: return "+";
                case Operations.Substract: return "-";
                case Operations.Multiple: return "*";
                case Operations.Divide: return "/";

                default: throw new ArgumentException();
            }
        }

        public Operations GetRandomOperation()
        {
            var operationNumber = random.Next(0, 3);

            switch (operationNumber)
            {
                case 0:
                    return Operations.Sum;
                case 1:
                    return Operations.Multiple;
                case 2:
                    return Operations.Substract;
                case 3:
                    return Operations.Divide;

                default: throw new InvalidOperationException();
            }
        }

        protected void Reset_Click(object sender, EventArgs e)
        {
            IncrementMistake();

            Response.Redirect(nameof(WebForm1), true);
        }

        private void IncrementMistake()
        {
            var isInt = int.TryParse(GetMistakes(), out int mistakes);

            if (isInt)
            {
                Application["Mistakes"] = mistakes + 1;
            }
            else
            {
                Application.Add("Mistakes", 1);
            }
        }

        public string GetMistakes()
        {
            try
            {
                return Application["Mistakes"].ToString();
            }
            catch
            {
                Application.Add("Mistakes", 1);
                return "1";
            }
        }

        protected override void OnPreRenderComplete(EventArgs e)
        {
            if (Message.Visible || CorrectResultsCount.Visible) return;

            var firstNumber = random.Next(-10, 10);
            var secondNumber = random.Next(-10, 10);

            FirstNumber.Text = firstNumber.ToString();
            SecondNumber.Text = secondNumber.ToString();

            Operation.Text = GetOperator(GetRandomOperation());

            CorrectResult.Text = GetResult(Operation.Text, firstNumber, secondNumber).ToString();

            base.OnPreRenderComplete(e);
        }

        protected void Result_TextChanged(object sender, EventArgs e)
        {
            SetResultVisibility(false);

            if (Result.Text.Equals(CorrectResult.Text))
            {
                if (string.IsNullOrWhiteSpace(HiddenResultsCount.Value))
                {
                    HiddenResultsCount.Value = "1";
                }
                else HiddenResultsCount.Value = (int.Parse(HiddenResultsCount.Value) + 1).ToString();

                Message.Visible = false;

                OnPreRenderComplete(EventArgs.Empty);
            }
            else
            {
                Message.Visible = true;
                IncrementMistake();
            }
        }

        protected void Results_Click(object sender, EventArgs e)
        {
            CorrectResultsCount.Text = HiddenResultsCount.Value.ToString();

            SetResultVisibility(true);
        }

        public void SetResultVisibility(bool visible)
        {
            CorrectResultLabel.Visible = visible;
            CorrectResultsCount.Visible = visible;
        }

        protected void Mistakes_Click(object sender, EventArgs e)
        {
            Response.Redirect(nameof(MistakesPage) + "?mistakes=" + GetMistakes());
        }
    }

    public enum Operations
    {
        Sum,
        Multiple,
        Substract,
        Divide
    }
}