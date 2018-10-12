using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz1_mariamCharkviani.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string About { get; set; }
    }
}