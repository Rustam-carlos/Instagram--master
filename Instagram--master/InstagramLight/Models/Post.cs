﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InstagramLight.Models
{
    public class Post
    {
        public int Id{ get; set; }
        public string PhotoPath { get; set; }
        public string Description { get; set; }
        public int Like { get; set; }
        public string UserId { get; set; }
    }
}