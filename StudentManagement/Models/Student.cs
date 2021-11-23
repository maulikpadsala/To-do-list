using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRecordManagementSystem.Models
{
    public class ToDo
    {
        public int Id { set; get; }
        [Required]
        public string Notes { set; get; }
        [Required]
        public string Status { set; get; }

        public string ComplitionDate { set; get; }

    }
}
