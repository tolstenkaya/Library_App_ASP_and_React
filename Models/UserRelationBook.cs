using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_App_ASP_and_React.Models
{
    [Table("UserRelationBook")]
    public class UserRelationBook
    {
        [Key]
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public bool IsSavedBook { get; set; }
        public bool IsFavouriteBook { get; set; }
        public bool HasReviewBook { get; set; }
        public int UserRating { get; set; }
    }
}
