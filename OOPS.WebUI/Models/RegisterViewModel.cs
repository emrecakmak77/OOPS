using OOPS.DTO.Company;
using OOPS.DTO.Employee;

namespace OOPS.WebUI.Models
{
    public class RegisterViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneBusiness { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public CompanyDTO Company { get; set; }
        public EmployeeDTO Employee { get; set; }
    }
}
