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
        public void ModifyDoctor(int doctorToModifyId, Doctor newDoctorsParameters);
        public void DleteDoctor(int id);
        public void AddDoctor(Doctor doctor);
    }
}
