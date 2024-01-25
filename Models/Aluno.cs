using System.ComponentModel.DataAnnotations;

namespace WebIdentityApp.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [Required, MaxLength(80, ErrorMessage = "Nome não pode exceder o limite de 80 caracteres")]
        public string? Nome { get; set; }

        [EmailAddress]
        [Required, MaxLength(120)]
        public string? Email { get; set; }

        public int Idade { get; set; }

        [MaxLength(80)]
        public string? Curso { get; set; }
    }
}
