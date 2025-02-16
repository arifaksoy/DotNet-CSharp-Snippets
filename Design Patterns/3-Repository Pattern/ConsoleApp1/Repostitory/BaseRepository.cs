using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Repostitory
{
    public abstract class BaseRepository<T> where T : class
    {
        protected readonly RepositoryContext _context;

        protected BaseRepository(RepositoryContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        protected async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}