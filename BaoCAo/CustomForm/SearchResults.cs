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
    public partial class SearchResults : UserControl
    {
        private Game game1;
        public event EventHandler<GameEventArgs> clicked;
        public SearchResults()
        {
            InitializeComponent();
        }

        public Game Game
        {
            get { return game1; }
            set { game1 = value; }
        }

        public void setValue(Game g)
        {
            game1 = g;
            SetPanelBackgroundImage(panel1, g);
            label1.Text = g.Title;
            label2.Text = g.Price.ToString() + "đ";
        }

        private void SetPanelBackgroundImage(Panel panel, Game game)
        {
            game1 = game;
            if (System.IO.File.Exists(game.UrlTheme))
            {
                Image image = Image.FromFile(game.UrlTheme);
                panel.BackgroundImage = image;
                panel.BackgroundImageLayout = ImageLayout.Stretch; // Cách hình ảnh được hiển thị trong Panel
            }
            else
            {
                Console.WriteLine("Hình ảnh không tồn tại tại đường dẫn đã chỉ định.(fBody)");
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            clicked?.Invoke(this, new GameEventArgs(game1));           
        }
    }
}
