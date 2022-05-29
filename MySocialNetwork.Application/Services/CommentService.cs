using AutoMapper;
using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Domain.ViewModel.Comment;

namespace MySocialNetwork.Application.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;

        public CommentService(ICommentRepository commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }

        public void Create(CommentViewModel? entity)
        {
            _commentRepository.Save(_mapper.Map<Comment>(entity));
        }

        public List<CommentViewModel> GetAll(int userId, int postId)
        {
            throw new NotImplementedException();
        }

        public List<CommentViewModel>? GetAll()
        {
            throw new NotImplementedException();
        }

        public CommentViewModel? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(CommentViewModel? entity)
        {
            throw new NotImplementedException();
        }

        public void Update(CommentViewModel? entity)
        {
            throw new NotImplementedException();
        }
    }
}
