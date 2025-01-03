using BaoCAo.Class.Connection;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace BaoCAo.Class.Component
{
    public class Customer : User
    {
        private int age;
        private float balance;
        private List<string> transactionHistory = new List<string>();
        private Library library;

        public Customer() : base()
        { }

        public Customer(int userID, string name, string email, string password, UserRole role, bool isBanned, int age, float balance, string urlava, string urlthm)
            : base(userID, name, email, password, role, isBanned, urlava, urlthm)
        {
            this.age = age;
            this.balance = balance;
            this.library = new Library(userID, userID); // Giả sử IDLibrary là userID
        }

        // Thuộc tính với phương thức get và set
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

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public List<string> TransactionHistory
        {
            get { return transactionHistory; }
            set { transactionHistory = value; }
        }

        public Library Library
        {
            get { return library; }
            set { library = value; }
        }

        // Phương thức để thêm tiền vào tài khoản
        public void AddFunds(float amount)
        {
            this.balance += amount;
            Console.WriteLine($"Đã thêm {amount} vào tài khoản. Số dư hiện tại: {this.balance}");
        }

        // Phương thức để kiểm tra số dư
        public void CheckBalance()
        {
            Console.WriteLine($"Số dư hiện tại: {this.balance}");
        }

        // Phương thức để xem lịch sử giao dịch
        public void ViewTransactionHistory()
        {
            Console.WriteLine("Lịch sử giao dịch:");
            foreach (var transaction in transactionHistory)
            {
                Console.WriteLine(transaction);
            }
        }

        // Phương thức để thêm game vào thư viện
        public void AddGameToLibrary(Game game)
        {
            library.AddGame(game);
        }

        // Phương thức lấy tất cả khách hàng
        public static List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            Connect connection = new Connect();
            connection.OpenConnection();
            string query = "SELECT userID, userName, email, userPassword, role, isBanned, age, balance, urlAvatar, urlTheme FROM Users WHERE role = 'customer'";
            using (SqlCommand cmd = new SqlCommand(query, connection.sqlConnection))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Customer customer = new Customer(
                            reader.GetInt32(0), // userID
                            reader.GetString(1), // userName
                            reader.GetString(2), // email
                            reader.GetString(3), // userPassword
                            Enum.Parse<UserRole>(reader.GetString(4)), // role
                            reader.GetBoolean(5), // isBanned
                            reader.GetInt32(6), // age
                            (float)reader.GetDouble(7), // balance
                            reader.GetString(8), // urlAvatar
                            reader.GetString(9)  // urlTheme
                        );
                        customers.Add(customer);
                    }
                }
            }
            connection.CloseConnection();
            return customers;
        }
    }
}
