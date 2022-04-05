using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Domain.ViewModel.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Application.Services
{
    public class PostService : IPostService
    {
        public PostViewModel? Create(PostViewModel? post)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PostViewModel>? GetAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public PostViewModel? GetById(int userId, int postId)
        {
            throw new NotImplementedException();
        }

        public PostViewModel? Remove(Post? post)
        {
            throw new NotImplementedException();
        }

        public PostViewModel? Update(PostViewModel? post)
        {
            throw new NotImplementedException();
        }
    }
}
