using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo {
    public class Book {

        public int Id { get; set; }
        public Author author { get; set; }
        public int Title { get; set; }

    }
}
