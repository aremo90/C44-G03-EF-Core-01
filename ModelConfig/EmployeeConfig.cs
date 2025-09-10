using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ModelConfig
{
    // Fluent Api inside another class
    // must implement IEntityTypeConfiguration<T> interface
    internal class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .UseIdentityColumn(1, 1);
            builder.Property(e => e.Name)
                .HasColumnName("EmpName")
                .HasColumnType("varchar(50)") 
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
