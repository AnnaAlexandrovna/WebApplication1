using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL.DomainModels;

namespace WebApplication1.DAL.MemoryStorage
{
    public class GroupMemoryStorage : IGroupStorage
    {
        public readonly List<Group> _groups;
        public int _id;

        public GroupMemoryStorage()
        {
            _id = 1;
            _groups = new List<Group> {

                new Group(){
                    Name = "радиофизика",
                    Id = _id++,
                    NumOfStudents = 12
                },
            new Group(){
                Name = "общая физика",
                Id = _id++,
                NumOfStudents = 3
            }
            };
        }

        public void Add(Group group)
        {
            group.Id = _id++;
            _groups.Add(group);
        } 

        public List<Group> GetAll()
        {
            return _groups;
        }
    }
}
