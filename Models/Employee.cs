using System.ComponentModel.DataAnnotations;


namespace NetCoreApplicationRepository.Data.Services
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage ="Name can only be 20 characters long.")]
        public string Name { get; set; }
    }
}
