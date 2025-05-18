using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_App_ASP_and_React.Models
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publishing_house { get; set; }
        public DateOnly Publishing_date { get; set; }
        public string Image {  get; set; }
    }
}
