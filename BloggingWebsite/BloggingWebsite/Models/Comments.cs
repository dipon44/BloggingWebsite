using System;
using System.ComponentModel.DataAnnotations;

namespace BloggingWebsite.Models
{
    public class Comments
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The UserName is required")]
        [MaxLength(100, ErrorMessage = "The UserName cannot exceed 200 characters")]
        public string UserName  { get; set; }

        [DataType(DataType.Date)]
        public DateTime CommentDate { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
