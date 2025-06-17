using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_App_ASP_and_React.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        //public string Publishing_house { get; set; }
        //public DateOnly Publishing_date { get; set; }

        public string Image_path {  get; set; }
        public string File_pdf_path { get; set; }
        public string Audio_path { get; set; }
        public int Page_count { get; set; }
        public float Average_rating { get; set; }
        public int Number_review { get; set; }
        public ICollection<UserRelationBook> UserBooks { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
