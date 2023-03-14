using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmailSchedulerAPI.Models
{
    public class Job
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "ID will be automatically generated")]
        public int JobId { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "The train name cannot be empty.")]
        public string JobName { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "The email cannot be empty.")]
        public string PdfName { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "The addressname cannot be empty.")]
        public string FromEmail { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "The addressname cannot be empty.")]
        public string EmailSubject { get; set; }

        [Column(TypeName = "varchar(500)")]
        [Required(ErrorMessage = "The addressname cannot be empty.")]
        public string EmailBody { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage = "The addressname cannot be empty.")]
        public string ScheduleType { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "MM/DD/YYYY Format")]
        public DateTime DepartureDate { get; set; }

        public Boolean IsActive { get; set; }

    }
}
