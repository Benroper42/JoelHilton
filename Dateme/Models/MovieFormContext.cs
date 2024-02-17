using Microsoft.EntityFrameworkCore;

namespace JoelHilton.Models;

public class MovieFormContext : DbContext 
{
    public MovieFormContext(DbContextOptions<MovieFormContext> options) : base (options) // controller
    {
    }

    public DbSet<Application> Application { get; set; }
}
