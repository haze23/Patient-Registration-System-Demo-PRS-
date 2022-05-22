using Entities.Models;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Services
{
    public class DbService : IDbService, IDisposable
    {
        PRSContext context;
        private bool disposed;

        #region ctor
        public DbService()
        {
            context = new PRSContext();
            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            if (type == null)
                throw new Exception("Do not remove, ensures static reference to System.Data.Entity.SqlServer");
        }
        ~DbService()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(false);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                    context.Dispose();
                disposed = true;
            }
        }
        #endregion

        #region crud
        public void DeletePatient(int Id)
        {
            var patient = context.Patients.Find(Id);
            if (patient != null)
            {
                context.Patients.Remove(patient);
            }
        }
        public List<Patient> GetPatients(int Id = 0)
        {
            List<Patient> lstPatients = new List<Patient>();

            if (Id != 0)
            {
                lstPatients.Add(context.Patients.Find(Id));
            }
            else
            {
                lstPatients = context.Patients.ToList();
            }
              
            return lstPatients;
        }

        public Patient SavePatient(Patient patient)
        {
            var entity = new Patient();
            try
            {
                context.Patients.Add(patient);
                context.SaveChanges();
                entity = context.Patients.Where(c => c.Id == patient.Id).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            return entity;
        }
        public Patient UpdatePatient(Patient patient)
        {
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
        #endregion
    }
}
                                                                                                                                                       