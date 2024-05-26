using Application.DTOs.ResumeDtos;
using Application.Interfaces;
using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Http;

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

    public string ExtractTextFromPdf(IFormFile file)
    {
        using (var reader = new PdfReader(file.OpenReadStream()))
        {
            var text = string.Empty;
            for (int i = 1; i <= reader.NumberOfPages; i++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, i);
            }
            return text;
        }
    }

    public Dictionary<string, string> ParseResumeData(string text)
    {
        var resumeData = new Dictionary<string, string>();

        // Define keywords for resume properties
        var properties = new Dictionary<string, string>
            {
                { "Name", "Name" },
                { "Contact", "Contact" },
                { "Location", "Location" },
                { "Working Experience", "WorkingExperience" },
                { "Education", "Education" },
                { "Description", "Description" },
                { "Programming Languages", "ProgrammingLanguages" },
                { "Languages", "Languages" }
            };

        // Split the text into lines
        var lines = text.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var line in lines)
        {
            foreach (var property in properties)
            {
                if (line.Contains(property.Key, StringComparison.OrdinalIgnoreCase))
                {
                    var value = line.Substring(line.IndexOf(property.Key, StringComparison.OrdinalIgnoreCase) + property.Key.Length).Trim(':', ' ', '\t');
                    resumeData[property.Value] = value;
                    break;
                }
            }
        }
        return resumeData;
    }
}
