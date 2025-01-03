using BaoCAo.CustomForm;

namespace BaoCAo
{
    partial class Gameinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gameinfo));
            GTitle1 = new Label();
            panel3 = new Panel();
            price = new Label();
            GATC = new Panel();
            ATClb = new Label();
            bunifuGradientPanel2 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            GTitle2 = new Label();
            Gposter = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            Gdes = new Label();
            bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            CommentSection = new FlowLayoutPanel();
            usrcomments1 = new Usrcomments();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            panel3.SuspendLayout();
            GATC.SuspendLayout();
            bunifuGradientPanel2.SuspendLayout();
            Gposter.SuspendLayout();
            panel2.SuspendLayout();
            bunifuGradientPanel1.SuspendLayout();
            CommentSection.SuspendLayout();
            SuspendLayout();
            // 
            // GTitle1
            // 
            GTitle1.AutoSize = true;
            GTitle1.Font = new Font("Tahoma", 24F);
            GTitle1.ForeColor = Color.White;
            GTitle1.Location = new Point(25, 25);
            GTitle1.Name = "GTitle1";
            GTitle1.Size = new Size(117, 48);
            GTitle1.TabIndex = 3;
            GTitle1.Text = "Title1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(90, 89, 89);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(price);
            panel3.Location = new Point(400, 600);
            panel3.Name = "panel3";
            panel3.Size = new Size(154, 43);
            panel3.TabIndex = 0;
            // 
            // price
            // 
            price.Font = new Font("Open Sans", 8F);
            price.ForeColor = Color.White;
            price.Location = new Point(3, 11);
            price.Name = "price";
            price.Size = new Size(37, 25);
            price.TabIndex = 0;
            price.Text = "price";
            // 
            // GATC
            // 
            GATC.BackColor = Color.FromArgb(55, 215, 76);
            GATC.Controls.Add(ATClb);
            GATC.ForeColor = Color.FromArgb(55, 215, 76);
            GATC.Location = new Point(446, 600);
            GATC.Name = "GATC";
            GATC.Size = new Size(108, 43);
            GATC.TabIndex = 0;
            GATC.Click += GATC_Click;
            // 
            // ATClb
            // 
            ATClb.AutoSize = true;
            ATClb.Cursor = Cursors.Hand;
            ATClb.ForeColor = SystemColors.ActiveCaptionText;
            ATClb.Location = new Point(12, 11);
            ATClb.Name = "ATClb";
            ATClb.Size = new Size(84, 20);
            ATClb.TabIndex = 0;
            ATClb.Text = "Add to cart";
            ATClb.TextAlign = ContentAlignment.MiddleCenter;
            ATClb.MouseLeave += ATClb_MouseLeave;
            ATClb.MouseHover += ATClb_MouseHover;
            // 
            // bunifuGradientPanel2
            // 
            bunifuGradientPanel2.BackColor = Color.Transparent;
            bunifuGradientPanel2.BackgroundImage = (Image)resources.GetObject("bunifuGradientPanel2.BackgroundImage");
            bunifuGradientPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuGradientPanel2.BorderRadius = 1;
            bunifuGradientPanel2.Controls.Add(GTitle2);
            bunifuGradientPanel2.GradientBottomLeft = Color.DarkGray;
            bunifuGradientPanel2.GradientBottomRight = Color.FromArgb(176, 255, 0);
            bunifuGradientPanel2.GradientTopLeft = Color.SlateGray;
            bunifuGradientPanel2.GradientTopRight = Color.LimeGreen;
            bunifuGradientPanel2.Location = new Point(25, 527);
            bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            bunifuGradientPanel2.Quality = 10;
            bunifuGradientPanel2.Size = new Size(529, 67);
            bunifuGradientPanel2.TabIndex = 5;
            // 
            // GTitle2
            // 
            GTitle2.AutoSize = true;
            GTitle2.BackColor = Color.Transparent;
            GTitle2.Font = new Font("Tahoma", 17F);
            GTitle2.Location = new Point(0, 0);
            GTitle2.Name = "GTitle2";
            GTitle2.Size = new Size(87, 35);
            GTitle2.TabIndex = 4;
            GTitle2.Text = "Title2";
            // 
            // Gposter
            // 
            Gposter.Controls.Add(panel2);
            Gposter.Location = new Point(25, 99);
            Gposter.Name = "Gposter";
            Gposter.Size = new Size(832, 397);
            Gposter.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 0, 0, 0);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Gdes);
            panel2.Location = new Point(527, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 268);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 24);
            label1.TabIndex = 1;
            label1.Text = "Thông tin game.";
            // 
            // Gdes
            // 
            Gdes.BackColor = Color.Transparent;
            Gdes.Font = new Font("Open Sans", 10F);
            Gdes.ForeColor = Color.White;
            Gdes.Location = new Point(3, 39);
            Gdes.MaximumSize = new Size(264, 200);
            Gdes.Name = "Gdes";
            Gdes.Size = new Size(264, 200);
            Gdes.TabIndex = 4;
            Gdes.Text = "Game description";
            // 
            // bunifuGradientPanel1
            // 
            bunifuGradientPanel1.BackColor = Color.Transparent;
            bunifuGradientPanel1.BackgroundImage = (Image)resources.GetObject("bunifuGradientPanel1.BackgroundImage");
            bunifuGradientPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuGradientPanel1.BorderRadius = 1;
            bunifuGradientPanel1.Controls.Add(CommentSection);
            bunifuGradientPanel1.Controls.Add(label2);
            bunifuGradientPanel1.Controls.Add(richTextBox1);
            bunifuGradientPanel1.Controls.Add(Gposter);
            bunifuGradientPanel1.Controls.Add(GTitle1);
            bunifuGradientPanel1.GradientBottomLeft = Color.DarkGray;
            bunifuGradientPanel1.GradientBottomRight = Color.FromArgb(176, 255, 0);
            bunifuGradientPanel1.GradientTopLeft = Color.SlateGray;
            bunifuGradientPanel1.GradientTopRight = Color.LimeGreen;
            bunifuGradientPanel1.Location = new Point(0, 0);
            bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            bunifuGradientPanel1.Quality = 10;
            bunifuGradientPanel1.Size = new Size(1000, 1600);
            bunifuGradientPanel1.TabIndex = 8;
            // 
            // CommentSection
            // 
            CommentSection.AutoScroll = true;
            CommentSection.Controls.Add(usrcomments1);
            CommentSection.Location = new Point(25, 1134);
            CommentSection.Name = "CommentSection";
            CommentSection.Size = new Size(662, 434);
            CommentSection.TabIndex = 10;
            // 
            // usrcomments1
            // 
            usrcomments1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            usrcomments1.BackColor = SystemColors.Control;
            usrcomments1.BorderStyle = BorderStyle.FixedSingle;
            usrcomments1.Location = new Point(3, 3);
            usrcomments1.Name = "usrcomments1";
            usrcomments1.Size = new Size(652, 109);
            usrcomments1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(25, 738);
            label2.Name = "label2";
            label2.Size = new Size(239, 28);
            label2.TabIndex = 9;
            label2.Text = "Bình luận của người dùng:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(25, 770);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(529, 183);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // Gameinfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(161, 158, 158);
            Controls.Add(bunifuGradientPanel2);
            Controls.Add(GATC);
            Controls.Add(panel3);
            Controls.Add(bunifuGradientPanel1);
            Name = "Gameinfo";
            Size = new Size(1000, 1600);
            panel3.ResumeLayout(false);
            GATC.ResumeLayout(false);
            GATC.PerformLayout();
            bunifuGradientPanel2.ResumeLayout(false);
            bunifuGradientPanel2.PerformLayout();
            Gposter.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            bunifuGradientPanel1.ResumeLayout(false);
            bunifuGradientPanel1.PerformLayout();
            CommentSection.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label GTitle1;
        private Panel panel3;
        private Label price;
        private Panel GATC;
        private Label ATClb;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel2;
        private Label GTitle2;
        private Panel Gposter;
        private Panel panel2;
        private Label label1;
        private Label Gdes;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Label label2;
        private RichTextBox richTextBox1;
        private FlowLayoutPanel CommentSection;
        private Usrcomments usrcomments1;
    }
}
