﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Epicalyx_Game_Reviews_.NET_5.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }

        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        public int ProfilePic { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public List<FinalReview> FinalReview { get; set; }
        public List<AspectReview> AspectReview { get; set; }
    }
}