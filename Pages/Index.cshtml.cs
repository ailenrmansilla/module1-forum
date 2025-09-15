// This logic handles all the posts in Index page.
// The PageModel contains properties and methods used in Index.cshtml
using Microsoft.AspNetCore.Mvc.RazorPages;
using forum.Data;
using forum.Models;
using System.Collections.Generic;

namespace forum.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Post> Posts { get; set; } = new List<Post>();

        public void OnGet()
        {
            Posts = ForumData.GetAll();
        }
    }
}
