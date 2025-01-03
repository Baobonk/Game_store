using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCAo.Class.Component
{
    public class Rating
    {
        private int idUser;
        private int idGame;
        private int score;
        private string timeStamp;

        public Rating(int idUser, int idGame, int score, string timeStamp)
        {
            this.idUser = idUser;
            this.idGame = idGame;
            this.score = score;
            this.timeStamp = timeStamp;
        }

        public int IDUser
        {
            get { return idUser; }
            set { idUser = value; }
        }

        public int IDGame
        {
            get { return idGame; }
            set { idGame = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public string TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }

        public void Add()
        {
            // Thực hiện thêm đánh giá vào cơ sở dữ liệu
        }

        public void Remove()
        {
            // Thực hiện xóa đánh giá khỏi cơ sở dữ liệu
        }
    }

}
