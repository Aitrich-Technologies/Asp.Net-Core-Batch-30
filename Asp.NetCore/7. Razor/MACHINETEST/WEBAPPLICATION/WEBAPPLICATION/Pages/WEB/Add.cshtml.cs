using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WEBAPPLICATION.Models;

namespace WEBAPPLICATION.Pages.WEB
{
    public class AddModel : PageModel
    {
        private readonly ApplicationDbContext _context;
            public AddModel(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public User Userss { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Users.Add(Userss);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }


    }
}
