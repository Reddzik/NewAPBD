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
        public IEnumerable<Doctor> GetDoctors()
        {
            throw new NotImplementedException();
        }
    }
}
