
using System.ComponentModel.DataAnnotations;

namespace AcademyF_ATCIT.Week8.Core.Entities
{
    public class User 
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string UserName { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string FirstName { get; set; }

        [StringLength(255)]
        public string LastName { get; set; }

        [Required]
        public bool IsEnabled { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        [Required]
        public bool IsAdministrator { get; set; }
    }
}