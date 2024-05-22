using Domain.Entities;
using Infastructure.Data;
using Infastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infastructure.Repositories;
public class NotificationsRepository(AppDbContext dbContext) : INotificationsRepository
{
    protected readonly AppDbContext _dbContext = dbContext;
    private readonly DbSet<Notification> _dbSet = dbContext.Set<Notification>();
    public async Task<List<Notification>> GetAllWorkingReviewsAsync()
        => await _dbSet.ToListAsync();
}
