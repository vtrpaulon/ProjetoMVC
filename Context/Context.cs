namespace ProjetoMVC.Context
{
    public class CadastroContext : DbContext
    {
        public CadastroContext(DbContextOptions<CadastroContext> options) : base(options)
        {

        }
        public DbSet<Cadastro> Cadastros { get; set; }
    }
}