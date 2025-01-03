using BaoCAo.Class.Connection;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace BaoCAo.Class.Component
{
    public class Cart
    {
        private int IDUser;
        private List<(Game Game, DateTime AddedOn)> ListGame;
        private int IDCart;
        private int Quantity;


        public Cart(int idUser, int idCart)
        {
            IDUser = idUser;
            IDCart = idCart;
            ListGame = new List<(Game, DateTime)>();
        }

        public Cart()
        {
        }

        public int iduser
        {
            get { return IDUser; }
            set { IDUser = value; }
        }

        public int idCart
        {
            get { return IDCart; }
            set { IDCart = value; }
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

        // Phương thức để thêm game vào giỏ hàng
        public void AddGame(Game game)
        {
            // Thêm game vào ListGame với thời gian hiện tại
            ListGame.Add((game, DateTime.Now));

            // Thêm game vào cơ sở dữ liệu
            Connect dbconnect = new Connect();
            dbconnect.OpenConnection();
            using (SqlConnection conn = dbconnect.sqlConnection)
            {
                string query = "INSERT INTO CartGames (CartID, GameID) VALUES (@cartId, @gameId)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cartId", IDCart);
                    cmd.Parameters.AddWithValue("@gameId", game.GameID);
                    cmd.ExecuteNonQuery();
                }
            }

            Console.WriteLine($"Game {game.Title} added to the cart for UserID: {IDUser}.");
        }

        // Phương thức để xóa game khỏi giỏ hàng
        public void RemoveGame(Game game)
        {
            ListGame.RemoveAll(g => g.Game.GameID == game.GameID);
        }

        // Phương thức để lấy danh sách game trong giỏ hàng
        public List<(Game Game, DateTime AddedOn)> GetGames()
        {
            return ListGame;
        }
    }
}
