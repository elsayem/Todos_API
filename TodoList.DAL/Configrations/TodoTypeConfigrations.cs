using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.DAL.Data.Models;

namespace TodoList.DAL.Configrations
{
    public partial class TodoTypeConfigrations : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            //Pk
            builder.HasKey(t => t.Id);

            //Index
            builder.HasIndex(x => x.Name).IsUnique(); //to make Only Unique Names

            //Constraints
            builder.Property(t =>t.Name).HasMaxLength(50).IsRequired();
            builder.Property(t =>t.Description).HasMaxLength(100);
            
            //Create default value for the deadline
            builder.Property(t => t.DeadLine).HasDefaultValueSql("DATEADD(hour, 2, GETDATE())");

        }
    }
}
