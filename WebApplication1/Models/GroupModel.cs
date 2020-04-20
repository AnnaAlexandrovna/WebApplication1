using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class GroupModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Имя является обязательным")]
        public string Name { get; set; }
        [Required]
        [Range(0, 5)]
        public int NumOfStudents { get; set; }
        //public virtual ICollection<Student> Students { get; set; }

    }
}
