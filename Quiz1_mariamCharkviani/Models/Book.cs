using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz1_mariamCharkviani.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int MyProperty { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public DateTime DatePublished { get; set; }
        public int NumberOfPages { get; set; }
        public string Summary { get; set; }
    }
}