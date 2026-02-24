using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WEBAPPLICATION.Models;

namespace WEBAPPLICATION.Pages.BOOK
{
    public class AddModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public AddModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Book Bookk { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Books.Add(Bookk);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }

    }
}
