// This PageModel class handles post submissions and redirects to Index
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using forum.Data;

namespace forum.Pages
{
    public class NewPostModel : PageModel
    {
        [BindProperty] public string Title { get; set; } = "";
        [BindProperty] public string Content { get; set; } = "";
        [BindProperty] public string Author { get; set; } = "";

        public IActionResult OnPost()
        {
            ForumData.AddPost(Title, Content, Author);
            return RedirectToPage("Index");
        }
    }
}