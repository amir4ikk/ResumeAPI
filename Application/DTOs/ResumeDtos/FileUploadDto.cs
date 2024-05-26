namespace Application.DTOs.ResumeDtos;

public class FileUploadDto
{
    public string FileName { get; set; }
    public byte[] FileContent { get; set; }
    public int UserId { get; set; }
}
