namespace EventRegistrationSystem.Domain
{
    public class Registrations : BaseDomainModel
    {
        public DateTime RegistrationDate { get; set; }
        public int SeatsReserved {get; set;}
        public int UserID {get; set;}
        public int EventID {get; set;} 
    }
}
