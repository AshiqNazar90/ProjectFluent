

using Microsoft.EntityFrameworkCore;
using ProjectFluent.Model;


namespace ProjectFluent.DB
{
    public class ProjectFluentApiDbContext:DbContext
    {

       

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            modelBuilder.Entity<Employee>().HasKey(x => x.EmployeeId)//pk;
            
            // one to many relation
            modelBuilder.Entity<Department>().Has(x => x.Employees).WithOne(x => x.Department)
                   .HasForeignKey(x => x.DeptId);
            //one to one relation
            modelBuilder.Entity<EmployeeAddress>().HasOne(x => x.Team).WithMany(x => x.Employees)
                   .HasForeignKey<Team[]>(x => x.TeamId);
            //many to many relation
            modelBuilder.Entity<Employee>().HasMany(x => x.Projects).WithMany(x => x.Employees).
                   HasForeignKey<Project>(x => x.ProjectId); ;

        }


    }
}
   

