using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Interfaces;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Services
{
    public class PersonnelService
    {
        private readonly IRepository<Personnel> _personnelPepository;
        public PersonnelService(IRepository<Personnel> personnelRepository)
        {
            _personnelPepository = personnelRepository;
        }

        public async Task<List<Personnel>> GetPersonnels()
        {
            return await _personnelPepository.GetAll().ToListAsync();
        }

        public async Task AddPersonnel(Personnel personnel)
        {
            await _personnelPepository.Add(personnel);    
        }

        public  async Task<Personnel> GetPersonnelById(int id)
        {
            return  await _personnelPepository.GetById(id);
        }
    }
}
