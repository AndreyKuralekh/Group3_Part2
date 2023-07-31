using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Group3_Part_HW5.Pages
{
    public class AboutMeModel : PageModel
    {
        [BindProperty]
        public string UserName { get; set; }
        public void OnGet()
        {
            UserName = "Andrew A.Kuralekh";
        }
    }
}
