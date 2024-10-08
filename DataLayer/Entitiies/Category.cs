﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Domain Model
namespace DataLayer.Entitiies
{
    public class Category : BaseEntity<int>
    {
        [Required]
        [MaxLength(300)]
        public string Title { get; set; }
        [Required]
        [MaxLength(300)]
        public string Slug { get; set; }
        public string MetaTag { get; set; }
        public string MetaDescription { get; set; }
      
        
        #region Relation
        public ICollection<Post> Posts { get; set; }
        #endregion



    }
}
