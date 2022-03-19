namespace ProjectFluent.Model
{
    public class Project
    {

        public int ProjectId { get; set; }
        public string ProjName { get; set; }
        public string ProgLang { get; set; }
        public string Database { get; set; }

        //Navigation Property
        public virtual ICollection<Employee> Employees { get; set; }=new List<Employee>();
    }
}
