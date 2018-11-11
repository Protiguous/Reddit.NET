﻿using System.Collections.Generic;

namespace Reddit.NET.Controllers.EventArgs
{
    public class PostsUpdateEventArgs
    {
        public List<Post> OldPosts { get; set; }
        public List<Post> NewPosts { get; set; }
    }
}
