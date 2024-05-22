using Data.Interfaces;
using Infastructure.Data;
using Infastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infastructure.Repositories;
public class UnitOfWork(AppDbContext dbContext) : IUnitOfWork
{
    private readonly AppDbContext _dbContext = dbContext;

    public IUserRepository User => new UserRepository(_dbContext);

    public IResumeRepository Resumes => new ResumeRepository(_dbContext);

    public IReviewRepository Review => new ReviewRepository(_dbContext);

    public INotificationsRepository Notifications => new NotificationsRepository(_dbContext);
}
