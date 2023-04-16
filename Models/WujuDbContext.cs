using Microsoft.EntityFrameworkCore;
using wb_backend.Models;

namespace wb_backend.Models {

    public class WujuDbContext : DbContext {
        public DbSet<User> Users { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        private readonly IConfiguration _config;

        public WujuDbContext(IConfiguration config){
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(_config["ConnectionString"]);
    }
}