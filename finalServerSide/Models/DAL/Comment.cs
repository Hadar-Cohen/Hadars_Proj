using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalServerSide.Models.DAL
{
    public class Comment
    {
        int commentId;
        string currDate;
        int userId;
        int seriesId;
        string content;
        public Comment() { }
        public Comment(int commentId, string currDate, int userId, int seriesId, string content)
        {
            this.commentId = commentId;
            this.currDate = currDate;
            this.userId = userId;
            this.seriesId = seriesId;
            this.content = content;
        }


        public int CommentId { get => commentId; set => commentId = value; }
        public string CurrDate { get => currDate; set => currDate = value; }
        public int UserId { get => userId; set => userId = value; }
        public int SeriesId { get => seriesId; set => seriesId = value; }
        public string Content { get => content; set => content = value; }
    }
}