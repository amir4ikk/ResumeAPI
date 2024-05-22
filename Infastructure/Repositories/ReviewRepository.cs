using Domain.Entities;
using Infastructure.Data;
using Infastructure.Interfaces;

namespace Infastructure.Repositories;
public class ReviewRepository(AppDbContext dbContext) : GenericRepository<Review>(dbContext), IReviewRepository
{
}
