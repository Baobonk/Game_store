namespace BaoCAo
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            L_loginbtn = new Button();
            l_showpassword = new CheckBox();
            l_passwordtb = new TextBox();
            label3 = new Label();
            l_usernametb = new TextBox();
            label2 = new Label();
            l_exit = new Label();
            label1 = new Label();
            panel2 = new Panel();
            l_registerhere = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(L_loginbtn);
            panel1.Controls.Add(l_showpassword);
            panel1.Controls.Add(l_passwordtb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(l_usernametb);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(l_exit);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Font = new Font("Arial", 10.2F);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 375);
            panel1.TabIndex = 0;
            // 
            // L_loginbtn
            // 
            L_loginbtn.Location = new Point(486, 220);
            L_loginbtn.Margin = new Padding(3, 2, 3, 2);
            L_loginbtn.Name = "L_loginbtn";
            L_loginbtn.Size = new Size(99, 28);
            L_loginbtn.TabIndex = 8;
            L_loginbtn.Text = "Log in";
            L_loginbtn.UseVisualStyleBackColor = true;
            L_loginbtn.Click += L_loginbtn_Click;
            // 
            // l_showpassword
            // 
            l_showpassword.AutoSize = true;
            l_showpassword.Location = new Point(572, 187);
            l_showpassword.Margin = new Padding(3, 2, 3, 2);
            l_showpassword.Name = "l_showpassword";
            l_showpassword.Size = new Size(124, 20);
            l_showpassword.TabIndex = 7;
            l_showpassword.Text = "Show password";
            l_showpassword.UseVisualStyleBackColor = true;
            l_showpassword.CheckedChanged += l_showpassword_CheckedChanged;
            // 
            // l_passwordtb
            // 
            l_passwordtb.Font = new Font("Arial", 10.2F);
            l_passwordtb.Location = new Point(439, 162);
            l_passwordtb.Margin = new Padding(3, 2, 3, 2);
            l_passwordtb.Name = "l_passwordtb";
            l_passwordtb.PasswordChar = '*';
            l_passwordtb.Size = new Size(231, 23);
            l_passwordtb.TabIndex = 6;
            l_passwordtb.KeyDown += l_passwordtb_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 167);
            label3.Name = "label3";
            label3.Size = new Size(72, 16);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // l_usernametb
            // 
            l_usernametb.Font = new Font("Arial", 10.2F);
            l_usernametb.Location = new Point(439, 130);
            l_usernametb.Margin = new Padding(3, 2, 3, 2);
            l_usernametb.Name = "l_usernametb";
            l_usernametb.Size = new Size(231, 23);
            l_usernametb.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 135);
            label2.Name = "label2";
            label2.Size = new Size(75, 16);
            label2.TabIndex = 3;
            label2.Text = "Username:";
            // 
            // l_exit
            // 
            l_exit.AutoSize = true;
            l_exit.Location = new Point(674, 7);
            l_exit.Name = "l_exit";
            l_exit.Size = new Size(15, 16);
            l_exit.TabIndex = 2;
            l_exit.Text = "X";
            l_exit.Click += l_exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 22.2F, FontStyle.Bold);
            label1.Location = new Point(470, 90);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 1;
            label1.Text = "SIGN IN";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(210, 255, 64);
            panel2.Controls.Add(l_registerhere);
            panel2.Controls.Add(pictureBox1);
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 375);
            panel2.TabIndex = 0;
            // 
            // l_registerhere
            // 
            l_registerhere.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_registerhere.Location = new Point(112, 220);
            l_registerhere.Name = "l_registerhere";
            l_registerhere.Size = new Size(112, 28);
            l_registerhere.TabIndex = 1;
            l_registerhere.Text = "Register";
            l_registerhere.TextAlign = ContentAlignment.MiddleCenter;
            l_registerhere.Click += l_registerhere_Click;
            l_registerhere.MouseLeave += l_registerhere_MouseLeave;
            l_registerhere.MouseHover += l_register_hover;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(112, 54);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 96);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 375);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label l_exit;
        private Label label1;
        private TextBox l_usernametb;
        private Label label2;
        private TextBox l_passwordtb;
        private Label label3;
        private Button L_loginbtn;
        private CheckBox l_showpassword;
        private Label l_registerhere;
    }
}
