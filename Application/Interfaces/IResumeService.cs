using Application.DTOs.ResumeDtos;
using Application.DTOs.UserDtos;

namespace Application.Interfaces;
public interface IResumeService
{
    Task CreateAsync(AddResumeDto dto);
    Task<ResumeDto?> GetByIdAsync(int id);
    Task<List<ResumeDto>> GetAllAsync();
    Task UpdateAsync(ResumeDto dto);
    Task DeleteAsync(int id);
}
