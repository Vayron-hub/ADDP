using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EjerciciosRazor.Pages
{
    public class ImcModel : PageModel
    {

        [BindProperty]
        public float peso { get; set; } = 0;

        [BindProperty]
        public float altura { get; set; } = 0;

        public float imc { get; set; } = 0;
        public void OnGet()
        {
        }

        public void OnPost()
        {

            if(peso !=0 && altura != 0)
            {
            imc = (float)peso/(altura * altura);
            }
            else
            {
                imc = 0;
            }
        }
    }
}
