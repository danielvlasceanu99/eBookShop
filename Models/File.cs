using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBookShop.Models
{
    public class File
    {
        public int ID { get; set; }
        public string FileName { get; set; }
        public string Type { get; set; }

        // Book relationship - one to many
        public int BookID { get; set; }
        public Book Book { get; set; }


    }
}
