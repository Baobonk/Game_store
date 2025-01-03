using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCAo.Class.Component
{
    public class Wishlist
    {
        private int IDUser;
        private List<(Game Game, DateTime AddedOn)> ListGame;
        private int IDWishlist;
        private int Quantity;

        public Wishlist(int idUser, int idWishlist)
        {
            IDUser = idUser;
            IDWishlist = idWishlist;
            ListGame = new List<(Game, DateTime)>();
        }

        public Wishlist()
        {
        }

        public int iduser
        {
            get { return IDUser; }
            set { IDUser = value; }
        }

        public int idWishlist
        {
            get { return IDWishlist; }
            set { IDWishlist = value; }
        }

        public List<(Game Game, DateTime AddedOn)> listgame
        {
            get { return ListGame; }
            set { ListGame = value; }
        }

        public int quantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }

        // Phương thức để thêm game vào danh sách ước
        public void AddGame(Game game)
        {
            ListGame.Add((game, DateTime.Now));
        }

        // Phương thức để xóa game khỏi danh sách ước
        public void RemoveGame(Game game)
        {
            ListGame.RemoveAll(g => g.Game.GameID == game.GameID);
        }

        // Phương thức để lấy danh sách game trong danh sách ước
        public List<(Game Game, DateTime AddedOn)> GetGames()
        {
            return ListGame;
        }
    }
}
