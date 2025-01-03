namespace BaoCAo
{
    partial class Register
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
            panel1 = new Panel();
            l_Login = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label5 = new Label();
            r_confirmtb = new TextBox();
            label4 = new Label();
            r_usernametb = new TextBox();
            label3 = new Label();
            label2 = new Label();
            r_emailtb = new TextBox();
            r_passwordtb = new TextBox();
            register_btn = new Button();
            r_showpassword = new CheckBox();
            label1 = new Label();
            l_exit = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(l_Login);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 375);
            panel1.TabIndex = 1;
            // 
            // l_Login
            // 
            l_Login.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_Login.ForeColor = Color.FromArgb(1, 1, 1);
            l_Login.Location = new Point(113, 274);
            l_Login.Name = "l_Login";
            l_Login.Size = new Size(112, 28);
            l_Login.TabIndex = 7;
            l_Login.Text = "Log in";
            l_Login.TextAlign = ContentAlignment.MiddleCenter;
            l_Login.Click += l_Login_Click;
            l_Login.MouseLeave += l_Login_MouseLeave;
            l_Login.MouseHover += l_Login_Hover;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(113, 63);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 96);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(91, 91, 91);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(r_confirmtb);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(r_usernametb);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(r_emailtb);
            panel2.Controls.Add(r_passwordtb);
            panel2.Controls.Add(register_btn);
            panel2.Controls.Add(r_showpassword);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(l_exit);
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(350, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 375);
            panel2.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(14, 208);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 11;
            label5.Text = "Confirm";
            // 
            // r_confirmtb
            // 
            r_confirmtb.Font = new Font("Arial", 10.2F);
            r_confirmtb.Location = new Point(88, 202);
            r_confirmtb.Margin = new Padding(3, 2, 3, 2);
            r_confirmtb.Name = "r_confirmtb";
            r_confirmtb.PasswordChar = '*';
            r_confirmtb.Size = new Size(231, 23);
            r_confirmtb.TabIndex = 4;
            r_confirmtb.KeyDown += r_confirmtb_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 137);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 9;
            label4.Text = "Username:";
            // 
            // r_usernametb
            // 
            r_usernametb.Font = new Font("Arial", 10.2F);
            r_usernametb.Location = new Point(88, 132);
            r_usernametb.Margin = new Padding(3, 2, 3, 2);
            r_usernametb.Name = "r_usernametb";
            r_usernametb.Size = new Size(231, 23);
            r_usernametb.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 172);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 104);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Email:";
            // 
            // r_emailtb
            // 
            r_emailtb.Font = new Font("Arial", 10.2F);
            r_emailtb.Location = new Point(88, 98);
            r_emailtb.Margin = new Padding(3, 2, 3, 2);
            r_emailtb.Name = "r_emailtb";
            r_emailtb.Size = new Size(231, 23);
            r_emailtb.TabIndex = 1;
            // 
            // r_passwordtb
            // 
            r_passwordtb.Font = new Font("Arial", 10.2F);
            r_passwordtb.Location = new Point(88, 167);
            r_passwordtb.Margin = new Padding(3, 2, 3, 2);
            r_passwordtb.Name = "r_passwordtb";
            r_passwordtb.PasswordChar = '*';
            r_passwordtb.Size = new Size(231, 23);
            r_passwordtb.TabIndex = 3;
            // 
            // register_btn
            // 
            register_btn.Location = new Point(145, 274);
            register_btn.Margin = new Padding(3, 2, 3, 2);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(99, 28);
            register_btn.TabIndex = 6;
            register_btn.Text = "Sign up";
            register_btn.UseVisualStyleBackColor = true;
            register_btn.Click += register_btn_Click;
            // 
            // r_showpassword
            // 
            r_showpassword.AutoSize = true;
            r_showpassword.BackColor = Color.Transparent;
            r_showpassword.ForeColor = Color.White;
            r_showpassword.Location = new Point(222, 227);
            r_showpassword.Margin = new Padding(3, 2, 3, 2);
            r_showpassword.Name = "r_showpassword";
            r_showpassword.Size = new Size(108, 19);
            r_showpassword.TabIndex = 5;
            r_showpassword.Text = "Show password";
            r_showpassword.UseVisualStyleBackColor = false;
            r_showpassword.CheckedChanged += r_showpassword_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS UI Gothic", 22.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(122, 63);
            label1.Name = "label1";
            label1.Size = new Size(131, 30);
            label1.TabIndex = 1;
            label1.Text = "SIGN UP";
            // 
            // l_exit
            // 
            l_exit.AutoSize = true;
            l_exit.BackColor = Color.Transparent;
            l_exit.Location = new Point(324, 7);
            l_exit.Name = "l_exit";
            l_exit.Size = new Size(14, 15);
            l_exit.TabIndex = 2;
            l_exit.Text = "X";
            l_exit.Click += l_exit_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 375);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button register_btn;
        private CheckBox r_showpassword;
        private TextBox r_passwordtb;
        private Label label3;
        private TextBox r_emailtb;
        private Label label2;
        private Label l_exit;
        private Label label1;
        private Panel panel2;
        private Label l_Login;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox r_confirmtb;
        private Label label4;
        private TextBox r_usernametb;
    }
}