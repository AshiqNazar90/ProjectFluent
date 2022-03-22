namespace ProjectFluent.Model
{
    public class Project
    {

        public Guid ProjectId { get; set; }
        public string ProjName { get; set; }
        public string ProgLang { get; set; }
        public string Database { get; set; }

        //Navigation Property

        public Guid? EmplyId { get; set; }
        public virtual Employee Employee { get; set; }

        public  Guid? DepartId{ get; set; }

        public virtual Department Department { get; set; }
    }
}
