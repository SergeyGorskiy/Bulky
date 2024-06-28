using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
    public class Configuration
    {
        public string? ConnectionString { get; set; }
        public string? Token { get; set; }
        public string? Port { get; set; }

    }
}
