using Domain.Entities;
using Infastructure.Data;
using Infastructure.Interfaces;

namespace Infastructure.Repositories;
public class ResumeRepository(AppDbContext context) : GenericRepository<Resume>(context), IResumeRepository
{
    private readonly AppDbContext _context;
    public async Task<Resume> CreateResume(Dictionary<string, string> resumeData, int userId)
    {
        var resume = new Resume
        {
            Name = resumeData.ContainsKey("Name") ? resumeData["Name"] : string.Empty,
            Contact = resumeData.ContainsKey("Contact") ? resumeData["Contact"] : string.Empty,
            Location = resumeData.ContainsKey("Location") ? resumeData["Location"] : string.Empty,
            WorkingExperience = resumeData.ContainsKey("WorkingExperience") ? int.Parse(resumeData["WorkingExperience"]) : 0,
            Education = resumeData.ContainsKey("Education") ? resumeData["Education"] : string.Empty,
            Description = resumeData.ContainsKey("Description") ? resumeData["Description"] : string.Empty,
            ProgrammingLanguages = resumeData.ContainsKey("ProgrammingLanguages") ? resumeData["ProgrammingLanguages"] : string.Empty,
            Languages = resumeData.ContainsKey("Languages") ? resumeData["Languages"] : string.Empty,
            FilePath = "Pdfs/",
            UserId = userId
        };

        _context.Resumes.Add(resume);
        await _context.SaveChangesAsync();

        return resume;
    }
}
