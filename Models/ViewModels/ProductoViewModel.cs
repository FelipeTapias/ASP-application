using System.ComponentModel.DataAnnotations;

namespace IntroASP.Models.ViewModels
{
	public class ProductoViewModel
	{
        [Required]
        [Display(Name = "Descripción")]
		public string Descripcion { get; set; }

        [Required]
        [Display(Name = "Color")]
        public string Color { get; set; }

        [Required]
        [Display(Name = "Precio")]
        public int Precio { get; set; }
    }
}
