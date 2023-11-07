using LakhveerSinghBooks.DataAccess.Repository.IRepository;
using LakhveerSinghBooks.Models;
using LakhveerSinghBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LakhveerSinghBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
