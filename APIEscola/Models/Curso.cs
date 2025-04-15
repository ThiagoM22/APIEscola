using System.ComponentModel.DataAnnotations;
namespace APIEscola.Models
{
    public class Curso
    {
        public Guid CursoId { get; set; }
        [Required(ErrorMessage = "O Campo Nome é Obrigatório")]
        [MaxLength(8, ErrorMessage = "O Nome deve ter no máximo 8 caracteres")]
        public string? Sigla { get; set; }
        [Required(ErrorMessage = "O Campo Descrição é Obrigatório")]
        [MaxLength(255, ErrorMessage = "A Descrição deve ter no máximo 255 caracteres")]
        public string? Descricao { get; set; }
    }
}
