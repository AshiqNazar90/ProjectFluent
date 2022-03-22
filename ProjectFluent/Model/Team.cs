namespace ProjectFluent.Model
{
    public class Team
    {
        public Guid TeamId { get; set; }
        public string TeamName { get; set; }
        public int size { get; set; }

        //Navigation property

        
        public virtual ICollection<Employee> Employees { get; set; }= new List<Employee>();

    }
}
