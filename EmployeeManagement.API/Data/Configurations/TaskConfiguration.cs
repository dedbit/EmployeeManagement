using EmployeeManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagement.API.Data.Configurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(t => t.Description)
                .HasMaxLength(500);

            builder.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(20)
                .HasDefaultValue("To do")
                .HasConversion(
                    v => v.ToString(),
                    v => (TaskStatus)Enum.Parse(typeof(TaskStatus), v))
                .HasCheckConstraint("CK_Task_Status", "[Status] IN ('To do', 'In Progress', 'Done', 'Removed')");

            builder.HasOne(t => t.Employee)
                .WithMany(e => e.Tasks)
                .HasForeignKey(t => t.AssignedTo)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
