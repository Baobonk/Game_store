using BaoCAo.Class.Connection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCAo.Class.Component
{
    internal class Admin : User
    {
        public Admin()
        {
        }

        public Admin(int userID, string name, string email, string password, UserRole role, bool isBanned,string urlava,string urlthm)
    : base(userID, name, email, password, role, isBanned,urlava,urlthm)
        {
        }

        // Phương thức thêm game
        public static void AddGame(Game game, User user)
        {
            Connect connection = new Connect();
            connection.OpenConnection();

            string query = "INSERT INTO Games (Title, Detail, Genres, Price, PublisherID) VALUES (@Title, @Detail, @Genres, @Price, @PublisherID)";
            using (SqlCommand cmd = new SqlCommand(query, connection.sqlConnection))
            {
                cmd.Parameters.AddWithValue("@Title", game.Title);
                cmd.Parameters.AddWithValue("@Detail", game.Detail);
                cmd.Parameters.AddWithValue("@Genres", string.Join(",", game.Genres));
                cmd.Parameters.AddWithValue("@Price", game.Price);
                cmd.Parameters.AddWithValue("@PublisherID", game.PublisherID);

                try
                {
                    cmd.ExecuteNonQuery();
                    Debug.WriteLine("Game đã được thêm thành công!");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Lỗi(AddGame): " + ex.Message);
                }
                finally
                {
                    connection.CloseConnection();
                }
            }
        }

        // Phương thức xóa game
        public static void DeleteGame(int gameID, User user)
        {
            Connect connection = new Connect();
            connection.OpenConnection();

            string query = "DELETE FROM Games WHERE GameID = @GameID";
            using (SqlCommand cmd = new SqlCommand(query, connection.sqlConnection))
            {
                cmd.Parameters.AddWithValue("@GameID", gameID);

                try
                {
                    cmd.ExecuteNonQuery();
                    Debug.WriteLine("Game đã bị xóa!");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Lỗi(DeleteGame): " + ex.Message);
                }
                finally
                {
                    connection.CloseConnection();
                }
            }
        }

        // Phương thức chỉnh sửa thông tin game
        public static void EditGame(Game game, User user)
        {
            Connect connection = new Connect();
            connection.OpenConnection();

            string query = "UPDATE Games SET Title = @Title, Detail = @Detail, Genres = @Genres, Price = @Price WHERE GameID = @GameID";
            using (SqlCommand cmd = new SqlCommand(query, connection.sqlConnection))
            {
                cmd.Parameters.AddWithValue("@Title", game.Title);
                cmd.Parameters.AddWithValue("@Detail", game.Detail);
                cmd.Parameters.AddWithValue("@Genres", string.Join(",", game.Genres));
                cmd.Parameters.AddWithValue("@Price", game.Price);
                cmd.Parameters.AddWithValue("@GameID", game.GameID);

                try
                {
                    cmd.ExecuteNonQuery();
                    Debug.WriteLine("Thông tin game đã được chỉnh sửa!");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Lỗi(EditGame): " + ex.Message);
                }
                finally
                {
                    connection.CloseConnection();
                }
            }
        }
    }
}
