using APBD10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD10.Services
{
    public class EfPharmacyDbService : IPharmacyDbService
    {
        private readonly PeopleDbContext _context;
        public EfPharmacyDbService(PeopleDbContext context)
        {
            this._context = context;
        }

        public void AddDoctor(Doctor doctor)
        {
            
        }

        public void DleteDoctor(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctors.ToList();
        }

        public void ModifyDoctor(int id)
        {
            throw new NotImplementedException();
        }
    }
}
