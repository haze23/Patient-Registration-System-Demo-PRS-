using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IDbService
    {
        Patient SavePatient(Patient patient);
        List<Patient> GetPatients(int Id = 0);
        Patient UpdatePatient(Patient patient);
        void DeletePatient(int Id);
    }
}
