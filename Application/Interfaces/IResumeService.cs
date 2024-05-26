using Application.DTOs.ResumeDtos;
using Microsoft.AspNetCore.Http;

namespace Application.Interfaces;
public interface IResumeService
{
    Task CreateAsync(AddResumeDto dto);
    Task<ResumeDto?> GetByIdAsync(int id);
    Task<List<ResumeDto>> GetAllAsync();
    Task UpdateAsync(ResumeDto dto);
    Task DeleteAsync(int id);
    string ExtractTextFromPdf(IFormFile file);
    Dictionary<string, string> ParseResumeData(string text);
}
