using System;
using Microsoft.EntityFrameworkCore;
using MusicApp.Models;

namespace MusicApp.Data
{
    public class MusicAppContext : DbContext 
    {
        public MusicAppContext(DbContextOptions<MusicAppContext> options)
            : base(options)
        {
        }

        public DbSet<Music> Music { get; set; }
    }
}
