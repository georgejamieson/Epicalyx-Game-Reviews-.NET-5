﻿using System.ComponentModel.DataAnnotations;

namespace Epicalyx_Game_Reviews_.NET_5.Models
{
    public class FinalReview
    {

        public int FinalReviewID { get; set; }


        public string Review { get; set; }

        [Display(Name = "Final Rating")]
        [Range(0,5, ErrorMessage = "Your rating must be between 0 and 5 Stars (★)")]
        public int FinalRating { get; set; }

        [Display(Name = "Username")]
        public int GameID { get; set; }

        [Display(Name = "User Name")]
        public int UserID { get; set; }


        public Game Game { get; set; }
        public User User { get; set; }

    }
}