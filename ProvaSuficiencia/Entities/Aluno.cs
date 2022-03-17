using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProvaSuficiencia.Entities
{
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Telefone é obrigatório")]
        public string Telefone { get; set; }
    }
}
