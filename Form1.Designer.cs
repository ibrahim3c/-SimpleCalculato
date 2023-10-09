namespace Calculator2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEqual = new System.Windows.Forms.Button();
            
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbUp = new System.Windows.Forms.Label();
            this.lbMain = new System.Windows.Forms.Label();
            this.rbtnDot = new Calculator2.RoundButton();
            this.rbtnSub = new Calculator2.RoundButton();
            this.rbtnAdd = new Calculator2.RoundButton();
            this.rbtnDiv = new Calculator2.RoundButton();
            this.rbtnMult = new Calculator2.RoundButton();
            this.rbtn8 = new Calculator2.RoundButton();
            this.rbtn2 = new Calculator2.RoundButton();
            this.rbtn3 = new Calculator2.RoundButton();
            this.rbtn4 = new Calculator2.RoundButton();
            this.rbtn5 = new Calculator2.RoundButton();
            this.rbtn6 = new Calculator2.RoundButton();
            this.rbtn9 = new Calculator2.RoundButton();
            this.rbtn7 = new Calculator2.RoundButton();
            this.rbtn0 = new Calculator2.RoundButton();
            this.rbtn1 = new Calculator2.RoundButton();
            this.rbtnC = new Calculator2.RoundButton();
            this.panel1.SuspendLayout();
          
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 41);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(510, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEqual.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.Color.White;
            this.btnEqual.Location = new System.Drawing.Point(0, 541);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(550, 46);
            this.btnEqual.TabIndex = 1;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // htmlPanel1
            // 
           
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.lbUp);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 50);
            this.panel2.TabIndex = 1;
            // 
            // lbUp
            // 
            this.lbUp.AutoSize = true;
            this.lbUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUp.ForeColor = System.Drawing.Color.Black;
            this.lbUp.Location = new System.Drawing.Point(8, 19);
            this.lbUp.Name = "lbUp";
            this.lbUp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbUp.Size = new System.Drawing.Size(19, 20);
            this.lbUp.TabIndex = 2;
            this.lbUp.Text = "0";
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain.ForeColor = System.Drawing.Color.Black;
            this.lbMain.Location = new System.Drawing.Point(12, 73);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(27, 29);
            this.lbMain.TabIndex = 0;
            this.lbMain.Text = "0";
            // 
            // rbtnDot
            // 
            this.rbtnDot.BackColor = System.Drawing.Color.Gray;
            this.rbtnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDot.ForeColor = System.Drawing.Color.White;
            this.rbtnDot.Location = new System.Drawing.Point(245, 159);
            this.rbtnDot.Name = "rbtnDot";
            this.rbtnDot.Size = new System.Drawing.Size(59, 55);
            this.rbtnDot.TabIndex = 18;
            this.rbtnDot.Tag = ".";
            this.rbtnDot.Text = ".";
            this.rbtnDot.UseVisualStyleBackColor = false;
            this.rbtnDot.Click += new System.EventHandler(this.rbtnDot_Click);
            // 
            // rbtnSub
            // 
            this.rbtnSub.BackColor = System.Drawing.Color.Gray;
            this.rbtnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSub.ForeColor = System.Drawing.Color.White;
            this.rbtnSub.Location = new System.Drawing.Point(12, 255);
            this.rbtnSub.Name = "rbtnSub";
            this.rbtnSub.Size = new System.Drawing.Size(59, 55);
            this.rbtnSub.TabIndex = 17;
            this.rbtnSub.Tag = "-";
            this.rbtnSub.Text = "-";
            this.rbtnSub.UseVisualStyleBackColor = false;
            this.rbtnSub.Click += new System.EventHandler(this.rbtnSub_Click);
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.BackColor = System.Drawing.Color.Gray;
            this.rbtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAdd.ForeColor = System.Drawing.Color.White;
            this.rbtnAdd.Location = new System.Drawing.Point(12, 159);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(59, 55);
            this.rbtnAdd.TabIndex = 16;
            this.rbtnAdd.Tag = "+";
            this.rbtnAdd.Text = "+";
            this.rbtnAdd.UseVisualStyleBackColor = false;
            this.rbtnAdd.Click += new System.EventHandler(this.rbtnAdd_Click);
            // 
            // rbtnDiv
            // 
            this.rbtnDiv.BackColor = System.Drawing.Color.Gray;
            this.rbtnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDiv.ForeColor = System.Drawing.Color.White;
            this.rbtnDiv.Location = new System.Drawing.Point(479, 255);
            this.rbtnDiv.Name = "rbtnDiv";
            this.rbtnDiv.Size = new System.Drawing.Size(59, 55);
            this.rbtnDiv.TabIndex = 15;
            this.rbtnDiv.Tag = "/";
            this.rbtnDiv.Text = "/";
            this.rbtnDiv.UseVisualStyleBackColor = false;
            this.rbtnDiv.Click += new System.EventHandler(this.rbtnDiv_Click);
            // 
            // rbtnMult
            // 
            this.rbtnMult.BackColor = System.Drawing.Color.Gray;
            this.rbtnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMult.ForeColor = System.Drawing.Color.White;
            this.rbtnMult.Location = new System.Drawing.Point(478, 159);
            this.rbtnMult.Name = "rbtnMult";
            this.rbtnMult.Size = new System.Drawing.Size(59, 55);
            this.rbtnMult.TabIndex = 14;
            this.rbtnMult.Tag = "*";
            this.rbtnMult.Text = "*";
            this.rbtnMult.UseVisualStyleBackColor = false;
            this.rbtnMult.Click += new System.EventHandler(this.rbtnMult_Click);
            // 
            // rbtn8
            // 
            this.rbtn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbtn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn8.ForeColor = System.Drawing.Color.White;
            this.rbtn8.Location = new System.Drawing.Point(246, 479);
            this.rbtn8.Name = "rbtn8";
            this.rbtn8.Size = new System.Drawing.Size(59, 55);
            this.rbtn8.TabIndex = 12;
            this.rbtn8.Tag = "8";
            this.rbtn8.Text = "8";
            this.rbtn8.UseVisualStyleBackColor = false;
            this.rbtn8.Click += new System.EventHandler(this.rbtn8_Click);
            // 
            // rbtn2
            // 
            this.rbtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn2.ForeColor = System.Drawing.Color.White;
            this.rbtn2.Location = new System.Drawing.Point(342, 244);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(59, 55);
            this.rbtn2.TabIndex = 11;
            this.rbtn2.Tag = "2";
            this.rbtn2.Text = "2";
            this.rbtn2.UseVisualStyleBackColor = false;
            this.rbtn2.Click += new System.EventHandler(this.rbtn2_Click);
            // 
            // rbtn3
            // 
            this.rbtn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn3.ForeColor = System.Drawing.Color.White;
            this.rbtn3.Location = new System.Drawing.Point(246, 227);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.Size = new System.Drawing.Size(59, 55);
            this.rbtn3.TabIndex = 10;
            this.rbtn3.Tag = "3";
            this.rbtn3.Text = "3";
            this.rbtn3.UseVisualStyleBackColor = false;
            this.rbtn3.Click += new System.EventHandler(this.rbtn3_Click);
            // 
            // rbtn4
            // 
            this.rbtn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbtn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn4.ForeColor = System.Drawing.Color.White;
            this.rbtn4.Location = new System.Drawing.Point(156, 243);
            this.rbtn4.Name = "rbtn4";
            this.rbtn4.Size = new System.Drawing.Size(59, 55);
            this.rbtn4.TabIndex = 9;
            this.rbtn4.Tag = "4";
            this.rbtn4.Text = "4";
            this.rbtn4.UseVisualStyleBackColor = false;
            this.rbtn4.Click += new System.EventHandler(this.rbtn4_Click);
            // 
            // rbtn5
            // 
            this.rbtn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbtn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn5.ForeColor = System.Drawing.Color.White;
            this.rbtn5.Location = new System.Drawing.Point(113, 304);
            this.rbtn5.Name = "rbtn5";
            this.rbtn5.Size = new System.Drawing.Size(59, 55);
            this.rbtn5.TabIndex = 8;
            this.rbtn5.Tag = "5";
            this.rbtn5.Text = "5";
            this.rbtn5.UseVisualStyleBackColor = false;
            this.rbtn5.Click += new System.EventHandler(this.rbtn5_Click);
            // 
            // rbtn6
            // 
            this.rbtn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbtn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn6.ForeColor = System.Drawing.Color.White;
            this.rbtn6.Location = new System.Drawing.Point(113, 383);
            this.rbtn6.Name = "rbtn6";
            this.rbtn6.Size = new System.Drawing.Size(59, 55);
            this.rbtn6.TabIndex = 7;
            this.rbtn6.Tag = "6";
            this.rbtn6.Text = "6";
            this.rbtn6.UseVisualStyleBackColor = false;
            this.rbtn6.Click += new System.EventHandler(this.rbtn6_Click);
            // 
            // rbtn9
            // 
            this.rbtn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbtn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn9.ForeColor = System.Drawing.Color.White;
            this.rbtn9.Location = new System.Drawing.Point(342, 456);
            this.rbtn9.Name = "rbtn9";
            this.rbtn9.Size = new System.Drawing.Size(59, 55);
            this.rbtn9.TabIndex = 6;
            this.rbtn9.Tag = "9";
            this.rbtn9.Text = "9";
            this.rbtn9.UseVisualStyleBackColor = false;
            this.rbtn9.Click += new System.EventHandler(this.roundButton4_Click);
            // 
            // rbtn7
            // 
            this.rbtn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbtn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn7.ForeColor = System.Drawing.Color.White;
            this.rbtn7.Location = new System.Drawing.Point(156, 456);
            this.rbtn7.Name = "rbtn7";
            this.rbtn7.Size = new System.Drawing.Size(59, 55);
            this.rbtn7.TabIndex = 5;
            this.rbtn7.Tag = "7";
            this.rbtn7.Text = "7";
            this.rbtn7.UseVisualStyleBackColor = false;
            this.rbtn7.Click += new System.EventHandler(this.rbtn7_Click);
            // 
            // rbtn0
            // 
            this.rbtn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbtn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn0.ForeColor = System.Drawing.Color.White;
            this.rbtn0.Location = new System.Drawing.Point(395, 383);
            this.rbtn0.Name = "rbtn0";
            this.rbtn0.Size = new System.Drawing.Size(59, 55);
            this.rbtn0.TabIndex = 4;
            this.rbtn0.Tag = "0";
            this.rbtn0.Text = "0";
            this.rbtn0.UseVisualStyleBackColor = false;
            this.rbtn0.Click += new System.EventHandler(this.rbtn0_Click);
            // 
            // rbtn1
            // 
            this.rbtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn1.ForeColor = System.Drawing.Color.White;
            this.rbtn1.Location = new System.Drawing.Point(395, 305);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(59, 55);
            this.rbtn1.TabIndex = 3;
            this.rbtn1.Tag = "1";
            this.rbtn1.Text = "1";
            this.rbtn1.UseVisualStyleBackColor = false;
            this.rbtn1.Click += new System.EventHandler(this.rbtn1_Click);
            // 
            // rbtnC
            // 
            this.rbtnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnC.ForeColor = System.Drawing.Color.White;
            this.rbtnC.Location = new System.Drawing.Point(225, 326);
            this.rbtnC.Name = "rbtnC";
            this.rbtnC.Size = new System.Drawing.Size(117, 109);
            this.rbtnC.TabIndex = 2;
            this.rbtnC.Text = "C";
            this.rbtnC.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(550, 587);
            this.Controls.Add(this.rbtnDot);
            this.Controls.Add(this.rbtnSub);
            this.Controls.Add(this.rbtnAdd);
            this.Controls.Add(this.rbtnDiv);
            this.Controls.Add(this.rbtnMult);
           
            this.Controls.Add(this.rbtn8);
            this.Controls.Add(this.rbtn2);
            this.Controls.Add(this.rbtn3);
            this.Controls.Add(this.rbtn4);
            this.Controls.Add(this.rbtn5);
            this.Controls.Add(this.rbtn6);
            this.Controls.Add(this.rbtn9);
            this.Controls.Add(this.rbtn7);
            this.Controls.Add(this.rbtn0);
            this.Controls.Add(this.rbtn1);
            this.Controls.Add(this.rbtnC);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEqual;
        private RoundButton rbtnC;
        private RoundButton rbtn1;
        private RoundButton rbtn0;
        private RoundButton rbtn7;
        private RoundButton rbtn9;
        private RoundButton rbtn6;
        private RoundButton rbtn5;
        private RoundButton rbtn4;
        private RoundButton rbtn3;
        private RoundButton rbtn2;
        private RoundButton rbtn8;
       
        private System.Windows.Forms.Label lbMain;
        private RoundButton rbtnMult;
        private RoundButton rbtnDiv;
        private RoundButton rbtnAdd;
        private RoundButton rbtnSub;
        private RoundButton rbtnDot;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbUp;
    }
}

