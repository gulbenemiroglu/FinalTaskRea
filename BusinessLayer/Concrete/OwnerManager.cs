using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class OwnerManager : IOwnerService
    {
        IOwnerDal _ownerDal;
        public OwnerManager(IOwnerDal ownerDal)
        {
            _ownerDal = ownerDal;
        }
        public void Add(Owner owner)
        {
            _ownerDal.Add(owner);
        }

        public void Delete(Owner owner)
        {
            _ownerDal.Delete(owner);
        }

        public List<Owner> GetAll()
        {
            return _ownerDal.GetAll();
        }

        public Owner GetId(int ownerId)
        {
           return _ownerDal.GetId(ownerId);
        }

        public void Update(Owner owner)
        {
            _ownerDal.Update(owner);
        }
    }
}
