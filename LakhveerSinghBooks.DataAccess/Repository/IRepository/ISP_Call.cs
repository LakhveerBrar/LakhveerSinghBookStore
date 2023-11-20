using System;
using System.Collections.Generic;
using System.Text;

namespace LakhveerSinghBooks.DataAccess.Repository.IRepository
{
    interface ISP_Call : IDisposable
    {
        T Single<T>(string procedurename, DynamicParameters)
    }
}
