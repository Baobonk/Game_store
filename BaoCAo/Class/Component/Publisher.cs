using BaoCAo.Class.Connection;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace BaoCAo.Class.Component
{
    public class Publisher : Customer
    {
        private List<Game> listGame = new List<Game>();

        public Publisher() : base()
        { }

        public Publisher(int userID, string name, string email, string password, UserRole role, bool isBanned, int age, float balance, List<Game> listGame, string urlAva, string urlThm)
            : base(userID, name, email, password, role, isBanned, age, balance, urlAva, urlThm)
        {
            this.listGame = listGame;
        }

        public int ID
        {
            get { return userID; }
            set { userID = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public UserRole Role
        {
            get { return role; }
            set { role = value; }
        }

        public bool IsBanned
        {
            get { return isBanned; }
            set { isBanned = value; }
        }

        public string UrlAva
        {
            get { return urlAva; }
            set { urlAva = value; }
        }

        public string UrlThm
        {
            get { return urlThm; }
            set { urlThm = value; }
        }

        // Thuộc tính với phương thức get và set
        public List<Game> ListGame
        {
            get { return listGame; }
            set { listGame = value; }
        }

        // Phương thức để quản lý giao dịch
        public void TransactionManagement()
        {
            Console.WriteLine("Quản lý giao dịch:");
            // Thêm logic quản lý giao dịch tại đây
        }

        // Phương thức để quản lý game
        public void GameManagement()
        {
            Console.WriteLine("Quản lý game:");
            foreach (var game in listGame)
            {
                Console.WriteLine($"Game: {game.Title}, Price: {game.Price}");
            }
            // Thêm logic quản lý game tại đây
        }

        // Phương thức để thêm game vào danh sách
        public void AddGame(Game game)
        {
            listGame.Add(game);
        }

        // Phương thức lấy tất cả nhà phát hành
        public static List<Publisher> GetAllPublishers()
        {
            List<Publisher> publishers = new List<Publisher>();
            Connect connection = new Connect();
            connection.OpenConnection();
            string query = "SELECT userID, userName, email, userPassword, role, isBanned, age, balance, urlAvatar, urlTheme FROM Users WHERE role = 'publisher'";
            using (SqlCommand cmd = new SqlCommand(query, connection.sqlConnection))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        UserRole role;
                        if (!Enum.TryParse<UserRole>(reader.GetString(4), true, out role))
                        {
                            throw new ArgumentException($"Requested value '{reader.GetString(4)}' was not found.");
                        }

                        Publisher publisher = new Publisher(
                            reader.GetInt32(0), // userID
                            reader.GetString(1), // userName
                            reader.GetString(2), // email
                            reader.GetString(3), // userPassword
                            role, // role
                            reader.GetBoolean(5), // isBanned
                            reader.GetInt32(6), // age
                            (float)reader.GetDouble(7), // balance
                            new List<Game>(), // Giả định rằng danh sách game chưa được lấy
                            reader.GetString(8), // urlAvatar
                            reader.GetString(9) // urlTheme
                        );
                        publishers.Add(publisher);
                    }
                }
            }
            connection.CloseConnection();
            return publishers;
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
