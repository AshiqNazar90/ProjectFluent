namespace ProjectFluent.Model
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string EmpName { get; set; }
        public float Salary { get; set; }
        public string Email { get; set; }
        public string PrimaryContact { get; set; }
        public string SecondaryContact { get; set; }

        //Navigation property


        public Guid? EmpId { get; set; }
        public virtual EmployeeAddress Address { get; set; }

        public Guid? DtId { get; set; }
        public virtual Department Department { get; set; }

        public Guid? TmId { get; set; }
        public virtual Team Team { get; set; }

        public virtual ICollection<Project> Projects { get; set; }=new List<Project>();

    }
}
