using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Financial_Reader_Backend.DTOs
{
    public class UserDTO
    {
        public UserDTO(int id, string login, string key, string email, string nick)
        {
            this.id = id;
            this.login = login;
            this.key = key;
            this.email = email;
            this.nick = nick;
        }
        public int id { get; set; }
        public string login { get; set; } = string.Empty;
        public string key { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string nick { get; set; } = string.Empty;
    }
}