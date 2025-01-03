using BaoCAo.Class.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCAo.CustomForm
{
    public partial class GameShowRoom : UserControl
    {
        private Dictionary<Panel, Game> panelImageMap;
        public event EventHandler<ImageEventArgs> ButtonClicked;
        public GameShowRoom()
        {
            InitializeComponent();
            panelImageMap = new Dictionary<Panel, Game>();
        }
        public void setPoster(Panel panel)
        {
            if (panelImageMap.TryGetValue(panel, out Game game))
            {
                SetPanelBackgroundImage(Poster, game);
            }
            OnButtonClicked(new ImageEventArgs(game.UrlTheme));
            setText(game);
        }


        protected virtual void OnButtonClicked(ImageEventArgs e)
        {
            if (ButtonClicked != null)
                ButtonClicked(this, e);
        }


        private void panel7Click(object sender, EventArgs e)
        {
            setPoster(panel7);
        }

        private void panel8Click(object sender, EventArgs e)
        {
            setPoster(panel8);
        }

        private void panel9Click(object sender, EventArgs e)
        {
            setPoster(panel9);
        }

        private void panel10Click(object sender, EventArgs e)
        {
            setPoster(panel10);
        }

        private void panel11Click(object sender, EventArgs e)
        {
            setPoster(panel11);
        }
    }
    public class ImageEventArgs : EventArgs
    {
        public string ImagePath { get; private set; }

        public ImageEventArgs(string imagePath)
        {
            ImagePath = imagePath;
        }
    }
}
