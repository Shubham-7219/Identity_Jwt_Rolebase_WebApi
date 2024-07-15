using System.ComponentModel.DataAnnotations;

namespace Identity_Jwt_Rolebase_WebApi.Model
{
    public class Register
    {
        public string? Username {  get; set; }
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string? confirmPassword {  get; set; }
    }
}
