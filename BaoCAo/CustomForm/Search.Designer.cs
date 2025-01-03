namespace BaoCAo.CustomForm
{
    partial class Search
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
            panel2 = new Panel();
            panel10 = new Panel();
            textBox1 = new TextBox();
            lNewFeed = new Label();
            lRollCall = new Label();
            lCategory = new Label();
            categories1 = new Categories();
            searchPanel = new FlowLayoutPanel();
            panel2.SuspendLayout();
            SuspendLayout();
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
            panel2.Location = new Point(95, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(1106, 31);
            panel2.TabIndex = 1;
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
            // categories1
            // 
            categories1.Location = new Point(95, 73);
            categories1.Name = "categories1";
            categories1.Size = new Size(684, 283);
            categories1.TabIndex = 2;
            categories1.Visible = false;
            // 
            // searchPanel
            // 
            searchPanel.Anchor = AnchorStyles.Top;
            searchPanel.BackColor = SystemColors.ActiveCaption;
            searchPanel.Location = new Point(95, 76);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(1106, 1195);
            searchPanel.TabIndex = 0;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(categories1);
            Controls.Add(searchPanel);
            Controls.Add(panel2);
            Name = "Search";
            Size = new Size(1297, 1271);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel10;
        private TextBox textBox1;
        private Label lNewFeed;
        private Label lRollCall;
        private Label lCategory;
        private Categories categories1;
        private FlowLayoutPanel searchPanel;
    }
}
