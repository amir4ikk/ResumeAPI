using Domain.Entities;

namespace Application.DTOs.UserDtos;
public class UserDto : AddUserDto
{
    public int Id { get; set; }

    public static implicit operator UserDto(User user)
    {
        return new UserDto()
        {
            Id = user.Id,
            FullName = user.FullName,
            Email = user.Email,
            PasswordHash = user.PasswordHash,
            Gender = user.Gender
        };
    }

}
