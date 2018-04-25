using System.Collections.Generic;

namespace AllMyWheels.DAL
{
    public interface IDatabaseClient
    {
        void Commit();

        void Rollback();

        IEnumerable<T> RunQuery<T>(string sql, object parameters);

        int RunCommand(string sql, object parameters);

        void BeginTransaction();
    }
}
