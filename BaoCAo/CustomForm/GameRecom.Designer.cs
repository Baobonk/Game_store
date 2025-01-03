using BaoCAo.Class.Component;

namespace BaoCAo.CustomForm
{
    partial class GameRecom
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

        public void setImg(List<Game> games)
        {
            List<Panel> panels = new List<Panel> { panel2, panel3, panel4, panel5, panel6 };
            List<Label> labels = new List<Label>{label2, label3 , label4 , label5 , label6 };

            for (int i = 0; i < panels.Count && i < games.Count; i++)
            {
                Game game = games[i];

                // Tạo PictureBox để hiển thị hình ảnh của game

                try
                {

                    
                    SetPanelBackgroundImage(panels[i], game.UrlPoster);
                    panels[i].BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch
                {
                    panels[i].BackColor = Color.Gray; // Màu nền nếu không tải được ảnh
                }

                // Tạo Label để hiển thị tên của game
                labels[i].Text = game.Title;

            }
        }


        private void SetPanelBackgroundImage(Panel panel, string imagePath)
        {
            if (System.IO.File.Exists(imagePath))
            {
                Image image = Image.FromFile(imagePath);
                panel.BackgroundImage = image;
                panel.BackgroundImageLayout = ImageLayout.Stretch; // Cách hình ảnh được hiển thị trong Panel
            }
            else
            {
                Console.WriteLine("Hình ảnh không tồn tại tại đường dẫn đã chỉ định.");
            }
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            pGameInform4 = new Panel();
            label6 = new Label();
            panel6 = new Panel();
            pGameInform3 = new Panel();
            label5 = new Label();
            panel5 = new Panel();
            pGameInform2 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            pGameInform1 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            pGameInform = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            pGameInform4.SuspendLayout();
            pGameInform3.SuspendLayout();
            pGameInform2.SuspendLayout();
            pGameInform1.SuspendLayout();
            pGameInform.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(328, 45);
            label1.TabIndex = 3;
            label1.Text = "Game mới";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(pGameInform4);
            panel1.Controls.Add(pGameInform3);
            panel1.Controls.Add(pGameInform2);
            panel1.Controls.Add(pGameInform1);
            panel1.Controls.Add(pGameInform);
            panel1.Location = new Point(0, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 324);
            panel1.TabIndex = 4;
            // 
            // pGameInform4
            // 
            pGameInform4.BackColor = Color.LightYellow;
            pGameInform4.Controls.Add(label6);
            pGameInform4.Controls.Add(panel6);
            pGameInform4.Location = new Point(1152, 18);
            pGameInform4.Name = "pGameInform4";
            pGameInform4.Size = new Size(200, 286);
            pGameInform4.TabIndex = 4;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label6.Location = new Point(0, 236);
            label6.Name = "label6";
            label6.Size = new Size(200, 50);
            label6.TabIndex = 1;
            label6.Text = "label6";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaption;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 233);
            panel6.TabIndex = 0;
            // 
            // pGameInform3
            // 
            pGameInform3.BackColor = Color.LightYellow;
            pGameInform3.Controls.Add(label5);
            pGameInform3.Controls.Add(panel5);
            pGameInform3.Location = new Point(886, 18);
            pGameInform3.Name = "pGameInform3";
            pGameInform3.Size = new Size(200, 286);
            pGameInform3.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label5.Location = new Point(0, 236);
            label5.Name = "label5";
            label5.Size = new Size(200, 50);
            label5.TabIndex = 1;
            label5.Text = "label5";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 233);
            panel5.TabIndex = 0;
            // 
            // pGameInform2
            // 
            pGameInform2.BackColor = Color.LightYellow;
            pGameInform2.Controls.Add(label4);
            pGameInform2.Controls.Add(panel4);
            pGameInform2.Location = new Point(600, 18);
            pGameInform2.Name = "pGameInform2";
            pGameInform2.Size = new Size(200, 286);
            pGameInform2.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label4.Location = new Point(0, 236);
            label4.Name = "label4";
            label4.Size = new Size(200, 50);
            label4.TabIndex = 1;
            label4.Text = "label4";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 233);
            panel4.TabIndex = 0;
            // 
            // pGameInform1
            // 
            pGameInform1.BackColor = Color.LightYellow;
            pGameInform1.Controls.Add(label3);
            pGameInform1.Controls.Add(panel3);
            pGameInform1.Location = new Point(318, 18);
            pGameInform1.Name = "pGameInform1";
            pGameInform1.Size = new Size(200, 286);
            pGameInform1.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label3.Location = new Point(0, 236);
            label3.Name = "label3";
            label3.Size = new Size(200, 50);
            label3.TabIndex = 1;
            label3.Text = "label3";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 233);
            panel3.TabIndex = 0;
            // 
            // pGameInform
            // 
            pGameInform.BackColor = Color.LightYellow;
            pGameInform.Controls.Add(label2);
            pGameInform.Controls.Add(panel2);
            pGameInform.Location = new Point(35, 18);
            pGameInform.Name = "pGameInform";
            pGameInform.Size = new Size(200, 286);
            pGameInform.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label2.Location = new Point(0, 236);
            label2.Name = "label2";
            label2.Size = new Size(200, 50);
            label2.TabIndex = 1;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 233);
            panel2.TabIndex = 0;
            // 
            // GameRecom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "GameRecom";
            Size = new Size(1184, 375);
            panel1.ResumeLayout(false);
            pGameInform4.ResumeLayout(false);
            pGameInform3.ResumeLayout(false);
            pGameInform2.ResumeLayout(false);
            pGameInform1.ResumeLayout(false);
            pGameInform.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel pGameInform;
        private Label label2;
        private Panel pGameInform4;
        private Label label6;
        private Panel panel6;
        private Panel pGameInform3;
        private Label label5;
        private Panel panel5;
        private Panel pGameInform2;
        private Label label4;
        private Panel panel4;
        private Panel pGameInform1;
        private Label label3;
        private Panel panel3;
    }
}
