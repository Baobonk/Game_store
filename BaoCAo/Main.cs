using BaoCAo.Class.Component;
using BaoCAo.Class.CustomEvt;
using BaoCAo.CustomForm;
using System.Diagnostics;

namespace BaoCAo
{
    public partial class Main : Form
    {
        private User user = new();

        public Main()
        {
            InitializeComponent();
        }

        public User u
        {
            get { return user; }
            set { user = value; }
        }

        public void Showsearch(String name)
        {
            disableBodyComponent();
            search1.setSearchValues(Game.SearchGameByName(name));
            search1.BringToFront();
            search1.Visible = true;
        }

        public void Showfbody()
        {
            disableBodyComponent();
            fBody1.BringToFront();
            fBody1.Visible = true;
        }

        public void disableBodyComponent()
        {
            search1.Visible = false;
            fBody1.Visible = false;
        }



        private void rs_Cliked(object sender, GameEventArgs e)
        {

            Debug.WriteLine(e.Game.Title);
        }

        private void lStore_Click(object sender, EventArgs e)
        {
            Showfbody();
        }
    }
}
