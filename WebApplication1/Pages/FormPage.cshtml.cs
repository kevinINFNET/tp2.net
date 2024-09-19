using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace WebApplication1.Pages
{
    public class FormPageModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "O nome � obrigat�rio.")]
        public string Name { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "O e-mail � obrigat�rio.")]
        [EmailAddress(ErrorMessage = "O e-mail deve ser um endere�o de e-mail v�lido.")]
        public string Email { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
           SaveFormData(Name, Email);
           return RedirectToPage("/DisplayData");
            }
            return Page();
        }

        private void SaveFormData(string name, string email)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", "formdata.txt");
            var formData = $"Name: {name}, Email: {email}";
            System.IO.File.AppendAllText(filePath, formData + "\n");
        }
    }
}
