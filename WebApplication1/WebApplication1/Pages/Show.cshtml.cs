using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages {
    public class Show : PageModel {
        public void OnGet(int id) {
            Id = id;    
        }
        public int Id { get; set; }
    }
}