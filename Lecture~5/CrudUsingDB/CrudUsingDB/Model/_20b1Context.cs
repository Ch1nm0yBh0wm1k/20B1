using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CrudUsingDB.Model;

public partial class _20b1Context : DbContext
{
    public _20b1Context()
    {
    }

    public _20b1Context(DbContextOptions<_20b1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<MisCourseDetail> MisCourseDetails { get; set; }

    public virtual DbSet<MisStudent> MisStudents { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<VwGetStudentNameAndAge> VwGetStudentNameAndAges { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=20B1;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MisCourseDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mis_CourseDetails");

            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MisStudent>(entity =>
        {
            entity.ToTable("mis_Student");

            entity.Property(e => e.Address)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Age)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.ToTable("Student");

            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwGetStudentNameAndAge>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_GetStudentNameAndAge");

            entity.Property(e => e.Address)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Age)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
