using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.DAL
{
    public class GroupDbContext : DbContext
    {
        public GroupDbContext (DbContextOptions options)
            : base(options)
        {
        }

        //public DbSet<Group> Groups { get; private set; }
        //public DbSet<Student> Students { get; private set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);

           // ConfigureGroup(model.Entity<Group>());
           // ConfigureStudent(model.Entity<Student>());
        }

       // private void ConfigureGroup(EntityTypeBuilder<Group> group)
        //{
           // group.Property(t => t.Name)
          //     .IsRequired()
          //     .HasMaxLength(100);

         //   group.HasMany(g => g.Students)
         //       .WithOne()
          //      .HasForeignKey(s => s.GroupId);

         ///   group.HasData(
        //        new Group() { Id = 1, Name = "Радиофизика" },
          //      new Group() { Id = 2, Name = "Микроэлектроника" },
          //      new Group() { Id = 3, Name = "Общая физика" }
          //  );
       // }

       // private void ConfigureStudent(EntityTypeBuilder<Student> student)
      //  {
        //    student.Property(t => t.FirstName)
        //        .IsRequired()
       //         .HasMaxLength(100);
       //
       //     student.Property(t => t.LastName)
         //       .IsRequired()
        //        .HasMaxLength(100);

          //  student.Property(t => t.FathersName)
           //     .IsRequired()
          //      .HasMaxLength(100);
        //
         // /  student.HasData(
          //      new Student() { Id = 1, LastName = "Иванов", FirstName = "Иван", FathersName = "Иванович", GroupId = 1 },
         //       new Student() { Id = 2, LastName = "Петров", FirstName = "Петр", FathersName = "Петрович", GroupId = 2 },
        //        new Student() { Id = 3, LastName = "Сидорова", FirstName = "Сидорина", FathersName = "Сидоровна", GroupId = 2 }
       //     );
       // }
    }
}
