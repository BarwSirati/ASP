namespace Backend.Models
{
    [Index(nameof(Username), IsUnique = true)]

    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(maximumLength: 100)]
        public String Name { get; set; }
        [Required(ErrorMessage = "Lastname is required.")]
        [StringLength(maximumLength: 100)]
        public String Lastname { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [StringLength(maximumLength: 100)]
        public String Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(maximumLength: 100, MinimumLength = 10)]
        public String Password { get; set; }
    }
}
