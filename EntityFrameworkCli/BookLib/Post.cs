﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookLib
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public  string Content { get; set; }
        public int BlodId { get; set; }
        public Blog Blog { get; set; }
    }
}
