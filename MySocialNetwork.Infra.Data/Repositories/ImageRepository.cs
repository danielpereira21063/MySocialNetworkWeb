﻿using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Interfaces;

namespace MySocialNetwork.Infra.Data.Repositories
{
    public class ImageRepository : IImageRepository
    {
        public IEnumerable<Image>? GetAllByPostId(int postId)
        {
            throw new NotImplementedException();
        }
    }
}
