// Codigo do Arquivo 
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIEscola.Data
{
    public class APIEscolaContext : IdentityDbContext
    {
        //construtor que recebe as opções de configuração do DbContext
        public APIEscolaContext(DbContextOptions<APIEscolaContext> options) : base(options)
        {
        }
        //propriedade dbset para cada tabela
        //Sobrecarga do método OnModelCreating para configurar o modelo a partir da IndetityDbContext
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // chama o método onModelCreating da classe base para a criação das tabelas padrão
            base.OnModelCreating(modelBuilder);
            //configurar a criação de tabelas adicionais aqui 
        }
    }
}
