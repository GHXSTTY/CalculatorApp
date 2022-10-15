using System.Diagnostics.CodeAnalysis;
using System.IO.Pipes;
using static System.Net.Mime.MediaTypeNames;

namespace CalculatorApp
{
    public partial class CalculatorForm : Form
    {

        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btnNumOne_Click(object sender, EventArgs e)
        {
            if(TextBox.Text == "0")
            {
                TextBox.Text = "1";
            }
            else
            {
                TextBox.Text += 1;
            }
        }

        private void btnNumZero_Click(object sender, EventArgs e)
        {
            if(TextBox.Text == "0")
            {
                TextBox.Text = "0";
            }
            else
            {
                TextBox.Text += 0;
            }
        }

        private void btnNumTwo_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "2";
            }
            else
            {
                TextBox.Text += 2;
            }
        }

        private void btnNumThree_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "3";
            }
            else
            {
                TextBox.Text += 3;
            }
        }

        private void btnNumFour_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "4";
            }
            else
            {
                TextBox.Text += 4;
            }
        }

        private void btnNumFive_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "5";
            }
            else
            {
                TextBox.Text += 5;
            }
        }

        private void btnNumSix_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "6";
            }
            else
            {
                TextBox.Text += 6;
            }
        }

        private void btnNumSeven_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "7";
            }
            else
            {
                TextBox.Text += 7;
            }
        }
        
        private void btnNumEight_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "8";
            }
            else
            {
                TextBox.Text += 8;
            }
        }

        private void btnNumNine_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "9";
            }
            else
            {
                TextBox.Text += 9;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = TextBox.Text;
            }
            else
            {
                // don't remove anything if null or empty

                string text = TextBox.Text;
                if (!String.IsNullOrEmpty(text))
                    TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 1, 1); // remove character by one
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            // if 'TextBox.Text' contains '.' it compile. "!" revert results.So, if "TextBox" don't contains '.' compile.
            if (!TextBox.Text.Contains(".")) 
            {
                TextBox.Text += ".";
            } 
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear(); // remove all value in "TextBox"
            operators = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "x";
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "/";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "+":
                    valueSecond = decimal.Parse(TextBox.Text); 
                    Result = valueFirst + valueSecond;
                    TextBox.Text = Convert.ToString(Result);
                    break;
                case "-":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst - valueSecond;
                    TextBox.Text = Convert.ToString(Result);
                    break;
                case "x":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst * valueSecond;
                    TextBox.Text = Convert.ToString(Result);
                    break;
                case "/":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst / valueSecond;
                    TextBox.Text = Convert.ToString(Result);
                    break;

            }
        }
    }
}