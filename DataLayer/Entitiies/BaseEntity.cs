using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entitiies
{
    public class BaseEntity<TKey>
    {
        [Key]
        public TKey Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreattionUsername { get; set; }
        public bool IsDelete { get; set; }
    }
}
