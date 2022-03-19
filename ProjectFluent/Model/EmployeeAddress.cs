namespace ProjectFluent.Model
{
    public class EmployeeAddress
    {
        public int EmployeeId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }

        //Navigation Property

        public virtual Employee Employee { get; set; }

    }
}
