using System.ComponentModel.DataAnnotations;

namespace Identity_Jwt_Rolebase_WebApi.Model
{
    public class UserRole
    {
        [Required]
        public string? Username {  get; set; }
        [Required]
        public string? Role{get;set;}
    }
}
