using BaoCAo.Class.Connection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCAo.Class.Component
{
    public class Comment
    {
        private string UserName;
        private string content;
        private string timeStamp;

        public Comment(string UserName, string content, string timeStamp)
        {
            this.UserName = UserName;
            this.content = content;
            this.timeStamp = timeStamp;
        }

        public string Username
        {
            get { return UserName; }
            set { UserName = value; }
        }


        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public string TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }

        public static List<Comment> GetCommentsbygameid(int gameId)
        {
            List<Comment> commentslist = new List<Comment>();
            string query = @"SELECT 
                                Comments.CommentText,
                                Users.userName,
                                Comments.CommentDate
                            FROM 
                                Comments
                            JOIN 
                                Users ON Comments.UserID = Users.UserID
                            JOIN 
                                Games ON Comments.GameID = Games.GameID";
            Connect dbconnect = new Connect();
            try
            {
                dbconnect.OpenConnection();
                using (SqlConnection conn = dbconnect.sqlConnection)
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@GameID", gameId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string commentText = reader["CommentText"].ToString();
                                string userName = reader["userName"].ToString();
                                string date = Convert.ToDateTime(reader["CommentDate"]).ToString();
                                Comment comment = new Comment(userName, commentText, date);
                                commentslist.Add(comment);
                                Console.WriteLine($"Comment Retrieved: {userName} - {commentText} - {date}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving comments: " + ex.Message);
            }
            finally
            {
                dbconnect.CloseConnection();
            }
            return commentslist;
        }
        public void Remove()
        {
            // Thực hiện xóa bình luận khỏi cơ sở dữ liệu
        }
    }

}
