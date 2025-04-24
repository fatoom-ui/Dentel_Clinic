using Microsoft.AspNetCore.Mvc;
using OnlineDentalClinic.Models;
/// Adjust this namespace based on your project structure

public class DoctorController : Controller
{
    public IActionResult Index()
    {
        // You can replace this with data from your database or any other source
        var doctors = new List<Doctor>
        {
            new Doctor
            {
                Name = "Dr. John Doe",
                Specialization = "Orthodontist",
                Description = "Dr. John Doe has over 15 years of experience in orthodontics. He is known for his friendly approach and advanced treatments.",
                ImageUrl = "/images/doctors/dr-john-doe.jpg" // You can use local or online images
            },
            new Doctor
            {
                Name = "Dr. Jane Smith",
                Specialization = "Periodontist",
                Description = "Dr. Jane Smith specializes in gum diseases and periodontics. She is passionate about improving patients' oral health.",
                ImageUrl = "/images/doctors/dr-jane-smith.jpg"
            }
            // Add more doctors as needed
        };

        return View(doctors);
    }
}
