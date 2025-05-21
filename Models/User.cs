using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Financial_Reader_Backend.Models
{
    public class User
    {
        public int id { get; set; }
        public string login { get; set; } = string.Empty;
        public string key { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string nick { get; set; } = string.Empty;
    }
}