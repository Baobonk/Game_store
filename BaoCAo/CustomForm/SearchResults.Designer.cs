namespace BaoCAo.CustomForm
{
    partial class SearchResults
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 90);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(265, 0);
            label1.Name = "label1";
            label1.Size = new Size(686, 96);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.Click += panel1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(957, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 96);
            label2.TabIndex = 2;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.Click += panel1_Click;
            // 
            // SearchResults
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "SearchResults";
            Size = new Size(1057, 96);
            Click += panel1_Click;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
    }
}
