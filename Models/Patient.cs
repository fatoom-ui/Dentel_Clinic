using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace OnlineDentalClinic.Models
{
    public class Patient
    {


        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientId { get; set; } // Should be an int

        [Required]
        [StringLength(100)]
        public string PatientName { get; set; }

        [Required]
        [StringLength(15)]
        public string PatientPhone { get; set; }

        [Required]
        [StringLength(200)]
        public string PatientAddress { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime PatientD_O_B { get; set; }

        [Required]
        [StringLength(10)]
        public string PatientGender { get; set; }

        [StringLength(500)]
        public string PatientAllergies { get; set; }


        //public required string PatientName { get; set; }
        ////public int PatId { get; set; }
        //public int PatientPhone{get; set;}
        //public required string  PatientAddress { get; set; }
        //public DateTime PatientD_O_B { get; set; }
        //public required  string PatientGender { get; set; }
        //public string? PatientAllergies { get; set; }
        //public int? PatientId { get; internal set; }
    }
}
