﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epam.Wunderlist.Orm
{
    [Table("Folder")]
    public partial class Folder : IEntity
    {
        public Folder()
        {
            ToDoLists = new List<ToDoList>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public int UserId { get; set; }

        public virtual ICollection<ToDoList> ToDoLists { get; set; }
        public virtual User User { get; set; }
    }
}
