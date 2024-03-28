using Bar_Bite.Data;
using Bar_Bite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bar_Bite.Pages
{
    public class IndexModel : PageModel
    {
        DataDbContext db;
        public List<Student> Students { get; set; }
        public Student Student { get; set; }
        public IndexModel(DataDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            Students=db.Students.ToList();
        }
       
    }
}
