
using System.ComponentModel.DataAnnotations;
namespace APIEscola.Models
{
    public class Turma
    {
        public Guid TurmaId { get; set; }
        [Required(ErrorMessage = "O Campo Data de inicio é Obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "A Data Informada não é Válida")]


        public DateOnly Inicio { get; set; }
        [Required(ErrorMessage = "O Campo Data de fim é Obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "A Data Informada não é Válida")]

        public DateOnly Fim { get; set; }
        [Required(ErrorMessage = "O Campo Nome é Obrigatório")]
        [MaxLength(8, ErrorMessage = "O Nome deve ter no máximo 8 caracteres")]
        public string? sigla { get; set; }
        [Required(ErrorMessage = "O Campo Descrição é Obrigatório")]
        [MaxLength(255, ErrorMessage = "A Descrição deve ter no máximo 255 caracteres")]
        public string? descricao { get; set; }
        public Guid? CursoId { get; set; }
        public Curso? Curso { get; set; }

    }
}
