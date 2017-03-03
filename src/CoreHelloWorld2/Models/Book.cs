using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreHelloWorld2.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Required]
        [MaxLength(255)]
        [MinLength(1)]
        public string Name { get; set; }

        [Required]
        [MaxLength(16)]
        [MinLength(16)]
        public string Isbn { get; set; }

        public BookImage CoverImage { get; set; }

        [ForeignKey("FK_BookId_BookImageId")]
        public int BookImageId {get;set;}
    }
}
