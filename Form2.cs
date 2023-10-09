using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form2 : Form
    {
        //Nullable<double> nDown = 0;
        Nullable<double> nUp = 0;
        string operation = "";
        int Count = 1;
        int countResult = 1;
        int countDot = 1;
        private void count()
        {
            if (Count == 2)
            {
                nUp = 0;
                txtbDown.Clear();
                txtbUp.Clear();
                operation = "";
                Count = 1;
                countResult = 1;

            }
        }



    private Nullable<double> Calculate(Nullable<double> n1, Nullable<double> n2, string operation)
        {
            try
            {
                switch (operation)
                {
                    case "+":
                        return n1 + n2;
                    case "-":
                        return n1 - n2;
                    case "*":
                        return n1 * n2;
                    case "/":
                        if (n2 != 0)
                        {
                            return n1 / n2;
                        }
                        else
                        {
                            // Handle division by zero
                            throw new InvalidOperationException("Division by zero is not allowed.");
                        }
                    default:
                        // Handle unsupported operation
                        throw new ArgumentException("Unsupported operation: " + operation);
                }
            }
            catch (Exception e)
            {
                // You can log the exception or handle it as needed.
                // You should not show a message box here; it's better to handle UI in the calling code.
                throw; // Rethrow the exception to propagate it up the call stack.
            }
        }
        private void whenCLickOnNUmber(string tag)
        {
            txtbDown.Text = txtbDown.Text + tag;
            txtbUp.Text = txtbUp.Text + tag;
            
        }


        private void whenCLickOnOp(string tag)
        {
            if (double.TryParse(txtbDown.Text, out double result))
            {
                nUp = result;

            }

            string s = txtbUp.Text.Substring(txtbUp.Text.Length - 1);
            if (!double.TryParse(s, out double r))
            {
                txtbUp.Text = txtbUp.Text.Substring(0, txtbUp.Text.Length - 1);
            }


            txtbUp.Text = txtbUp.Text + tag;
            operation = tag;
            txtbDown.Text = "";
            countDot = 1;
        }

        

        
    public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            whenCLickOnOp("/");
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            if (countDot == 1) { whenCLickOnNUmber("."); }
            countDot = 2;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            count();
           whenCLickOnNUmber("0");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            count();
            whenCLickOnNUmber("1");
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            count();
            whenCLickOnNUmber("2");
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            count();
             whenCLickOnNUmber("3");
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            count();
            whenCLickOnNUmber("4");
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            count();
            whenCLickOnNUmber("5");
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            count();
            whenCLickOnNUmber("6");
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            count();
            whenCLickOnNUmber("7");
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            count();
            whenCLickOnNUmber("8");
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            count();
            whenCLickOnNUmber("9");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            whenCLickOnOp("*");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            whenCLickOnOp("+");
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            whenCLickOnOp("-");
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

            if (countResult == 1)
            {
                if (double.TryParse(txtbDown.Text, out double result))
                {
                    txtbDown.Text = Calculate(nUp, result, operation).ToString();
                }
                Count = 2;
                countResult = 2;


            }
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            nUp = 0;
            txtbDown.Clear();
            txtbUp.Clear();
            operation = "";
        }
    }
}
