using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Interfaces;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Repostitory
{
    public class CompanyRepository : BaseRepository<Company> ,IRepository<Company>
    {
        public CompanyRepository(RepositoryContext context): base(context) { }

        public async Task Add(Company entity)
        {
            await _context.Company.AddAsync(entity);  
            await SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var company = _context.Company.Find(id);
            if (company != null)
            {
                _context.Company.Remove(company);
                await SaveChangesAsync();
            }
        }

        public IQueryable<Company> GetAll()
        {
            return _context.Company;
        }

        public async Task<Company> GetById(int id)
        {
            return await _context.Company.FindAsync(id);
        }

        public async Task Update(Company entity)
        {
            _context.Company.Update(entity);
            await SaveChangesAsync();
        }
    }
}
