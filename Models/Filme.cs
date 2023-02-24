using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaDemoMVC.Models
{
    public class Filme
    {
        //Refazer as anotações do Data Annotation

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo tirulo é obrigatório")]
        [StringLength(60, MinimumLength =3, ErrorMessage = "O título precisa ter entre 3 e 60 caracteres")]
        public string? Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "O campo Data de  é obrigatório")]
        [Display(Name = "Data de lançamento")]
        public DateTime DataLancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Gênero em formato incorreto")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres")]
        [Required(ErrorMessage = "O campo Gênero é obrigatório")]
        public string? Genero { get; set; }

        [Range(1, 1000, ErrorMessage = "Valor de 1 a 1000")]
        [Required(ErrorMessage = "O campo Valor é obrigatório")]
        [Column(TypeName = "decimal(18,2")]
        public int Valor { get; set; }

        [Required(ErrorMessage = "O campo avaliação é obrigatório")]
        [Display(Name = "Avaliação")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente numeros")]
        public int Avaliacao { get; set; }

       
    }
}
