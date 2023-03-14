using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmailSchedulerAPI.Models
{
    public class Email
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "ID will be automatically generated")]
        public int EmailId { get; set; }

        [Column(TypeName = "varchar(1000)")]
        [Required(ErrorMessage = "The url cannot be empty.")]
        public string EMAIL { get; set; }

        // Foreign key 
        public int JobId { get; set; }

        [ForeignKey("JobId")]
        public Job job { get; set; }


    }
}
