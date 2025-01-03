using BaoCAo.Class.Connection;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Diagnostics;

namespace BaoCAo.Class.Component
{
    public enum UserRole
    {
        admin,
        customer,
        publisher
    }

    public class User
    {
        protected int userID;
        protected string name;
        protected string email;
        protected string password;
        protected UserRole role;
        protected bool isBanned;
        protected string urlAva;
        protected string urlThm;
        protected Cart cart;

        public User() { }

        public User(int userID, string name, string email, string password, UserRole role, bool isBanned, string urlAva, string urlThm)
        {
            this.userID = userID;
            this.name = name;
            this.email = email;
            this.password = password;
            this.role = role;
            this.isBanned = isBanned;
            this.urlAva = urlAva;
            this.urlThm = urlThm;
        }

        public int UserID
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
            set { UrlAva = value; }
        }

        public string UrlThm
        {
            get { return urlThm; }
            set { urlThm = value; }
        }

        public Cart UserCart 
        { 
            get { return cart; }
            set { cart = value; }
        }

        // Register method
        public void Register()
        {
            Connect dbconnect = new Connect();
            dbconnect.OpenConnection();
            using (SqlConnection conn = dbconnect.sqlConnection)
            {
                string query = "INSERT INTO Users (userName, userPassword, email, age, balance, role, isBanned) " +
                               "VALUES (@userName, @userPassword, @Email, @age, @balance, @role, @isBanned)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userName", Name);
                    cmd.Parameters.AddWithValue("@userPassword", Password);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@age", DBNull.Value);
                    cmd.Parameters.AddWithValue("@balance", DBNull.Value);
                    cmd.Parameters.AddWithValue("@role", Role.ToString());
                    cmd.Parameters.AddWithValue("@isBanned", IsBanned);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Registration successful!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    finally
                    {
                        dbconnect.CloseConnection();
                    }
                }
            }
        }
        // Login method
        public static User Login(string username, string password)
        {
            User user = null; // Khởi tạo đối tượng User là null
            Connect dbconnect = new Connect();
            dbconnect.OpenConnection();
            try
            {
                using (SqlConnection conn = dbconnect.sqlConnection)
                {
                    string query = @"
                SELECT userID, userName, email, userPassword, role, isBanned, urlAvatar, urlTheme 
                FROM Users 
                WHERE userName = @userName 
                AND userPassword = @userPassword 
                AND isBanned = 0";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userName", username);
                        cmd.Parameters.AddWithValue("@userPassword", password);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new User(
                                    reader.GetInt32(0),       // userID
                                    reader.GetString(1),      // userName
                                    reader.GetString(2),      // email
                                    reader.GetString(3),      // userPassword
                                    Enum.Parse<UserRole>(reader.GetString(4)),  // role
                                    reader.GetBoolean(5),     // isBanned
                                    reader.GetString(6),      // urlAvatar
                                    reader.GetString(7)       // urlTheme
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("User login error: " + ex.Message);
            }
            finally
            {
                dbconnect.CloseConnection();
            }
            return user; // Trả về đối tượng User hoặc null nếu đăng nhập thất bại
        }
        // Forgot password method
        public void ForgotPassword()
        {
            Connect dbconnect = new Connect();
            dbconnect.OpenConnection();
            using (SqlConnection conn = dbconnect.sqlConnection)
            {
                string query = "SELECT COUNT(*) FROM User WHERE Email = @Email";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", Email);

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        Console.WriteLine("Password reset email sent to: " + Email);
                    }
                    else
                    {
                        Console.WriteLine("Email does not exist in the system.");
                    }
                    dbconnect.CloseConnection();
                }
            }
        }

        // Method to get all User
        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            Connect dbconnect = new Connect();
            dbconnect.OpenConnection();
            using (SqlConnection conn = dbconnect.sqlConnection)
            {
                string query = "SELECT userID, userName, email, userPassword, role, isBanned, urlAvatar, urlTheme FROM Users";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                Enum.Parse<UserRole>(reader.GetString(4)),
                                reader.GetBoolean(5),
                                reader.GetString(6),
                                reader.GetString(7)
                            );
                            users.Add(user);
                        }
                    }
                }
                dbconnect.CloseConnection();
            }
            return users;
        }

        // Method to get user details
        public User GetUserDetails(string username)
        {
            Connect dbconnect = new Connect();
            dbconnect.OpenConnection();
            User user = new User();

            using (SqlConnection conn = dbconnect.sqlConnection)
            {
                string query = @"SELECT userID, userName, email, userPassword, role, isBanned, urlAvatar, urlTheme FROM Users WHERE userName = @username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userName", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                Enum.Parse<UserRole>(reader.GetString(4)),
                                reader.GetBoolean(5),
                                reader.GetString(6),
                                reader.GetString(7)
                            );
                        }
                    }
                }
                dbconnect.CloseConnection();
                return user;
            }
        }

        // Method to update user info
        public void UpdateUserInfo(string username, string phone, string gender, DateTime birthDate)
        {
            Connect dbconnect = new Connect();
            dbconnect.OpenConnection();
            using (SqlConnection conn = dbconnect.sqlConnection)
            {
                string query = @"UPDATE Users SET gender = @gender, phone = @phone, age = @age WHERE userName = @username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userName", username);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@age", birthDate);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User information updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                dbconnect.CloseConnection();
            }
        }

        // Method to update user password
        public void UpdatePassword(string username, string newPassword, string currentPassword)
        {
            Connect dbconnect = new Connect();
            dbconnect.OpenConnection();
            using (SqlConnection conn = dbconnect.sqlConnection)
            {
                string query = @"SELECT userPassword FROM Users WHERE userName = @username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    string dbPassword = cmd.ExecuteScalar()?.ToString();
                    if (dbPassword != currentPassword)
                    {
                        MessageBox.Show("Current password doesn't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }
        public void AddGameToCart(Game game)
        {
            if (game != null)
            {
                cart.AddGame(game);
                Console.WriteLine($"User {name} added Game {game.Title} to the cart.");
            }
            else
            {
                Console.WriteLine("Game not found.");
            }
        }
    }
}
