﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Domain Model
namespace DataLayer.Entitiies
{
    public class Post : BaseEntity<int>
    {
       
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(300)]
        public string Title { get; set; }
        [Required]
        [MaxLength(300)]
        public string Slug { get; set; }//URL String For Post
        [Required]
        public string Description { get; set; }
        public int Visit { get; set; }
       


        #region Relation
        [ForeignKey("UserId")]
        public User User { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public ICollection<PostComment> PostComments { get; set; }
        #endregion
    }
}
