using Application.DTOs.ReviewDtos;
using Application.Interfaces;

namespace Application.Services;
public class ReviewService : IReviewService
{
    public Task CreateAsync(AddReviewDto dto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ReviewDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ReviewDto?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(ReviewDto dto)
    {
        throw new NotImplementedException();
    }
}
