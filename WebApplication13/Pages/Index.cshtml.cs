using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication13.Pages
{
    [IgnoreAntiforgeryToken]
    public class IndexModel : PageModel
    {
        /*//public string Message { get; private set; } = "";
        //public void OnGet()
        //{
        //    Message = "Введите свое имя";
        //}
        //public void OnPost(string username)
        //{
        //    Message = $"Ваше имя: {username}";
        //}*/
        /* public string Message { get; private set; } = "";
         public void OnGet()
         {
             Message = "Введите свои данные";
         }
         public void OnPost(string name, int age)
         {
             Message = $"Ваше имя: {name}. Ваш возраст: {age}";
         }*/
        /*public string[] Human { get; private set; } = Array.Empty<string>();
        public void OnPost(string[] human)
        {
            Human = human;
        }*/
        [BindProperty]
        public string Name { get; set; } = "";
        [BindProperty]
        public int Age { get; set; }
    }
}
