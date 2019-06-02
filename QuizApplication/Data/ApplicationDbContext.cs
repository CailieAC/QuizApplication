using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuizApplication.Models;

namespace QuizApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Quiz> Quizzes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
