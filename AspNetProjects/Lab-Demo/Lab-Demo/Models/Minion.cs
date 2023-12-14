
namespace Lab_Demo.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Minion
    {
        public int ID { get; set; }
        [Required]  
        public string  Name { get; set; }
        public string EyeCount { get; set; }

    }
}
