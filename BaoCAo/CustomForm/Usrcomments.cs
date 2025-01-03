using BaoCAo.Class.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BaoCAo.CustomForm
{
    public partial class Usrcomments : UserControl
    {
        public Usrcomments()
        {
            InitializeComponent();
        }
        public Usrcomments(Comment comment) : this()
        {
            Username.Text = comment.Username;
            Contents.Text = comment.Content;
            Date.Text = comment.TimeStamp.ToString(); // Format date as needed }
            Debug.WriteLine($"UserCommentControl created for: {comment.Username} - {comment.Content} - {comment.TimeStamp}");
        }

    }
}
