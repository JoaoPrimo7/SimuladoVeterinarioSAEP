using SimuladoVeterinarioSAEP.Models;
using Microsoft.EntityFrameworkCore;

namespace SimuladoVeterinarioSAEP.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Tutor> Tutores { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
    }
}
