using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using forum.Data;
using forum.Models;

namespace forum.Pages
{
    public class PostModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public Post? CurrentPost { get; set; }

        [BindProperty]
        public string Reply { get; set; } = "";

        public IActionResult OnGet()
        {
            CurrentPost = ForumData.GetById(Id);
            if (CurrentPost == null) return RedirectToPage("Index");
            return Page();
        }

        public IActionResult OnPost()
        {
            ForumData.AddReply(Id, Reply);
            return RedirectToPage(new { Id = Id });
        }
    }
}