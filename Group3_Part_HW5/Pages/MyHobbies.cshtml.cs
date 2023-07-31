using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Group3_Part_HW5.Pages
{
    public class MyHobbiesModel : PageModel
    {
        public List<Hobby> MyHobbies { get; set; }
        
        public void OnGet()
        {
            MyHobbies = new List<Hobby>();
            MyHobbies.Add(new Hobby() { Name = "Chess", Description = "Logic game", Type = "Board game" });
            MyHobbies.Add(new Hobby() { Name = "Cicle", Description = "Journey", Type = "Sport game" });
            MyHobbies.Add(new Hobby() { Name = "Ski", Description = "Journey", Type = "Sport game" });
        }
    }
}
