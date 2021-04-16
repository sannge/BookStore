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
        //dapper dynamic parameters for store procedure from user
        //like int or string values
        T Single<T>(string procedureName, DynamicParameters param=null);

        void Execute(string procedureName, DynamicParameters param = null);

        //one record means return 1 row of data
        T OneRecord<T>(string procedureName, DynamicParameters param = null);

        IEnumerable<T> List<T>(string procedureName, DynamicParameters param = null);


        //for stored procedures that return two tables.
        Tuple<IEnumerable<T1>,IEnumerable<T2>> List<T1,T2>(string procedureName, DynamicParameters param = null);
    }
}
