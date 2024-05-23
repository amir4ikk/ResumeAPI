using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;
public class Resume : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Contact { get; set; } = string.Empty;
    public string Location {  get; set; } = string.Empty;
    public int WorkingExperience { get; set; }
    public string Education { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ProgrammingLanguages { get; set; } = string.Empty;
    public string Languages { get; set; } = string.Empty;

    public string FilePath { get; set; } = string.Empty;
    public int UserId { get; set; }
    [ForeignKey(nameof(UserId))]
    public User User { get; set; } = new();
}
