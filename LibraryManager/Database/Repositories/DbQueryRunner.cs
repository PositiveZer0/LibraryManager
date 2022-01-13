namespace LibraryManager.Database.Repositories
{
    using LibraryManager.Database.Data;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class DbQueryRunner : IDbQueryRunner
    {
        public DbQueryRunner(LibraryManagerContext context)
        {
            this.Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public LibraryManagerContext Context { get; set; }

        public Task RunQueryAsync(string query, params object[] parameters)
        {
            return this.Context.Database.ExecuteSqlRawAsync(query, parameters);
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.Context?.Dispose();
            }
        }
    }
}
