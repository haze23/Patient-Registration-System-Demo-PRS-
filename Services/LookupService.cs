using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Services
{
    public class LookupService : ILookupService,IDisposable
    {
        PRSContext context;
        private bool disposed;
        #region ctor
        public LookupService()
        {
            context = new PRSContext();
            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            if (type == null)
                throw new Exception("Do not remove, ensures static reference to System.Data.Entity.SqlServer");
        }
        ~LookupService()
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
        public List<Gender> GetGender()
        {
            return context.Genders.ToList();
        }
    }
}
