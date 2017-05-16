using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HungerGames.Models;

namespace HungerGames.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }


        public static void Initialize(ApplicationDbContext context)
        {

            context.Database.EnsureCreated();

            //Check if their's any activities created else create and add to context database.
            if (context.Activities.Any())
            {
                return;
            }
            else
            {
                var activities = new Activity[]
            {
        new Activity{Name="Namnet på aktiviteten", Paragraph="Här kommer massor av text senare", Status= Status.Online },
        new Activity{Name="Namnet på aktiviteten", Paragraph="Här kommer massor av text senare",Status= Status.Online},
        new Activity{Name="Namnet på aktiviteten", Status= Status.Online},
        new Activity{Name="Namnet på aktiviteten", Status= Status.Online},
        new Activity{Name="Namnet på aktiviteten", Status= Status.Online},
        new Activity{Name="Namnet på aktiviteten", Status= Status.Online},
        new Activity{Name="Namnet på aktiviteten", Status= Status.Online},
        new Activity{ Name="Namnet på aktiviteten", Status= Status.Online},
        new Activity{ Name="Namnet på aktiviteten", Status= Status.Online},
        new Activity{ Name="Namnet på aktiviteten", Status= Status.Offline},
        new Activity{ Name="Namnet på aktiviteten", Status= Status.Offline},
        new Activity{ Name="Namnet på aktiviteten", Status= Status.Offline},
        new Activity{ Name="Namnet på aktiviteten", Status= Status.Offline},
        new Activity{ Name="Namnet på aktiviteten", Status= Status.Offline},
        new Activity{ Name="Namnet på aktiviteten", Status= Status.Offline},
        new Activity{ Name="Namnet på aktiviteten", Status= Status.Offline},
        new Activity{ Name="Namnet på aktiviteten", Status=Status.Offline},
        new Activity{ Name="Namnet på aktiviteten", Status= Status.Offline},
            };
                foreach (var a in activities)
                {
                    context.Activities.Add(a);
                }
                context.SaveChanges();

            }

        }
       
protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
