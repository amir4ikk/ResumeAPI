using Data.Interfaces;

namespace Infastructure.Interfaces;
public interface IUnitOfWork
{
    IResumeRepository Resumes { get; }
    IReviewRepository Review { get; }
    IUserRepository User { get; }
}
