using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOwnerService
    {
        void Add(Owner owner);
        void Delete(Owner owner);
        void Update(Owner owner);
        List<Owner> GetAll();
        Owner GetId(int ownerId);
    }
}
