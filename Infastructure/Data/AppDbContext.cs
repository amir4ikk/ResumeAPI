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
            Email = "isroilov0905@gmail.com",
            Gender = Gender.Male,
            PasswordHash = "6596443e7768f0c1ae055535783a3b6fcd3c2efb4fc0725336e31e087c4d10fc",
            Role = Roles.SuperAdmin
        });
    }
}
