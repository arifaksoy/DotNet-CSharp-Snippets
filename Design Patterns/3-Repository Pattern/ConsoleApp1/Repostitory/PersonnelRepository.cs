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
    public class PersonnelRepository :BaseRepository<Personnel> , IRepository<Personnel>
    {
        public PersonnelRepository(RepositoryContext context):base(context) { }

        public async Task Add(Personnel entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            await _context.Personnel.AddAsync(entity);
            await SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var personnel = _context.Personnel.Find(id);
            if (personnel != null)
            {
                _context.Personnel.Remove(personnel);
                await SaveChangesAsync();
            }
        }

        public IQueryable<Personnel> GetAll()
        {
             return _context.Personnel;
        }

        public async Task<Personnel> GetById(int id)
        {
            return await _context.Personnel.FindAsync(id);
        }

        public async Task Update(Personnel entity)
        {
             _context.Entry(entity).State = EntityState.Modified;
              await SaveChangesAsync();
        }
    }
}
