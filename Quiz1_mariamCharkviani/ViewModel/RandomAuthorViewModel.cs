﻿using Quiz1_mariamCharkviani.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz1_mariamCharkviani.ViewModel
{
    public class RandomAuthorViewModel
    {
        public Author Author { get; set; }
        public List<Book> Books { get; set; }
    }
}