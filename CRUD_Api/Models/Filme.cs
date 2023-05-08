using System.ComponentModel.DataAnnotations;

namespace CRUD_Api.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Titulo { get; set; }
        
        [Required(ErrorMessage = "O campo duração é obrigatório"), Range(1,500, ErrorMessage = "Duração de filme deve ter entre 1 e 500 minutos")]
        public int Duracao { get; set; }

        [StringLength(30, ErrorMessage = "O genêro não pode passar de 30 caracteres")]
        public string Genero { get; set; }
       
    }
}
