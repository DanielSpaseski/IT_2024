using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Libraries_Modified.Models
{
    public class AuthorBook
    {
        public int authorId { get; set; }
        public int bookId { get; set; }
        public List<Book> books { get; set;}
    }
}