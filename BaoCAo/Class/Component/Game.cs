using BaoCAo.Class.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace BaoCAo.Class.Component
{
    public class Game
    {
        private int gameID;
        private string title;
        private string detail;
        private List<string> genres = new List<string>();
        private double price;
        private double score;
        private int publisherID; // ID của Publisher sở hữu game này
        private List<int> userIDs; // ID của các tài khoản sở hữu game này
        private string urlPoster;
        private string urlTheme;

        public Game()
        {
        }

        public Game(int gameID, string title, string detail, double price, double score, int publisherID, string urlposter, string urltheme, List<string> genre)
        {
            this.gameID = gameID;
            this.title = title;
            this.detail = detail;
            this.genres = genre;
            this.price = price;
            this.score = score;
            this.publisherID = publisherID;
            //this.userIDs = new List<int>();
            this.urlPoster = urlposter;
            this.urlTheme = urltheme;
        }

        // Các thuộc tính với phương thức get và set
        public int GameID
        {
            get { return gameID; }
            set { gameID = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Detail
        {
            get { return detail; }
            set { detail = value; }
        }

        public List<string> Genres
        {
            get { return genres; }
            set { genres = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Score
        {
            get { return score; }
            set { score = value; }
        }

        public int PublisherID
        {
            get { return publisherID; }
            set { publisherID = value; }
        }

        public List<int> UserIDs
        {
            get { return userIDs; }
            set { userIDs = value; }
        }

        public string UrlPoster
        {
            get { return urlPoster; }
            set { urlPoster = value; }
        }

        public string UrlTheme
        {
            get { return urlTheme; }
            set { urlTheme = value; }
        }

        // Phương thức để thêm người dùng sở hữu game
        public void AddUser(int userID)
        {
            if (!userIDs.Contains(userID))
            {
                userIDs.Add(userID);
            }
        }

        // Phương thức để thêm thể loại vào game
        public void AddGenre(string genre)
        {
            if (!Genres.Contains(genre))
            {
                Genres.Add(genre);
            }
        }

        public void LoadImage(string imagePath, Panel picture)
        {
            try
            {
                Image image = Image.FromFile(imagePath);
                picture.BackgroundImage = image;
                picture.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức để xóa thể loại khỏi game
        public void RemoveGenre(string genre)
        {
            Genres.Remove(genre);
        }

        // Phương thức kiểm tra quyền truy cập
        private bool HasAccess(User user)
        {
            return user.Role == UserRole.admin || (user.Role == UserRole.publisher && user.UserID == PublisherID);
        }
        // Phương thức kiểm tra quyền truy cập của admin
        private bool HasAdminAccess(User user)
        {
            return user.Role == UserRole.admin;
        }
        // Phương thức lấy thể loại của game
        public static List<string> GetGenreNamesByGameId(int gameId)
        {
            List<string> genreNames = new List<string>();
            Connect connection = new Connect();
            try
            {
                connection.OpenConnection();
                string query = @"
                SELECT g.Name 
                FROM Genres g
                JOIN GenreGame gg ON g.GenreID = gg.GenreID
                WHERE gg.GameID = @GameID";
                using (SqlCommand cmd = new(query, connection.sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@GameID", gameId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            genreNames.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi(GetGenreNamesByGameId): " + ex.Message);
            }

            return genreNames;
        }

        // Phương thức lấy tất cả game
        public static List<Game> GetAllGames(User user)
        {
            List<Game> games = new List<Game>();
            Connect connection = new Connect();

            try
            {
                connection.OpenConnection();
                string query = user.Role == UserRole.admin ? "SELECT * FROM Games" : "SELECT * FROM Games WHERE PublisherID = @PublisherID";

                using (SqlCommand cmd = new(query, connection.sqlConnection))
                {
                    if (user.Role == UserRole.publisher)
                    {
                        cmd.Parameters.AddWithValue("@PublisherID", user.UserID);
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            games.Add(new Game(
                                    reader.GetInt32(0),//int
                                    reader.GetString(1),//nvarchar
                                    reader.GetString(2),//nvarchar
                                    reader.GetDouble(3),//double
                                    reader.GetDouble(4),//double
                                    reader.GetInt32(5),//int
                                    reader.GetString(6),//nvarchar
                                    reader.GetString(7),//nvarcha
                                    GetGenreNamesByGameId(reader.GetInt32(0))
                            ));
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Lỗi(GetAllGames): " + ex.Message);
            }
            finally
            {
                connection.CloseConnection();
            }

            return games;
        }

        // Phương thức tìm kiếm game theo ID
        public static Game SearchByID(int gameID, User user)
        {
            Game game = new Game();
            Connect connection = new Connect();

            try
            {
                connection.OpenConnection();
                string query = "SELECT * FROM Games WHERE GameID = @GameID";

                using (SqlCommand cmd = new SqlCommand(query, connection.sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@GameID", gameID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            game = new Game(
                                    reader.GetInt32(0),//int
                                    reader.GetString(1),//nvarchar
                                    reader.GetString(2),//nvarchar
                                    reader.GetDouble(3),//double
                                    reader.GetDouble(4),//double
                                    reader.GetInt32(5),//int
                                    reader.GetString(6),//nvarchar
                                    reader.GetString(7),//nvarcha
                                    GetGenreNamesByGameId(reader.GetInt32(0))
                            );

                            if (!game.HasAccess(user))
                            {
                                game = null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi(SearchByID): " + ex.Message);
            }
            finally
            {
                connection.CloseConnection();
            }

            return game;
        }

        public static List<Game> GetAllGame()
        {
            List<Game> games = new List<Game>();
            Connect connection = new Connect();
            try
            {
                connection.OpenConnection(); // Mở kết nối
                if (connection.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    string query = "SELECT * FROM Games";

                    using (SqlCommand cmd = new SqlCommand(query, connection.sqlConnection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                games.Add(new Game(
                                    reader.GetInt32(0),//int
                                    reader.GetString(1),//nvarchar
                                    reader.GetString(2),//nvarchar
                                    reader.GetDouble(3),//double
                                    reader.GetDouble(4),//double
                                    reader.GetInt32(5),//int
                                    reader.GetString(6),//nvarchar
                                    reader.GetString(7),//nvarcha
                                    GetGenreNamesByGameId(reader.GetInt32(0))
                                ));
                            }
                        }
                    }
                }
                else
                {
                    Debug.WriteLine("Không thể mở kết nối tới cơ sở dữ liệu.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi(GetAllGame): " + ex.Message);
            }
            finally
            {
                connection.CloseConnection(); // Đảm bảo đóng kết nối
            }

            return games;
        }

        public static List<Game> SearchGameByName(String name)
        {
            List<Game> games = new List<Game>();
            Connect connection = new Connect();

            try
            {
                connection.OpenConnection();
                string query = "SELECT * FROM Games WHERE Title like @title";

                using (SqlCommand cmd = new(query, connection.sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@title", "%" + name + "%");


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            games.Add(new Game(
                                    reader.GetInt32(0),//int
                                    reader.GetString(1),//nvarchar
                                    reader.GetString(2),//nvarchar
                                    reader.GetDouble(3),//double
                                    reader.GetDouble(4),//double
                                    reader.GetInt32(5),//int
                                    reader.GetString(6),//nvarchar
                                    reader.GetString(7),//nvarcha
                                    GetGenreNamesByGameId(reader.GetInt32(0))
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi(SearchGameByName): " + ex.Message);
            }
            finally
            {
                connection.CloseConnection();
            }

            return games;
        }

        public Game GetGameDetails(int gameId)
        {
            Connect dbconnect = new Connect();
            dbconnect.OpenConnection();
            using (SqlConnection conn = dbconnect.sqlConnection)
            {
                Game game = null;
                string query = @"SELECT Title, Detail, Price, UrlPoster FROM Games WHERE GameID = @gameId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@gameId", gameId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            game = new Game
                            {
                                GameID = gameId,
                                Title = reader["Title"].ToString(),
                                Detail = reader["Detail"].ToString(),
                                Price = Convert.ToDouble(reader["Price"]),
                                UrlPoster = reader["UrlPoster"].ToString()
                            };
                        }
                    }
                }
                dbconnect.CloseConnection();
                return game;
            }
        }


    }
}
