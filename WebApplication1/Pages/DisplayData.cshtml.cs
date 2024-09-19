using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.IO;

namespace WebApplication1.Pages
{
public class DisplayDataModel : PageModel
    {
   public List<string> Lines { get; set; } = new List<string>();
   public void OnGet()
  {
   var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", "formdata.txt");
    if (System.IO.File.Exists(filePath))
  {
    Lines = new List<string>(System.IO.File.ReadAllLines(filePath));
     }
   }
 }
}
