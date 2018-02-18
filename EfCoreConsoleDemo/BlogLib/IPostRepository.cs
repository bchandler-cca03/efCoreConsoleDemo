using System;
using System.Collections.Generic;
using System.Text;

namespace BlogLib
{
    public interface IPostRepository
    {
        List<Post> ListAll();

        Post GetById(int id);

        void AddPost(Post newPost);

        void UpdatePost(Post updatePost);

        void DeletePost(int id);
    }
}
