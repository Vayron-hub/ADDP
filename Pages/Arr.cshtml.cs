using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EjerciciosRazor.Pages
{
    public class ArrModel : PageModel
    {
        [BindProperty]
        public int[] nums { get; set; } = new int[20];
        [BindProperty]
        public int sum { get; set; } = 0;
        [BindProperty]
        public float prom { get; set; } = 0;
        [BindProperty]
        public int[] mod { get; set; } = Array.Empty<int>();
        [BindProperty]
        public float media { get; set; } = 0;

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

            foreach(var i in nums)
            {
                sum += i;
            }

            prom = sum / nums.Length;

            
            media = (nums[9] + nums[10]) / 2.0f;

            var freq = new Dictionary<int, int>();
            foreach (var n in nums)
            {
                if (freq.ContainsKey(n))
                    freq[n]++;
                else
                    freq[n] = 1;
            }
            int maxFreq = freq.Values.Max();
            mod = freq.Where(x => x.Value == maxFreq).Select(x => x.Key).ToArray();

        }
    }
}
