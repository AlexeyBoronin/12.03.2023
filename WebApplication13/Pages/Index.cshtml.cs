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
        //    Message = "������� ���� ���";
        //}
        //public void OnPost(string username)
        //{
        //    Message = $"���� ���: {username}";
        //}*/
        /* public string Message { get; private set; } = "";
         public void OnGet()
         {
             Message = "������� ���� ������";
         }
         public void OnPost(string name, int age)
         {
             Message = $"���� ���: {name}. ��� �������: {age}";
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
