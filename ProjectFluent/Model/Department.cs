namespace ProjectFluent.Model
{
    public class Department
    {
        public Guid DeptId { get; set; }
        public string DeptName { get; set; }

        // Navigation Property

        
        public virtual ICollection<Employee> Employees { get; set; }=new List<Employee>();
        public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    }
}
