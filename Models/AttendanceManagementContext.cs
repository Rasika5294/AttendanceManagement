using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Attendance_Management_System.Models
{
    public partial class AttendanceManagementContext : DbContext
    {
        public AttendanceManagementContext()
        {
        }

        public AttendanceManagementContext(DbContextOptions<AttendanceManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Leave> Leaves { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Practice> Practices { get; set; }
        public virtual DbSet<PublicHoliday> PublicHolidays { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database= AttendanceManagement;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("Attendance");

                entity.Property(e => e.EmpId)
                    .ValueGeneratedNever()
                    .HasColumnName("emp_id");

                entity.Property(e => e.Dates)
                    .HasColumnType("date")
                    .HasColumnName("dates");

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasColumnName("in_time");

                entity.Property(e => e.OutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("out_time");

                entity.Property(e => e.TotalInTime)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("total_in_time");

                entity.HasOne(d => d.Emp)
                    .WithOne(p => p.Attendance)
                    .HasForeignKey<Attendance>(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Attendanc__emp_i__282DF8C2");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__Employee__1299A86193D3CF99");

                entity.ToTable("Employee");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("department");

                entity.Property(e => e.EmpEmail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("emp_email");

                entity.Property(e => e.EmpName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");

                entity.Property(e => e.EmpPassword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_password");

                entity.Property(e => e.EmpPhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_phone");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("job_title");

                entity.Property(e => e.LeavesTaken).HasColumnName("leaves_taken");

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.Property(e => e.TotalLeaves).HasColumnName("total_leaves");
            });

            modelBuilder.Entity<Leave>(entity =>
            {
                entity.ToTable("Leave");

                entity.Property(e => e.LeaveId).HasColumnName("leave_id");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.FromDate)
                    .HasColumnType("date")
                    .HasColumnName("from_date");

                entity.Property(e => e.ReasonForLeave)
                    .IsRequired()
                    .HasMaxLength(750)
                    .IsUnicode(false)
                    .HasColumnName("reason_for_leave");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TimeIfAny)
                    .HasColumnType("datetime")
                    .HasColumnName("time_if_any");

                entity.Property(e => e.ToDate)
                    .HasColumnType("date")
                    .HasColumnName("to_date");

                entity.Property(e => e.TypeOfLeave)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("type_of_leave");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.Leaves)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK__Leave__emp_id__4F47C5E3");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.ToTable("Manager");

                entity.Property(e => e.ManagerId).HasColumnName("manager_id");

                entity.Property(e => e.ManagerEmail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("manager_email");

                entity.Property(e => e.ManagerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("manager_name");

                entity.Property(e => e.ManagerPassword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("manager_password");

                entity.Property(e => e.ManagerPhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("manager_phone");
            });

            modelBuilder.Entity<Practice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Practice");

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.Fname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FName");
            });

            modelBuilder.Entity<PublicHoliday>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Day)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("day");

                entity.Property(e => e.Details)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("details");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
