using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace APIEscola.Models
{
    public class Aluno
    {
        public Guid AlunoId { get; set; }

        [Required(ErrorMessage = "O Campo CPF é Obrigatório")]
        [StringLength(11, ErrorMessage = "O CPF deve ter 11 dígitos")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve conter apenas números")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O Campo Nome é Obrigatório")]
        [StringLength(100, ErrorMessage = "O Nome deve ter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo Data de Nascimento é Obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "A Data Informada não é Válida")]
        public DateOnly DataNascimento { get; set; }

        [Required(ErrorMessage = "O Campo Celular é Obrigatório")]
        [StringLength(11, ErrorMessage = "O Celular deve ter 11 dígitos")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O Celular deve conter apenas números")]
        public string Celular { get; set; }

        public Guid? UserId { get; set; }
        public IdentityUser? User { get; set; }

    }
}