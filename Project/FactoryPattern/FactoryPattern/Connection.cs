using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// Product
    /// </summary>
    public abstract class Connection
    {
        public virtual String description()
        {
            return "generic";
        }
    }

    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class OracleConnection : Connection
    {
        public override String description()
        {
            return "Oracle Connection";
        }
    }

    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class SQLServerConnection : Connection
    {
        public override String description()
        {
            return "SQL Server Connection";
        }
    }

    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class MySQLConnection : Connection
    {
        public override String description()
        {
            return "MySQL Connection";
        }
    }

    /// <summary>
    /// ConcreteCreator
    /// </summary>
    public class ConnectionFactory
    {
        private String type;

        public ConnectionFactory(String t)
        {
            type = t;
        }

        public Connection createConnection()
        {

            if (this.type.Equals("Oracle"))
            {
                return new OracleConnection();
            }
            else if (this.type.Equals("SQL Server"))
            {
                return new SQLServerConnection();
            }
            else
            {
                return new MySQLConnection();
            }
        }
    }


}
