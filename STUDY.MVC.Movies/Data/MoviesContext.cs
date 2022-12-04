using Microsoft.EntityFrameworkCore;
using STUDY.MVC.Movies.Models;

namespace STUDY.MVC.Movies.Data;

public class MoviesContext : DbContext
{
    public MoviesContext (DbContextOptions<MoviesContext> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movie { get; set; } = default!;
}
