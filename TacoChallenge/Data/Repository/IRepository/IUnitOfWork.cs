using System;

namespace TacoChallenge.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IRestaurantRepository Restaurant { get; }
    }
}