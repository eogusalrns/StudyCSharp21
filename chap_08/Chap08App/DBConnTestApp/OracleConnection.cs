using System.Data;

namespace DBConnTestApp
{
    internal class OracleConnection : IDbConnection
    {
        private string connstring;

        public OracleConnection(string connstring)
        {
            this.connstring = connstring;
        }
    }
}