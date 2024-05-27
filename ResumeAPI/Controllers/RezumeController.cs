using Application.DTOs.ResumeDtos;
using Application.Interfaces;
using Infastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ResumeAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RezumeController(IResumeService resumeService,
    IResumeRepository resumeRepository) : ControllerBase
{
    private readonly IResumeService _resumeService = resumeService;
    private readonly IResumeRepository _resumeRepository = resumeRepository;

    [HttpPost("upload")]
    public async Task<IActionResult> UploadPdf([FromForm] ForFileResumeDto file, [FromForm] int userId)
    {
        if (file == null)
        {
            return BadRequest("Invalid file upload request");
        }
         
        var text = _resumeService.ExtractTextFromPdf(file);
        var resumeData = _resumeService.ParseResumeData(text);

        var createdResume = await _resumeRepository.CreateResume(resumeData, userId);

        return Ok(createdResume);
    }
}

