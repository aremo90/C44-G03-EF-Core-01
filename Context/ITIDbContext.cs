using ConsoleApp1.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Context
{
    internal class ITIDbContext : DbContext
    {
        public ITIDbContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = ITI; Trusted_Connection = true; TrustServerCertificate = true");
        }
        public DbSet<Model.Instructor> Instructors { get; set; }
        public DbSet<Model.Department> Departments { get; set; }
        public DbSet<Model.Course_Inst> Course_Insts { get; set; }
        //public DbSet<Model.Stud_Course> Stud_Courses { get; set; }
        public DbSet<Model.Student> Students { get; set; }
        public DbSet<Model.Course> Courses { get; set; }
        public DbSet<Model.Topic> Topics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /* ====== Student ====== */
            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");
                entity.HasKey(e => e.ID);

                entity.Property(s => s.ID).ValueGeneratedNever();
                entity.Property(e => e.FName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.LName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Address).HasMaxLength(250);
                entity.Property(e => e.Dep_Id).HasColumnName("Dep_Id").IsRequired();

                entity.HasOne(e => e.Department)
                      .WithMany(d => d.Students)
                      .HasForeignKey(e => e.Dep_Id)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            /* ====== Department ====== */
            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");
                entity.HasKey(e => e.ID);

                entity.Property(e => e.Name).HasMaxLength(150).IsRequired();
                entity.Property(e => e.Ins_ID).HasColumnName("Ins_ID");
                entity.Property(e => e.HiringDate).HasColumnType("datetime");

                entity.HasOne(d => d.Head)
                      .WithMany(i => i.ManagedDepartments)
                      .HasForeignKey(d => d.Ins_ID)
                      .OnDelete(DeleteBehavior.SetNull);
            });

            /* ====== Instructor ====== */
            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.ToTable("Instructor");
                entity.HasKey(e => e.ID);

                entity.Property(e => e.Name).HasMaxLength(150).IsRequired();
                entity.Property(e => e.Salary).HasColumnType("decimal(18,2)");
                entity.Property(e => e.Address).HasMaxLength(250);
                entity.Property(e => e.Bonus).HasColumnType("decimal(18,2)");
                entity.Property(e => e.HourRate).HasColumnType("decimal(18,2)");
                entity.Property(e => e.Dept_Id).HasColumnName("Dept_ID").IsRequired();

                entity.HasOne(i => i.Department)
                      .WithMany(d => d.Instructors)
                      .HasForeignKey(i => i.Dept_Id)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            /* ====== Topic ====== */
            modelBuilder.Entity<Topic>(entity =>
            {
                entity.ToTable("Topic");
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).HasMaxLength(150).IsRequired();
            });

            /* ====== Course ====== */
            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");
                entity.HasKey(c => c.ID);

                entity.Property(c => c.Name).HasMaxLength(150).IsRequired();
                entity.Property(c => c.Description).HasMaxLength(1000);
                entity.Property(c => c.Top_Id).HasColumnName("Top_ID").IsRequired();

                entity.HasOne(c => c.Topic)
                      .WithMany(t => t.Courses)
                      .HasForeignKey(c => c.Top_Id)
                      .OnDelete(DeleteBehavior.Restrict);
            });


            /* ====== Course_Inst ====== */
            modelBuilder.Entity<Course_Inst>(entity =>
            {
                entity.ToTable("Course_Inst");

                entity.HasKey(ci => new { ci.inst_Id, ci.Course_Id });

                entity.Property(ci => ci.inst_Id).HasColumnName("inst_ID");
                entity.Property(ci => ci.Course_Id).HasColumnName("Course_ID");
                entity.Property(ci => ci.evaluate).HasMaxLength(250);

                entity.HasOne(ci => ci.Instructor)
                      .WithMany(i => i.Course_Insts)
                      .HasForeignKey(ci => ci.inst_Id)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(ci => ci.Course)
                      .WithMany(c => c.Course_Insts)
                      .HasForeignKey(ci => ci.Course_Id)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            #region M2M Student-Course 

            modelBuilder.Entity<Student>()
                        .HasMany(c => c.Courses)
                        .WithMany(s => s.Students)
                        .UsingEntity<Stud_Course>()
                        .HasKey(SC => new { SC.StudentId, SC.CourseId });


            #endregion
        }
    }
}
