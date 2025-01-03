using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCAo.CustomForm
{
    public partial class fBody : UserControl
    {
        private Main s;
        public event EventHandler rsClicked;
        public fBody()
        {
            InitializeComponent();
        }

        public Main main
        {
            get { return s; }
            set { s = value; }
        }

        private void Invoke_Rs(object sender, EventArgs e)
        {
            rsClicked?.Invoke(this, e);
        }

        private void lCategory_Click(object sender, EventArgs e)
        {
            categories1.Visible = !categories1.Visible;
        }

        private void lRollCall_Click(object sender, EventArgs e)
        {

        }

        private void lNewFeed_Click(object sender, EventArgs e)
        {

        }

        private void categories1_MouseLeave(object sender, EventArgs e)
        {
            categories1.Visible = false;
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            s.Showsearch(textBox1.Text);
        }
    }
}
