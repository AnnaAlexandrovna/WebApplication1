using System.Collections.Generic;
using WebApplication1.DAL.DomainModels;

namespace WebApplication1.DAL.MemoryStorage
{
    public interface IGroupStorage
    {
        void Add(Group group);
        List<Group> GetAll();
    }
}