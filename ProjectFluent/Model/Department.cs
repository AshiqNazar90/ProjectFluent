namespace ProjectFluent.Model
{
    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }

        // Navigation Property

        public virtual ICollection<Employee> Employees { get; set; }=new List<Employee>();


    }
}
