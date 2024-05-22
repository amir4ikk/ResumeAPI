using Data.Interfaces;
using Domain.Entities;
using Infastructure.Data;
using Infastructure.Interfaces;

namespace Infastructure.Repositories;
public class ResumeRepository(AppDbContext dbContext) : GenericRepository<Resume>(dbContext), IResumeRepository
{
}
