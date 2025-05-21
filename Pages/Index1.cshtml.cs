using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EjerciciosRazor.Pages
{
    public class Index1Model : PageModel
    {
        [BindProperty]
        public double a { get; set; } = 0;

        [BindProperty]
        public double b { get; set; } = 0;

        [BindProperty]
        public double x { get; set; } = 0;

        [BindProperty]
        public double y { get; set; } = 0;

        [BindProperty]
        public int n { get; set; } = 0;

        public double Res { get; set; } = 0;
        public List<string> P { get; set; } = new();

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Res = 0;

            for(int i = 0; i<=n; i++)
            {
                double m = Fac(n) / (Fac(i) * Fac(n - i));
                double ax = Math.Pow(a * x, n - i);
                double by = Math.Pow(b * y, i);
                double t= m * ax * by;
                Res += t;

                P.Add($" {i + 1}: C({n}, {i}) * (a*x)^{n-i} * (b*y)^{i} = {m} * {ax} * {by} = {t}");
            }
        }

        public double Fac(int num)
        {
            double r = 1;
            for(int i=1; i<= num; i++)
            {
                r *= i;
            }
            return r;
        }
     }
}
