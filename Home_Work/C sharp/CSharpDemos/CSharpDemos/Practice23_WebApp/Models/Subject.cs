using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo23_WebApp.Models
{

    [Table("Subjects")]
    public class Subject
    {
        [Display(Name = "Subject ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short SubjectId { get; set; }

        [Display(Name = "Name of the Subject")]
        [Required]
        [StringLength(50)]
        [MinLength(3)]
        public string SubjectName { get; set; }


        #region Navigation Properties to the Department Model 

        [Display(Name = "Department Name")]
        [Required]
        [ForeignKey(nameof(Subject.Department))]      // foreign key to the object in the current model.
        public int DepartmentId { get; set; }           // department Id of the Subject

        [Display(Name = "Department Name")]
        public Department Department { get; set; }

        #endregion
    }
}
