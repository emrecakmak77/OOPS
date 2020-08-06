using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class Education : Entity<int>
    {
        public Education()
        {
            Employees = new HashSet<Employee>();
          
        }
       //TODO: SystemEducation tablosu bağlanacak. NAme alanına gerek yok
        public string Name { get; set; }

        [ForeignKey("EducationsType")]
        public int EducationsTypeID { get; set; }
        public virtual EducationsType EducationsType { get; set; }

        public DateTime DateCompleted { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

    }
}
