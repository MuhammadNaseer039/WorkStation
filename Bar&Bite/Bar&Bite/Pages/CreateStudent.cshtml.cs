using Bar_Bite.Data;
using Bar_Bite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bar_Bite.Pages
{
    public class CreateStudentModel : PageModel
    {
        private readonly DataDbContext db;
        public Student student {  get; set; }
        public CreateStudentModel(DataDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
