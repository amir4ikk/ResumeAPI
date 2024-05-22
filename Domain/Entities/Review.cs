using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;
public class Review : BaseEntity
{
    public int NeedWorkingExperience { get; set; }
    public string NeedEducation { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string NeedProgrammingLanguages { get; set; } = string.Empty;
    public string NeedLanguages { get; set; } = string.Empty;

    public bool IsSerching { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = new();
}
