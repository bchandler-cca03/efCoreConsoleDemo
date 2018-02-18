using System;
using System.Collections.Generic;
using System.Text;

namespace BlogLib
{

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        // YUCK -- this shouldn't be here, @36:50 in Ammons Entity Framerwork Video
        //  but it makes Entity Framerwork do for us and to us.
        // the posts live inside of a blog-object
        //  Navigation Properties are to Instruct Entity Framework
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }


}
