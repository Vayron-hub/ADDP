using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EjerciciosRazor.Pages
{
    public class CodigoModel : PageModel
    {
        [BindProperty]
        public int n { get; set; } = 0;

        [BindProperty]
        public string mensaje { get; set; } = "";

        public string codif { get; set; } = "";

        public string[] ca { get; set; } = Array.Empty<string>();


        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            var accion = Request.Form["accion"].ToString();

            if (accion == "codificar")
            {
                codif = ProcesarMensaje(mensaje, n, codificar: true);
            }
            else if (accion == "decodificar")
            {
                codif = ProcesarMensaje(mensaje, n, codificar: false);
            }
        }

        private string ProcesarMensaje(string mensaje, int n, bool codificar)
        {
            string[] letras = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            var ca = mensaje.ToUpper().Select(c => c.ToString()).ToArray();
            var temp = new List<string>();

            foreach (var i in ca)
            {
                int index = Array.IndexOf(letras, i);

                if (index == -1)
                {
                    temp.Add(i);
                    continue;
                }

                if (codificar)
                {
                    index = (index + n) % letras.Length;
                }
                else
                {
                    index = (index - n) % letras.Length;
                    if (index < 0) index += letras.Length;
                }

                temp.Add(letras[index]);
            }

            return string.Join("", temp);
        }

    }

}
