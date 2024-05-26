using Data.Interfaces;
using Domain.Entities;

namespace Infastructure.Interfaces;
public interface IResumeRepository : IGenericRepository<Resume>
{
    Task<Resume> CreateResume(Dictionary<string, string> resumeData, int userId);
}
