﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace blazorTest.Server.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public ApplicationUser UserId { get; set; }
        public Guid RoomId { get; set; }
        [MaxLength(200)]
        public string Text { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreateDate { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdateDate { get; set; }
        public List<Thread> Threads { get; set; }

    }
}
