using Codere.Models;
using Microsoft.EntityFrameworkCore;

namespace Codere.Controllers.DB
{
    public class TvMaze : DbContext
    {
        public DbSet<Information> Information { get; set; }

        public TvMaze(DbContextOptions<TvMaze> options) : base(options) { }

    }
}
