using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCAo.Class.Component
{
    public class Library
    {
        private int IDUser;
        private List<(Game Game, DateTime AddedOn)> ListGame;
        private int IDLibrary;

        public Library(int idUser, int idLibrary)
        {
            IDUser = idUser;
            IDLibrary = idLibrary;
            ListGame = new List<(Game, DateTime)>();
        }

        public Library()
        {
        }

        public int iduser
        {
            get { return IDUser; }
            set { IDUser = value; }
        }

        public int idlibrary
        {
            get { return IDLibrary; }
            set { IDLibrary = value; }
        }

        public List<(Game Game, DateTime AddedOn)> listgame
        {
            get { return ListGame; }
            set { ListGame = value; }
        }

        // Phương thức để thêm game vào thư viện
        public void AddGame(Game game)
        {
            ListGame.Add((game, DateTime.Now));
        }

        // Phương thức để xóa game khỏi thư viện
        public void RemoveGame(Game game)
        {
            ListGame.RemoveAll(g => g.Game.GameID == game.GameID);
        }

        // Phương thức để lấy danh sách game trong thư viện
        public List<(Game Game, DateTime AddedOn)> GetGames()
        {
            return ListGame;
        }
    }
}
