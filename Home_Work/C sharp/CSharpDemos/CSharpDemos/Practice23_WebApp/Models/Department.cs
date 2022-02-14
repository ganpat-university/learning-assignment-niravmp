using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo23_WebApp.Models
{
    [Table("Departments")]
    public class Department
    {
        [Display(Name = "Department ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentId { get; set; }

        [Display(Name = "Department Name")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters")]
        [MinLength(3, ErrorMessage = "{0} should have at least {1} characters.")]
        public string DepartmentName { get; set; }


        #region Navigation Properties to the Subject Model

        // Subjects of the Current Department Object.
        // Can be Null (current department might not have any subjects).
        public ICollection<Subject> Subjects { get; set; }

        #endregion

    }

    /******************************
            CREATE TABLE [Departments]
            (
                [DepartmentId] int NOT NULL IDENTITY(1, 1)
               , [DepartmentName] varchar(50) NOT NULL

               , CONSTRAINT [PK_Departments] 
                         PRIMARY KEY ( [DepartmentId] ASC )
            )
     **************/
}
