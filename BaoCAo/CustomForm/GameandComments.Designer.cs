namespace BaoCAo.CustomForm
{
    partial class GameandComments
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
            gameinfo1 = new Gameinfo();
            CommentSection = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            usrcomments1 = new Usrcomments();
            CommentSection.SuspendLayout();
            SuspendLayout();
            // 
            // gameinfo1
            // 
            gameinfo1.BackColor = Color.FromArgb(161, 158, 158);
            gameinfo1.GameID = 0;
            gameinfo1.Location = new Point(100, 0);
            gameinfo1.Name = "gameinfo1";
            gameinfo1.Size = new Size(1000, 800);
            gameinfo1.TabIndex = 0;
            gameinfo1.Username = null;
            // 
            // CommentSection
            // 
            CommentSection.AutoScroll = true;
            CommentSection.BackColor = SystemColors.ButtonFace;
            CommentSection.Controls.Add(usrcomments1);
            CommentSection.Location = new Point(100, 806);
            CommentSection.Name = "CommentSection";
            CommentSection.Size = new Size(601, 774);
            CommentSection.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1200, 1600);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // usrcomments1
            // 
            usrcomments1.Location = new Point(3, 3);
            usrcomments1.Name = "usrcomments1";
            usrcomments1.Size = new Size(598, 110);
            usrcomments1.TabIndex = 0;
            // 
            // GameandComments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(CommentSection);
            Controls.Add(gameinfo1);
            Controls.Add(flowLayoutPanel1);
            Name = "GameandComments";
            Size = new Size(1200, 1600);
            CommentSection.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Gameinfo gameinfo1;
        private FlowLayoutPanel CommentSection;
        private FlowLayoutPanel flowLayoutPanel1;
        private Usrcomments usrcomments1;
    }
}
