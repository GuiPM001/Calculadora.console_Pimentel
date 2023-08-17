using Application.Model;
using Microsoft.EntityFrameworkCore;

namespace Application.Context
{
    public class OperacoesContext : DbContext
    {
        public DbSet<Operacao> OperacoesHistorico { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost,1433;Database=master;User Id=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;");
        }
    }
}
