using ProvaSuficiencia.Entities;
using System.ComponentModel.DataAnnotations;

namespace ProvaSuficiencia.Dtos
{
    public class AlunoInputDto
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Telefone é obrigatório")]
        public string Telefone { get; set; }

        public Aluno AsAluno()
        {
            return new Aluno
            {
                Nome = Nome,
                Telefone = Telefone,
            };
        }
    }
}
