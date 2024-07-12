using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class LoginUser
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter username")]
        public string? Username { get; set; }

		[Required(ErrorMessage = "Password required")]
		public string? Password { get; set; }

		public LoginUser()
		{
		}

		public LoginUser(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
