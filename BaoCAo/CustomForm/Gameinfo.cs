using System;
using System.Windows.Forms;
using BaoCAo;
using BaoCAo.Class.Component;
using BaoCAo.CustomForm;

namespace BaoCAo
{
    public partial class Gameinfo : UserControl
    {
        //SlateGray,Darkgray,176, 255, 0,Lime green

        private string _usn;
        private int _gameid;
        private Game _game;
        private User _user;

        public Gameinfo()
        {
            InitializeComponent();
            _game = new Game();
        }

        public string Username
        {
            get { return _usn; }
            set { _usn = value; }
        }

        public int GameID
        {
            get { return _gameid; }
            set
            {
                _gameid = value;
                LoadGameAndComments(_gameid); // Automatically load game info when game ID is set
            }
        }
        public void Initialize(User user, int gameId)
        {
            _user = user;
            GameID = gameId;
        }
        public void LoadGameInfo(int gameId)
        {
            Game gameDetails = _game.GetGameDetails(2); //chỉnh lại về gameid, đang để 2 để test
            if (gameDetails != null)
            {
                GTitle1.Text = gameDetails.Title;
                GTitle2.Text = "Buy " + gameDetails.Title + " now";
                Gdes.Text = gameDetails.Detail;
                price.Text = gameDetails.Price + " $";
                _game.LoadImage(gameDetails.UrlPoster, Gposter);
            }
            else
            {
                MessageBox.Show("Game not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ATClb_MouseHover(object sender, EventArgs e)
        {
            ATClb.ForeColor = Color.LightGray;
        }

        private void ATClb_MouseLeave(object sender, EventArgs e)
        {
            ATClb.ForeColor = Color.Black;
        }
        public void LoadGameAndComments(int gameId)
        {
            LoadGameInfo(gameId);
            List<Comment> comments = Comment.GetCommentsbygameid(gameId);
            LoadComments(comments);
        }
        private void LoadComments(List<Comment> comments)
        {
            CommentSection.Controls.Clear();
            foreach (var comment in comments)
            {
                var commentControl = new Usrcomments(comment);
                CommentSection.Controls.Add(commentControl);
            }
        }
        private void GATC_Click(object sender, EventArgs e)
        {
            if (_user != null && _gameid != 0)
            {
                Game gameDetails = _game.GetGameDetails(_gameid);
                if (gameDetails != null)
                {
                    _user.AddGameToCart(gameDetails);
                    MessageBox.Show("Game added to cart!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Game not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error adding game to cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
