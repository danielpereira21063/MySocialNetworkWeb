﻿using MySocialNetwork.Domain.Entities.UserEntities;
using MySocialNetwork.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities.PostEntities
{
    public sealed class Post : AbstractEntity
    {
        public Post(int userId, string? subtitle, List<Image>? images)
        {
            ValidateDomain();

            UserId = userId;
            Subtitle = subtitle;
            Images = images;
        }

        public Post(string? subtitle)
        {
            ValidateDomain();
            Subtitle = subtitle;
        }

        [Column(TypeName = "TEXT")]
        public string? Subtitle { get; private set; }

        [Column(TypeName = "INT UNSIGNED")]
        public int UserId { get; set; }

        public User? User { get; set; }
        public List<Image>? Images { get; set; }
        public List<Like>? Likes { get; set; }
        public List<Comment>? Comments { get; set; }

        private void ValidateDomain()
        {
            DomainException.When(Id < 0, "Usuário não informado.");
            DomainException.When(Subtitle?.Length == 8, "Informe uma legenda para esta postagem.");
        }
    }
}