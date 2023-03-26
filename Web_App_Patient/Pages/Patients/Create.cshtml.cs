using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_App_Patient.Data;
using Web_App_Patient.Model;

namespace Web_App_Patient.Pages.Patients
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
       
        public Patient Patient { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db= db;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(Patient patient) 
        {
            await _db.Patient.AddAsync(Patient);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");

        }
    }
}
