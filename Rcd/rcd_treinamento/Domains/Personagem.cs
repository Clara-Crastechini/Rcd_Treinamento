using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rcd_treinamento.Domains
{
    [Table("Personagem")]
    public class Personagem
    {
        [Key]
        public Guid PersonagemId { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome eh obrigatorio")]
        public string ? NomePersonagem {  get; set; }


        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "Insira a Habilidade")]
        public string ? Habilidade { get; set; }




    }
}
