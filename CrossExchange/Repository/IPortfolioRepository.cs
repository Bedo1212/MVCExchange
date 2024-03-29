﻿using System.Linq;

namespace CrossExchange
{
    public interface IPortfolioRepository : IGenericRepository<Portfolio>
    {
        IQueryable<Portfolio> GetAll();
        bool IsRegisterd(int id);
    }
}