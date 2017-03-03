using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreHelloWorld2.Models
{
    public class BookImage
    {
        public int BookImageId { get; set; }

        [DataType(DataType.Upload)]
        public byte[] Image { get; set; }

        public string ImageContentType { get; set; }
    }
}
