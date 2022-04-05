using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
