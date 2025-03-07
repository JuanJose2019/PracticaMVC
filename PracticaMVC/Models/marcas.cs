using System.ComponentModel.DataAnnotations;
namespace PracticaMVC.Models
{
    public class marcas
    {
        [Key]
        [Display(Name ="ID")]
        public int id_marcas { get; set; }
        [Required(ErrorMessage ="El nombre de la marca NO es opcional")]
        [Display(Name ="Nombre de la Marca")]
        public string? nombre_marca { get; set; }
        [Display(Name ="Estado")]
        [StringLength(1,ErrorMessage ="La cantidad maxima de caracteres valida es {1}")]
        public string? estados { get; set; }
    }
}
