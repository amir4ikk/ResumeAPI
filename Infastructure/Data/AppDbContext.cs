using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Infastructure.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options)
    : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Resume> Resumes { get; set; }
    public DbSet<Review> Reviews { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                FullName = "Ozodbek",
                Email = "ozodchik.krasavchik@gmail.com",
                Gender = Gender.Male,
                PasswordHash = "12345",
                Role = Roles.SuperAdmin
            });
    }
}
