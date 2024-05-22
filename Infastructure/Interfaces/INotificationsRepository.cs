﻿using Domain.Entities;

namespace Infastructure.Interfaces;
public interface INotificationsRepository
{
    Task<List<Notification>> GetAllWorkingReviewsAsync();
}
