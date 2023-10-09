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
    public partial class Form1 : Form
    {
       
        
        Nullable<float> nDown = 0;
        Nullable<float> nUp = 0;

        string operation = "";
        private Nullable<float> Calculate(Nullable<float>n1, Nullable<float> n2, string operation)
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
            lbMain.Text = lbMain.Text+ tag;
            float n = float.Parse(lbMain.Text);
            if (n > Int64.MaxValue)
            {
                MessageBox.Show("it is too high");
            }
            else
            {
                float d= float.Parse(lbMain.Text);
                nDown = d;
            }

        }
        private void whenCLickOnOp(string tag)
        {
            if (!float.TryParse(lbMain.Text, out float result))
            {
                lbUp.Text = lbMain.Text.Substring(0, lbMain.Text.Length - 1);

            }
            lbUp.Text = lbMain.Text + tag;
            nUp = nDown;
            nDown =null;
            operation = tag;
            lbMain.Text = "";

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            whenCLickOnNUmber(rbtn9.Tag.ToString());
        }

        private void rbtn1_Click(object sender, EventArgs e)
        {
            whenCLickOnNUmber(rbtn1.Tag.ToString());
        }

        private void rbtn2_Click(object sender, EventArgs e)
        {
            whenCLickOnNUmber(rbtn2.Tag.ToString());
        }

        private void rbtn3_Click(object sender, EventArgs e)
        {
            whenCLickOnNUmber(rbtn3.Tag.ToString());
        }

        private void rbtn4_Click(object sender, EventArgs e)
        {
            whenCLickOnNUmber(rbtn4.Tag.ToString());
        }

        private void rbtn5_Click(object sender, EventArgs e)
        {
            whenCLickOnNUmber(rbtn5.Tag.ToString());
        }

        private void rbtn6_Click(object sender, EventArgs e)
        {
            whenCLickOnNUmber(rbtn6.Tag.ToString());
        }

        private void rbtn7_Click(object sender, EventArgs e)
        {
            whenCLickOnNUmber(rbtn7.Tag.ToString());
        }

        private void rbtn8_Click(object sender, EventArgs e)
        {
            whenCLickOnNUmber(rbtn8.Tag.ToString());
        }

        private void rbtn0_Click(object sender, EventArgs e)
        {
            whenCLickOnNUmber(rbtn0.Tag.ToString());
        }

        private void rbtnSub_Click(object sender, EventArgs e)
        {
            whenCLickOnOp(rbtnSub.Tag.ToString());
        }

        private void rbtnAdd_Click(object sender, EventArgs e)
        {
            whenCLickOnOp(rbtnAdd.Tag.ToString());
        }

        private void rbtnMult_Click(object sender, EventArgs e)
        {
            whenCLickOnOp(rbtnMult.Tag.ToString());
        }

        private void rbtnDiv_Click(object sender, EventArgs e)
        {
            whenCLickOnOp(rbtnDiv.Tag.ToString());
        }

        private void rbtnDot_Click(object sender, EventArgs e)
        {
            whenCLickOnNUmber(rbtnDot.Tag.ToString());
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Nullable<float>n= Calculate(nUp, nDown, operation);
            lbMain.Text = n.ToString();
            
        }
    }
}
