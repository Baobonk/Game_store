namespace BaoCAo.CustomForm
{
    partial class Usrcomments
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Username = new Label();
            Contents = new Label();
            Date = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(109, 3);
            Username.Name = "Username";
            Username.Size = new Size(75, 20);
            Username.TabIndex = 0;
            Username.Text = "Username";
            // 
            // Contents
            // 
            Contents.BackColor = Color.Transparent;
            Contents.Location = new Point(109, 23);
            Contents.MaximumSize = new Size(530, 80);
            Contents.Name = "Contents";
            Contents.Size = new Size(530, 80);
            Contents.TabIndex = 1;
            Contents.Text = "comments";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(550, 3);
            Date.Name = "Date";
            Date.Size = new Size(35, 20);
            Date.TabIndex = 2;
            Date.Text = "Day";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Usrcomments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pictureBox1);
            Controls.Add(Date);
            Controls.Add(Contents);
            Controls.Add(Username);
            Name = "Usrcomments";
            Size = new Size(650, 107);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private Label Contents;
        private Label Date;
        private PictureBox pictureBox1;
    }
}
