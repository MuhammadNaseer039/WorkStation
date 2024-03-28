using Bar_Bite.Data;
using Bar_Bite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bar_Bite.Pages
{
    public class CreateStudentModel : PageModel
    {
        public DataDbContext db;

        public Student Students { get; set; }

        public CreateStudentModel(DataDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost(Student newstd)
        {
            //Student student = new();
            //student.Name = newstd.Name;
            //student.Description = newstd.Description;

            db.Students.Add(newstd);
            db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
