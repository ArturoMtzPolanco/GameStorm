using GameStorm.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace GameStorm.Context
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options) { }
        //modelos a mapear
        Console.WriteLine("Hello World!");


        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    PkUsuario = 1,
                    Nombre = "arturo",
                    email = "admin@gmail.com",
                    Password = "123",
                    FkRol = 1
                });

            modelBuilder.Entity<Rol>().HasData(new Rol
            {
                PkRol = 1,
                Nombre = "Admin"
            });
        }
    }
}