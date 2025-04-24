using System.ComponentModel.DataAnnotations;

namespace OnlineDentalClinic.Models
{
    public class Appointment
    {
        public int AppId { get; set; }
        //public int Id { get; set; } // Primary Key
        //public int? Id { get; set; }

        public int? Id { get; set; } // Primary Key
        
        public required string Patient { get; set; }
        public int? Treatment { get; set; }
        public DateTime AppDate { get; set; }
        public TimeOnly AppTime { get; set; }
        

    }
}
