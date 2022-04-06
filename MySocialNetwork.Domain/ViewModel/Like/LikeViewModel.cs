﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Domain.ViewModel.Like
{
    public class LikeViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public bool IsLiked { get; set; }
    }
}