using APBD10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD10.Services
{
    interface IPharmacyDbService
    {
        public IEnumerable<Doctor> GetDoctors(); 
    }
}
