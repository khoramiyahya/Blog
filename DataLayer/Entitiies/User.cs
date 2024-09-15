using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Domain Model
namespace DataLayer.Entitiies
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Username { get; set; }
        [MaxLength(300)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(100)]
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreattionUsername { get; set; }
        public bool IsDelete { get; set; }

        #region Relation
        public UserRole Role { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<PostComment> PostComments { get; set; }
        #region



    }
    public enum UserRole
    {
        Admin,
        User,
        Writer
    }
}
