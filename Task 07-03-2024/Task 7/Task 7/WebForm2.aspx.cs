using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task_7
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x, y;
            if (int.TryParse(TextBox1.Text, out x) && int.TryParse(TextBox2.Text, out y))
            {
                {
                    int add = x + y;
                    Label3.Text = add.ToString();

                }
            }
            else
            {
                Label3.Text = "Invalid input.";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int x, y;
            if (int.TryParse(TextBox1.Text, out x) && int.TryParse(TextBox2.Text, out y))
            {
                {
                    int sub = x - y;
                    Label3.Text = sub.ToString();

                }
            }
            else
            {
                Label3.Text = "Invalid input.";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int x, y;
            if (int.TryParse(TextBox1.Text, out x) && int.TryParse(TextBox2.Text, out y))
            {
                {
                    int multiply = x * y;
                    Label3.Text = multiply.ToString();

                }
            }
            else
            {
                Label3.Text = "Invalid input.";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int x, y;
            if (int.TryParse(TextBox1.Text, out x) && int.TryParse(TextBox2.Text, out y))
            {
                if (y != 0)
                {

                    int divide = x / y;
                    Label3.Text = divide.ToString();

                }
                else
                {
                    Label3.Text = "Invalid input.";
                }
            }
        }
    }
}