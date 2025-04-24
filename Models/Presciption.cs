namespace OnlineDentalClinic.Models
{
    public class Presciption
    {
        //public int PresId{ get; set; }
        public string? Patient { get; set; }
        public int Treatment { get; set; }
        public float Tratment_Cost { get; set; }
        public required string Medicines { get; set; }
        public int Quetities { get; set; }
        public int? Id { get;  set; }
    }
}
