using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL.DomainModels;
using WebApplication1.Models;

namespace WebApplication1.Common
{
    public static class Mapper
    {
        public static Group ToDomain(GroupModel entity)
        {
            return new Group
            {
                Id = entity.Id,
                Name = entity.Name,
                NumOfStudents = entity.NumOfStudents
            };
        }

        public static GroupModel ToView(Group entity)
        {
            return new GroupModel
            {
                Id = entity.Id,
                Name = entity.Name,
                NumOfStudents = entity.NumOfStudents
            };
        }
    }
}

