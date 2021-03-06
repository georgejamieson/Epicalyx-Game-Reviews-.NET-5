using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Epicalyx_Game_Reviews_.NET_5.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

    public class Epicalyx_Game_Reviews_NET_5ContextDb : IdentityDbContext<IdentityUser, IdentityRole, string>
{
        public Epicalyx_Game_Reviews_NET_5ContextDb (DbContextOptions<Epicalyx_Game_Reviews_NET_5ContextDb> options)
            : base(options)
        {
        }

        public DbSet<Epicalyx_Game_Reviews_.NET_5.Models.Game> Game { get; set; }

        public DbSet<Epicalyx_Game_Reviews_.NET_5.Models.FinalReview> FinalReview { get; set; }

        public DbSet<Epicalyx_Game_Reviews_.NET_5.Models.User> User { get; set; }

        public DbSet<Epicalyx_Game_Reviews_.NET_5.Models.AspectReview> AspectReview { get; set; }
    }
