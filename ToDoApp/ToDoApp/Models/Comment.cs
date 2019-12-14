﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ToDoApp.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public int TaskId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        public DateTime LastUpdate { get; set; }

        public virtual Task Task { get; set; }

        public virtual User User { get; set; }
    }

    public class CommentDBContext : DbContext
    {
        public CommentDBContext() : base("DBConnectionString") { }

        public DbSet<Comment> Comments { get; set; }
    }
}