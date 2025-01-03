using BaoCAo.Class.Component;
using BaoCAo.Class.CustomEvt;
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
using static Azure.Core.HttpHeader;

namespace BaoCAo.CustomForm
{
    public partial class Search : UserControl
    {
        public event EventHandler<GameEventArgs> SearchChanged;
        public Search()
        {
            InitializeComponent();
        }

        private void lCategory_Click(object sender, EventArgs e)
        {
            categories1.Visible = !categories1.Visible;
        }

        public void setSearchValues(List<Game> games)
        {
            searchPanel.Controls.Clear();
            foreach (Game game in games)
            {
                SearchResults results = new SearchResults();
                results.setValue(game);
                results.clicked += ResultClicked;
                searchPanel.Controls.Add(results);
            }
        }

        private void ResultClicked(object sender, GameEventArgs e)
        {
            SearchChanged?.Invoke(this,e);
        }
    }
}
