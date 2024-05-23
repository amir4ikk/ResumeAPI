using Data.Interfaces;
using Infastructure.Data;
using Infastructure.Interfaces;

namespace Infastructure.Repositories;
public class UnitOfWork(AppDbContext dbContext) : IUnitOfWork
{
    private readonly AppDbContext _dbContext = dbContext;

    public IUserRepository User => new UserRepository(_dbContext);

    public IResumeRepository Resumes => new ResumeRepository(_dbContext);

    public IReviewRepository Review => new ReviewRepository(_dbContext);

}
