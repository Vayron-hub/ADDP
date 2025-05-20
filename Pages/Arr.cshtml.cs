using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EjerciciosRazor.Pages
{
    public class ArrModel : PageModel
    {
        [BindProperty]
        public int[] nums { get; set; } = new int[20];

        public int sum { get; set; } = 0;
        public float prom { get; set; } = 0;
        public int[] mod { get; set; } = Array.Empty<int>();
        public int media { get; set; } = 0;
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (nums == null || nums.Length != 20)
                nums = new int[20];

            Random rnd = new Random();

            for (var i = 0; i < 20; i++)
            {
                int randomInt = rnd.Next(1, 101);
                nums[i] = randomInt;
            }
            Array.Sort(nums);




        }
    }
}
