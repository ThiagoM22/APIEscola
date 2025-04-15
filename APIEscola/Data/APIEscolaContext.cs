// Codigo do Arquivo 
using APIEscola.Models;
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
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        //Sobrecarga do método OnModelCreating para configurar o modelo a partir da IndetityDbContext
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // chama o método onModelCreating da classe base para a criação das tabelas padrão
            base.OnModelCreating(modelBuilder);
            //configurar a criação de tabelas adicionais aqui 
            modelBuilder.Entity<Aluno>().ToTable("Alunos");
            modelBuilder.Entity<Curso>().ToTable("Cursos");
            modelBuilder.Entity<Turma>().ToTable("Turmas");
            modelBuilder.Entity<Matricula>().ToTable("Matriculas");
        }
    }
}
