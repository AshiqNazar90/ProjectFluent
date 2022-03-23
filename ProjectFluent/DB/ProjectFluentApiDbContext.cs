

using Microsoft.EntityFrameworkCore;
using ProjectFluent.Model;


namespace ProjectFluent.DB
{
    public class ProjectFluentApiDbContext:DbContext
    {
        public ProjectFluentApiDbContext(DbContextOptions<ProjectFluentApiDbContext> options):base(options)
        {

        }
       
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Project> Projects { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=ProjectFluentDb;Trusted_Connection=True;");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Employee>().HasKey(x => x.EmployeeId);//pk
       


            //one to one relation

            var EmpAd = modelBuilder.Entity<EmployeeAddress>();
                EmpAd.HasKey(x => x.EmplId);//PK
                EmpAd.HasOne(x => x.Employee)
                     .WithOne(x => x.Address)
                      .HasForeignKey<Employee>(x=>x.EmpId);//fk

            //// many to one relation
            var dept = modelBuilder.Entity<Department>();
            dept.HasKey(x => x.DeptId);//pk

              dept.HasMany(x => x.Employees)
                     .WithOne(x => x.Department)
                       .HasForeignKey(x => x.DtId);


            //one to many relation

            var team = modelBuilder.Entity<Team>();
            team.HasKey(x => x.TeamId); //pk
            team.HasMany(x => x.Employees)
                   .WithOne(x => x.Team)
                   .HasForeignKey(x => x.TmId);


            //many to many relation
            var pct = modelBuilder.Entity<Project>();
            pct.HasKey(x => x.ProjectId);
            pct.HasOne(x => x.Employee)
               .WithMany(x => x.Projects)
               .HasForeignKey(x => x.EmplyId);
            var pct1 = modelBuilder.Entity<Project>();
            pct1.HasOne(x => x.Department)
               .WithMany(x => x.Projects)
               .HasForeignKey(x => x.DepartId);


        }


    }
}
   

