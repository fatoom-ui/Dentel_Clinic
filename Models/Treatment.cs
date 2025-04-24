namespace OnlineDentalClinic.Models
{
    public class Treatment
    {
        //public int TreatId { get; set; }
        public required string Treatment_Name { get; set; }
        public float Treatment_Cost { get; set; }
        public string? Treatment_Description { get; set; }
        public int? Id { get;  set; }
    }
}
