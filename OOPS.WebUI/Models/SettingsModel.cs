using OOPS.DTO.Company;
using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Models
{
    public class SettingsModel
    {
        public SystemEducationDTO SystemEducation { get; set; }
        public CompanyDTO Company { get; set; }
        public CompanyBranchDTO CompanyBranch { get; set; }
        public CompanyDepartmentDTO CompanyDepartment { get; set; }
    }
}
