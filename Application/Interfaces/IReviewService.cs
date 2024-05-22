using Application.DTOs.ReviewDtos;

namespace Application.Interfaces;
public interface IReviewService
{
    Task CreateAsync(AddReviewDto dto);
    Task UpdateAsync(ReviewDto dto);
    Task DeleteAsync(int id);
    Task<List<ReviewDto>> GetAllAsync();
    Task<ReviewDto?> GetByIdAsync(int id);
}
