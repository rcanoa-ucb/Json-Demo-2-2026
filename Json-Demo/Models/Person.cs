using System.ComponentModel.DataAnnotations;

namespace Json_Demo.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }    

        [Required]
        public string LastName { get; set; }

        public DateTime Birthday { get; set; }
    }
}
