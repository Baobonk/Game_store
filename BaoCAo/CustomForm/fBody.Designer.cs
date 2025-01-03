using BaoCAo.Class.Component;

namespace BaoCAo.CustomForm
{
    partial class fBody
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

        public void setGameReccom(List<Game> games)
        {
            List<GameRecom> gamerecoms = new List<GameRecom> { gameRecom1, gameRecom2, gameRecom3, gameRecom4};
            for (int i = 0; i < gamerecoms.Count; i++)
            {
                gamerecoms[i].setImg(games);
            }

            gameShowRoom1.Games = games;
            gameShowRoom1.setImg(games);
        }

        private void UserControlB_ButtonClicked(object sender, ImageEventArgs e)
        {
            if (sender != this)
            {
                SetPanelBackgroundImage(theme, e.ImagePath);
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
                Console.WriteLine("Hình ảnh không tồn tại tại đường dẫn đã chỉ định.(fBody)");
            }
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBody));
            theme = new Panel();
            categories1 = new Categories();
            button1 = new Button();
            panel2 = new Panel();
            panel10 = new Panel();
            textBox1 = new TextBox();
            lNewFeed = new Label();
            lRollCall = new Label();
            lCategory = new Label();
            gameShowRoom1 = new GameShowRoom();
            panel1 = new Panel();
            gameRecom4 = new GameRecom();
            gameRecom1 = new GameRecom();
            gameRecom3 = new GameRecom();
            gameRecom2 = new GameRecom();
            panel11 = new Panel();
            theme.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // theme
            // 
            theme.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            theme.BackColor = Color.Transparent;
            theme.BackgroundImage = Properties.Resources._17c44040a61b11efb55e093e10ade9bd;
            theme.BackgroundImageLayout = ImageLayout.Stretch;
            theme.Controls.Add(categories1);
            theme.Controls.Add(button1);
            theme.Controls.Add(panel2);
            theme.Controls.Add(gameShowRoom1);
            theme.Location = new Point(0, 0);
            theme.Name = "theme";
            theme.Size = new Size(1276, 587);
            theme.TabIndex = 0;
            // 
            // categories1
            // 
            categories1.BackColor = Color.DarkGray;
            categories1.Location = new Point(86, 78);
            categories1.Name = "categories1";
            categories1.Size = new Size(830, 410);
            categories1.TabIndex = 4;
            categories1.Visible = false;
            categories1.MouseLeave += categories1_MouseLeave;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button1.BackColor = Color.GreenYellow;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(1017, 14);
            button1.Name = "button1";
            button1.Size = new Size(175, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.GreenYellow;
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(lNewFeed);
            panel2.Controls.Add(lRollCall);
            panel2.Controls.Add(lCategory);
            panel2.Location = new Point(86, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(1106, 31);
            panel2.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackColor = Color.WhiteSmoke;
            panel10.BackgroundImage = Properties.Resources.magnifying_glass;
            panel10.BackgroundImageLayout = ImageLayout.Stretch;
            panel10.Location = new Point(1078, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(23, 23);
            panel10.TabIndex = 2;
            panel10.Click += panel10_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(931, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 4;
            // 
            // lNewFeed
            // 
            lNewFeed.BackColor = Color.GreenYellow;
            lNewFeed.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lNewFeed.ForeColor = SystemColors.ControlDarkDark;
            lNewFeed.Location = new Point(271, 0);
            lNewFeed.Margin = new Padding(0);
            lNewFeed.Name = "lNewFeed";
            lNewFeed.Size = new Size(141, 31);
            lNewFeed.TabIndex = 3;
            lNewFeed.Text = "New Feed";
            lNewFeed.TextAlign = ContentAlignment.MiddleLeft;
            lNewFeed.Click += lNewFeed_Click;
            // 
            // lRollCall
            // 
            lRollCall.BackColor = Color.GreenYellow;
            lRollCall.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lRollCall.ForeColor = SystemColors.ControlDarkDark;
            lRollCall.Location = new Point(136, 0);
            lRollCall.Margin = new Padding(0);
            lRollCall.Name = "lRollCall";
            lRollCall.Size = new Size(135, 31);
            lRollCall.TabIndex = 2;
            lRollCall.Text = "Roll Call";
            lRollCall.TextAlign = ContentAlignment.MiddleLeft;
            lRollCall.Click += lRollCall_Click;
            // 
            // lCategory
            // 
            lCategory.BackColor = Color.GreenYellow;
            lCategory.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lCategory.ForeColor = SystemColors.ControlDarkDark;
            lCategory.Location = new Point(0, 0);
            lCategory.Margin = new Padding(0);
            lCategory.Name = "lCategory";
            lCategory.Size = new Size(136, 31);
            lCategory.TabIndex = 1;
            lCategory.Text = "Categories";
            lCategory.TextAlign = ContentAlignment.MiddleLeft;
            lCategory.Click += lCategory_Click;
            // 
            // gameShowRoom1
            // 
            gameShowRoom1.Anchor = AnchorStyles.Top;
            gameShowRoom1.BackColor = Color.Transparent;
            gameShowRoom1.Location = new Point(86, 124);
            gameShowRoom1.Name = "gameShowRoom1";
            gameShowRoom1.Size = new Size(1106, 418);
            gameShowRoom1.TabIndex = 3;
            gameShowRoom1.ButtonClicked += UserControlB_ButtonClicked;
            // 
            // panel1
            // 
            panel1.Controls.Add(gameRecom4);
            panel1.Controls.Add(gameRecom1);
            panel1.Controls.Add(gameRecom3);
            panel1.Controls.Add(gameRecom2);
            panel1.Controls.Add(panel11);
            panel1.Location = new Point(0, 593);
            panel1.Name = "panel1";
            panel1.Size = new Size(1276, 1630);
            panel1.TabIndex = 1;
            // 
            // gameRecom4
            // 
            gameRecom4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gameRecom4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gameRecom4.Location = new Point(317, 10);
            gameRecom4.Name = "gameRecom4";
            gameRecom4.Size = new Size(940, 380);
            gameRecom4.TabIndex = 10;
            // 
            // gameRecom1
            // 
            gameRecom1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gameRecom1.Location = new Point(317, 1241);
            gameRecom1.Name = "gameRecom1";
            gameRecom1.Size = new Size(940, 380);
            gameRecom1.TabIndex = 6;
            // 
            // gameRecom3
            // 
            gameRecom3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gameRecom3.Location = new Point(317, 841);
            gameRecom3.Name = "gameRecom3";
            gameRecom3.Size = new Size(940, 380);
            gameRecom3.TabIndex = 9;
            // 
            // gameRecom2
            // 
            gameRecom2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gameRecom2.Location = new Point(317, 411);
            gameRecom2.Name = "gameRecom2";
            gameRecom2.Size = new Size(940, 380);
            gameRecom2.TabIndex = 8;
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel11.AutoScroll = true;
            panel11.BackColor = SystemColors.ActiveBorder;
            panel11.Location = new Point(20, 10);
            panel11.Name = "panel11";
            panel11.Size = new Size(267, 547);
            panel11.TabIndex = 7;
            // 
            // fBody
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panel1);
            Controls.Add(theme);
            Name = "fBody";
            Size = new Size(1276, 2223);
            theme.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        private Panel theme;
        private Button button1;
        private Panel panel2;
        private Panel panel10;
        private TextBox textBox1;
        private Label lNewFeed;
        private Label lRollCall;
        private Label lCategory;
        private GameShowRoom gameShowRoom1;
        private Panel panel1;
        private GameRecom gameRecom4;
        private GameRecom gameRecom1;
        private GameRecom gameRecom3;
        private GameRecom gameRecom2;
        private Panel panel11;
        private Categories categories1;
    }
}
