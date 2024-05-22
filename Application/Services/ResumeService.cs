using Application.DTOs.ResumeDtos;
using Application.Interfaces;

namespace Application.Services;
public class ResumeService : IResumeService
{
    public Task CreateAsync(AddResumeDto dto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ResumeDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ResumeDto?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(ResumeDto dto)
    {
        throw new NotImplementedException();
    }
}
