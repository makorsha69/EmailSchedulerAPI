using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmailSchedulerAPI.Models
{
    public class Url
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "ID will be automatically generated")]
        public int UrlId { get; set; }

        [Column(TypeName = "varchar(1000)")]
        [Required(ErrorMessage = "The url cannot be empty.")]
        public string URL { get; set; }

        [ForeignKey("Job")]
        public int JobId { get; set; }


    }
}
