using System;
using System.Collections.Generic;

namespace Epicalyx_Game_Reviews_.NET_5.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int ProfilePic { get; set; }

        public List<FinalReview> FinalReview { get; set; }
        public List<AspectReview> AspectReview { get; set; }
    }
}