using APBD10.Models;
using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD10.Services
{
    interface IDoctorDbService
    {
        public IEnumerable<Doctor> GetDoctors();
        public void AddDoctor();
        public void ModifyDoctor(int id);
        public void DleteDoctor(int id);
    }
}
