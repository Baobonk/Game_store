using BaoCAo.Class.Component;

namespace BaoCAo.CustomForm
{
    partial class GameShowRoom
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private List<Game> g = Game.GetAllGame(); 
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


        public List<Game> Games
        {
            get { return g; }
            set { g = value; }
        }

        public void setImg(List<Game> Games)
        {
            List<Panel> panels = new List<Panel> { panel7, panel8, panel9, panel10, panel11 };
            
            for (int i = 0; i < panels.Count && i < Games.Count; i++)
            {
                Console.WriteLine("A");
                Game game = Games[i];
                try
                {      
                    SetPanelBackgroundImage(panels[i], game);
                    panels[i].BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch
                {
                    panels[i].BackColor = Color.Gray; // Màu nền nếu không tải được ảnh
                }

            }
        }

        public void setText(Game game)
        {
            string publisherName = "";
            List<Publisher> publishers = Publisher.GetAllPublishers();
            foreach (Publisher publisher in publishers)
            {
                if(game.PublisherID == publisher.ID)
                {
                    publisherName = publisher.Name;
                }
            }
            string genres = "";
            foreach(string genre in game.Genres)
            {
                genres += genre + ", ";
            }
            label4.Text = game.Title;
            lTitle.Text = game.Detail;
            label2.Text = publisherName;
            label1.Text = game.Score.ToString();
            label3.Text = genres;

        }

        private void SetPanelBackgroundImage(Panel panel, Game game)
        {
            if (System.IO.File.Exists(game.UrlPoster))
            {
                Image image = Image.FromFile(game.UrlTheme);
                panel.BackgroundImage = image;
                panel.BackgroundImageLayout = ImageLayout.Stretch; // Cách hình ảnh được hiển thị trong Panel
                panelImageMap[panel] = game;
            }
            else
            {
                Console.WriteLine("Hình ảnh không tồn tại tại đường dẫn đã chỉ định.(Showroom)");
            }
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel6 = new Panel();
            panel11 = new Panel();
            panel10 = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            label2 = new LinkLabel();
            label3 = new Label();
            label1 = new Label();
            lGenres = new Label();
            lPublisher = new Label();
            lScore = new Label();
            lTitle = new Label();
            Poster = new Panel();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.AutoScroll = true;
            panel6.Controls.Add(panel11);
            panel6.Controls.Add(panel10);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(603, 254);
            panel6.Name = "panel6";
            panel6.Size = new Size(490, 108);
            panel6.TabIndex = 2;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Black;
            panel11.Location = new Point(831, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(201, 83);
            panel11.TabIndex = 4;
            panel11.Click += panel11Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Black;
            panel10.Location = new Point(624, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(201, 83);
            panel10.TabIndex = 3;
            panel10.Click += panel10Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Black;
            panel9.Location = new Point(417, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(201, 83);
            panel9.TabIndex = 2;
            panel9.Click += panel9Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Location = new Point(210, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(201, 83);
            panel8.TabIndex = 1;
            panel8.Click += panel8Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(201, 83);
            panel7.TabIndex = 0;
            panel7.Click += panel7Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGray;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(lGenres);
            panel5.Controls.Add(lPublisher);
            panel5.Controls.Add(lScore);
            panel5.Controls.Add(lTitle);
            panel5.Location = new Point(603, 25);
            panel5.Name = "panel5";
            panel5.Size = new Size(490, 223);
            panel5.TabIndex = 1;
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(490, 33);
            label4.TabIndex = 8;
            label4.Text = "label4";
            // 
            // label2
            // 
            label2.ActiveLinkColor = Color.Blue;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.LinkColor = Color.Black;
            label2.Location = new Point(146, 146);
            label2.Name = "label2";
            label2.Size = new Size(341, 23);
            label2.TabIndex = 7;
            label2.TabStop = true;
            label2.Text = "label2";
            label2.VisitedLinkColor = Color.Black;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 14.25F);
            label3.Location = new Point(146, 177);
            label3.MaximumSize = new Size(341, 46);
            label3.Name = "label3";
            label3.Size = new Size(341, 46);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 14.25F);
            label1.Location = new Point(146, 115);
            label1.Name = "label1";
            label1.Size = new Size(341, 23);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // lGenres
            // 
            lGenres.Font = new Font("Times New Roman", 14.25F);
            lGenres.ForeColor = SystemColors.ActiveCaptionText;
            lGenres.Location = new Point(3, 177);
            lGenres.Name = "lGenres";
            lGenres.Size = new Size(137, 23);
            lGenres.TabIndex = 3;
            lGenres.Text = "Thể loại";
            // 
            // lPublisher
            // 
            lPublisher.Font = new Font("Times New Roman", 14.25F);
            lPublisher.ForeColor = SystemColors.ActiveCaptionText;
            lPublisher.Location = new Point(3, 146);
            lPublisher.Name = "lPublisher";
            lPublisher.Size = new Size(137, 23);
            lPublisher.TabIndex = 2;
            lPublisher.Text = "Nhà phát hành";
            // 
            // lScore
            // 
            lScore.Font = new Font("Times New Roman", 14.25F);
            lScore.ForeColor = SystemColors.ActiveCaptionText;
            lScore.Location = new Point(3, 115);
            lScore.Name = "lScore";
            lScore.Size = new Size(137, 23);
            lScore.TabIndex = 1;
            lScore.Text = "Điểm số";
            // 
            // lTitle
            // 
            lTitle.Font = new Font("Times New Roman", 14.25F);
            lTitle.ForeColor = SystemColors.ActiveCaptionText;
            lTitle.Location = new Point(3, 33);
            lTitle.Name = "lTitle";
            lTitle.Size = new Size(484, 82);
            lTitle.TabIndex = 0;
            lTitle.Text = "label1";
            // 
            // Poster
            // 
            Poster.BackgroundImage = Properties.Resources._17c44040a61b11efb55e093e10ade9bd;
            Poster.BackgroundImageLayout = ImageLayout.Stretch;
            Poster.Location = new Point(21, 25);
            Poster.Name = "Poster";
            Poster.Size = new Size(546, 315);
            Poster.TabIndex = 0;
            // 
            // GameShowRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel6);
            Controls.Add(Poster);
            Controls.Add(panel5);
            Name = "GameShowRoom";
            Size = new Size(1120, 369);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel6;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Panel panel5;
        private LinkLabel label2;
        private Label label3;
        private Label label1;
        private Label lGenres;
        private Label lPublisher;
        private Label lScore;
        private Label lTitle;
        private Panel Poster;
        private Panel panel10;
        private Panel panel11;
        private Label label4;
    }
}
