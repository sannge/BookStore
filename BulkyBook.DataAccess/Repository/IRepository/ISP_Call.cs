using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        T Single<T>(string procedureName, DynamicParameters)
    }
}
