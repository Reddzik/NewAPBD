using APBD10.DTOs.Req;
using APBD10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD10.Services
{
    public interface IPharmacyDbService
    {
        public IEnumerable<Doctor> GetDoctors();
        public void ModifyDoctor(DoctorRequest newDoctorsParameters);
        public void DleteDoctor(int id);
        public void AddDoctor(DoctorRequest doctor);
    }
}
