namespace ProjectFluent.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmpName { get; set; }
        public float Salary { get; set; }
        public string Email { get; set; }
        public string PrimaryContact { get; set; }
        public string SecondaryContact { get; set; }

        //Navigation property

        public virtual Department Department { get; set; }
        public virtual EmployeeAddress EmployeeAddress { get; set; }

        public virtual Team Team { get; set; }
        
        public virtual ICollection<Project> Projects { get; set; }=new List<Project>();

    }
}
