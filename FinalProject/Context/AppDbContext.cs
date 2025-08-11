using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace FinalProject.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { Batteries.Init(); }

        public AppDbContext()
        {
            Batteries.Init();
        }

        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Detecta si está en design-time (cuando EF crea el contexto para migraciones)
                bool isDesignTime = AppDomain.CurrentDomain.FriendlyName == "ef";

                string basePath;

                if (isDesignTime)
                {
                    // Carpeta del proyecto para evitar permisos raros
                    basePath = Path.Combine(Directory.GetCurrentDirectory(), "App_Data");
                }
                else
                {
                    // En runtime, usa AppData del usuario
                    basePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FinalProject", "database");
                }

                Directory.CreateDirectory(basePath);

                var dbPath = Path.Combine(basePath, "app.db");
                var conn = $"Data Source={dbPath};Cache=Shared;Foreign Keys=True;";

                optionsBuilder.UseSqlite(conn);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>(x =>
            {
                x.HasKey(x => x.Id);
            });
        }
    }
}
