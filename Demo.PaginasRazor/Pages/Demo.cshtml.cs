using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Demo.PaginasRazor.Pages
{
    public class DemoModel : PageModel
    {
        public string Saludo { get; set; } = default!;
        public List<string> Colores { get; set; } = default!;

        [BindProperty]
        [DisplayName("Dime tu nombre")]
        [MinLength(3, ErrorMessage ="El campo tiene que tener {1} caracteres como mínimo.")]
        public string Nombre { get; set; } = default!;

        public DemoModel()
        {
            InicializarColores();
        }

        public void OnGet()
        {
            Saludo = "Hola mundo!";
        }

        public IActionResult OnPost()
        {
            Saludo = $"Hola {Nombre}";

            return Page();
        }

        private void InicializarColores()
        {
            Colores = new List<string> { "Azul", "Verde", "Rojo" };
        }
    }
}
