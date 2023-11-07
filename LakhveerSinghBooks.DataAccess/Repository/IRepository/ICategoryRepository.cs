using LakhveerSinghBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LakhveerSinghBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
