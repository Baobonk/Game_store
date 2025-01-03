using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BaoCAo.Class.Connection
{
    internal class Connect
    {
        private string strCon = @"Data Source=(local);Initial Catalog=CSharp;Integrated Security=True;TrustServerCertificate=true";
        public SqlConnection sqlConnection;

        public Connect()
        {
            sqlConnection = new SqlConnection(strCon);
        }

        public void OpenConnection()
        {
            try
            {
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                {
                    sqlConnection.Open();
                    Console.WriteLine("Kết nối thành công với SQL Server!");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi kết nối: {ex.Message} (Mã lỗi: {ex.Number})");
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    sqlConnection.Close();
                    Console.WriteLine("Đã đóng kết nối với SQL Server.");
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Lỗi khi đóng kết nối: {ex.Message} (Mã lỗi: {ex.Number})");
                }
            }
        }
    }
}
