using syseng.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace syseng.Web.Repositories
{
    public class ArticleRepository
    {
        #region System
        public ApplicationDbContext context;
        private bool _disposed;

        public ArticleRepository()
        {
            context = new ApplicationDbContext();
            _disposed = false;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (context != null)
                        context.Dispose();
                }
            }
        }
        #endregion
    }
}