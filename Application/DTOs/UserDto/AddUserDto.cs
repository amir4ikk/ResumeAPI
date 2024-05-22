using Domain.Entities;
using Domain.Enums;

namespace Application.DTOs.UserDtos;
public class AddUserDto
{
    public string FullName { get; set; } = "";
    public string Email { get; set; } = "";
    public Gender Gender { get; set; }
    public string PasswordHash { get; set; } = "";

    public static implicit operator User(AddUserDto dto)
    {
        return new User
        {
            FullName = dto.FullName,
            Email = dto.Email,
            Gender = dto.Gender,
            PasswordHash = dto.PasswordHash,
        };

    }
}
