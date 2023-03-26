using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_App_Patient.Data;
using Web_App_Patient.Model;

namespace Web_App_Patient.Pages.Patients
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IEnumerable<Patient> Patients { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db= db;
        }
        public void OnGet()
        {
            Patients = _db.Patient;
        }
    }
}
