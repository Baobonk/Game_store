using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BaoCAo.CustomForm
{
    public partial class MyPanelControl : UserControl
    {
        public MyPanelControl()
        {
            InitializeComponent();
            InitializeCustomPanel();
        }

        private void InitializeComponent()
        {
            this.panel1 = new Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            this.panel1.BackColor = Color.Transparent;
            this.panel1.BackgroundImage = Properties.Resources._17c44040a61b11efb55e093e10ade9bd;
            this.panel1.BackgroundImageLayout = ImageLayout.Stretch;
            this.panel1.Location = new Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(300, 200);
            this.panel1.TabIndex = 0;
            // 
            // MyPanelControl
            // 
            this.Controls.Add(this.panel1);
            this.Name = "MyPanelControl";
            this.Size = new Size(300, 200);
            this.ResumeLayout(false);
        }

        private void InitializeCustomPanel()
        {
            // Bật DoubleBuffering cho panel
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();
        }

        private Panel panel1;
    }
}
