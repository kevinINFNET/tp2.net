using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace WebApplication1.Pages
{
    public class ItemsModel : PageModel
    {
 public List<string> Items { get; set; }

public void OnGet()
        {
            Items = new List<string> { "Item 1", "Item 2", "Item 3" };
        }
    }
}
