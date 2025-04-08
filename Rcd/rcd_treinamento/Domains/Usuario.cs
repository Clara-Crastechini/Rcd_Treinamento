using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rcd_treinamento.Domains
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public Guid UsuarioId { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome eh obrigatorio")]
        public string ? NomeUsuario { get; set; }


        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "Insira seu NickName")]
        public string? NickName { get; set; }


        [Required(ErrorMessage = "A escolha do personagem eh obrigatoria")]
        public Guid PersonagemId { get; set; }
        [ForeignKey("PersonagemId")]
        public Personagem ? Personagem { get; set; }  
    }
}
