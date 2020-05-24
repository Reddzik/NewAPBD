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
            _context.Doctors.Add(doctor);
        }

        public void DleteDoctor(int id)
        {
            var doctorToDelete = _context.Doctors
                                         .Where(doctor => doctor.IdDoctor == id)
                                         .FirstOrDefault();
            _context.Doctors.Remove(doctorToDelete);
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctors.ToList();
        }

        public void ModifyDoctor(int doctorToModifyId, Doctor newDoctorsParameters)
        {
            var doctorToModify = _context.Doctors
                                         .Where(doctor => doctor.IdDoctor == doctorToModifyId)
                                         .FirstOrDefault();
            doctorToModify.FirstName = newDoctorsParameters.FirstName;
            doctorToModify.LastName = newDoctorsParameters.LastName;
            doctorToModify.Email = newDoctorsParameters.Email;

            _context.Doctors.Update(doctorToModify);
        }
    }
}
