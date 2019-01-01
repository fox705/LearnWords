using System.Data;

namespace Toci.business.Dal
{
    public abstract class DbAccessBase
    {

        public abstract bool Connect(string connectionString);

        public abstract int ExecuteInsert(string query);

        public abstract DataTable ExecuteSelect(string select);

    }
}