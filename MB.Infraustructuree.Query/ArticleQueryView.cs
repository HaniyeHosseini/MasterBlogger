﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace MB.Infrastructure.Query
{
    public class ArticleQueryView
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string ShortDiscription { get; set; }
        public string ArticleCategory { get; set; }
        public string CreationDate { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }

 
    }
}
