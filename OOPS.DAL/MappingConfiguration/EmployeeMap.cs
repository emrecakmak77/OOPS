using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DAL.MappingConfiguration
{
   public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure (EntityTypeBuilder<Employee> builder)
        {
            builder.Property(z => z.Name).IsRequired();
            builder.Property(z => z.Surname).IsRequired();
           
       

        }
    }
}
