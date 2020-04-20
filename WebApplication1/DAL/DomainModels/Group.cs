using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.DAL.DomainModels
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumOfStudents { get; set; }
        //public virtual ICollection<Student> Students { get; set; }
    }
}
