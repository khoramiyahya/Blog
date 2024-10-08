﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
//Domain Model
namespace DataLayer.Entitiies
{
    public class PostComment :BaseEntity<int>
    {
        
        public int UserId { get; set; }
        public int PostId { get; set; }
        [Required]
        [MaxLength(3000)]
        public string Text { get; set; }
   

        #region Relation
        [ForeignKey("PostId")]
        public Post Post { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        #endregion


    }
}
