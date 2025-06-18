using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoin
{
    internal class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; } // Foreign key 
   
    }
}
