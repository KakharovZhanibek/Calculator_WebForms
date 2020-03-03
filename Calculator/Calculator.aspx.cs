using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class Calculator : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {



        }


        protected void Number_0_btn_Click(object sender, EventArgs e)
        {
            tbx_expression.Text += 0.ToString();
        }

        protected void Number_1_btn_Click(object sender, EventArgs e)
        {
            tbx_expression.Text += 1.ToString();
        }

        protected void Number_2_btn_Click(object sender, EventArgs e)
        {
            tbx_expression.Text += 2.ToString();
        }

        protected void Number_3_btn_Click(object sender, EventArgs e)
        {
            tbx_expression.Text += 3.ToString();
        }

        protected void Number_4_btn_Click(object sender, EventArgs e)
        {
            tbx_expression.Text += 4.ToString();
        }

        protected void Number_5_btn_Click(object sender, EventArgs e)
        {
            tbx_expression.Text += 5.ToString();
        }

        protected void Number_6_btn_Click(object sender, EventArgs e)
        {
            tbx_expression.Text += 6.ToString();
        }

        protected void Number_7_btn_Click(object sender, EventArgs e)
        {
            tbx_expression.Text += 7.ToString();
        }

        protected void Number_8_btn_Click(object sender, EventArgs e)
        {
            tbx_expression.Text += 8.ToString();
        }

        protected void Number_9_btn_Click(object sender, EventArgs e)
        {
            tbx_expression.Text += 9.ToString();
        }

        protected void Multiplication_btn_Click(object sender, EventArgs e)
        {
            tbx_expression.Text += "*";
        }

        protected void Division_btn_Click(object sender, EventArgs e)
        {
            tbx_expression.Text += "/";
        }

        protected void Addition_btn_Click(object sender, EventArgs e)
        {
            tbx_expression.Text += "+";
        }

        protected void Subtraction_btn_Click(object sender, EventArgs e)
        {
            tbx_expression.Text += "-";
        }

        protected void Clear_btn_Click(object sender, EventArgs e)
        {
            tbx_expression.Text = "";
        }

        protected void Result_btn_Click(object sender, EventArgs e)
        {
            List<string> expression = new List<string>();
            int it = 0;

            for (int i = 0; i < tbx_expression.Text.Length; i++)
            {
                if ((int)tbx_expression.Text[i] > 47 && (int)tbx_expression.Text[i] < 58)
                {
                    expression.Add("");
                    expression[it] += tbx_expression.Text[i];

                }
                else
                {
                    it++;
                    expression[it] += tbx_expression.Text[i];
                }
            }
            tbx_expression.Text = GetResult(expression);

        }
        private string GetResult(List<string> expression)
        {
            if (expression.Contains("*"))
            {
                int MIndex = expression.IndexOf("*");
                string res = (Int32.Parse(expression[MIndex - 1]) * Int32.Parse(expression[MIndex + 1])).ToString();
                expression.RemoveAt(MIndex - 1);
                expression.RemoveAt(MIndex + 1);
                expression[MIndex] = res;
            }
            if (expression.Contains("/"))
            {
                int DIndex = expression.IndexOf("/");
                string res = (Int32.Parse(expression[DIndex - 1]) / Int32.Parse(expression[DIndex + 1])).ToString();
                expression.RemoveAt(DIndex - 1);
                expression.RemoveAt(DIndex + 1);
                expression[DIndex] = res;
            }
            //if (!expression.Contains("*") && !expression.Contains("/"))
            //{
            int temp = 0;
            for (int i = 0; i < expression.Count; i++)
            {
                if (Int32.TryParse(expression[i], out temp) == false)
                {
                    if (expression[i] == "+")
                    {
                        string res = (Convert.ToInt32(expression[i - 1]) + Convert.ToInt32(expression[i + 1])).ToString();
                        expression.RemoveAt(i - 1);
                        expression.RemoveAt(i + 1);
                        expression[i] = res;
                    }
                    if (expression[i] == "-")
                    {
                        string res = (Convert.ToInt32(expression[i - 1]) - Convert.ToInt32(expression[i + 1])).ToString();
                        expression.RemoveAt(i - 1);
                        expression.RemoveAt(i + 1);
                        expression[i] = res;
                    }
                }
            }
            //}
            return expression[0];
        }
    }
}