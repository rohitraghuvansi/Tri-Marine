using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;

namespace TMG.DataAccessLayer
{
    public class BaseDal
    {
        /// <summary>
        /// To execute and Log procedure with input values
        /// </summary>
        /// <param name="db">Database</param>
        /// <param name="dbCommand">DB Command</param>
        /// <returns></returns>
        public IDataReader ExecuteReader(Database db, DbCommand dbCommand)
        {            
            return db.ExecuteReader(dbCommand);
        }
        /// <summary>
        /// To execute and Log procedure with input values
        /// </summary>
        /// <param name="db">Database</param>
        /// <param name="dbCommand">DB Command</param>
        /// <returns></returns>
        public int ExecuteNonQuery(Database db, DbCommand dbCommand)
        {           
            return db.ExecuteNonQuery(dbCommand);
        }
        /// <summary>
        /// To execute and Log procedure with input values
        /// </summary>
        /// <param name="db">Database</param>
        /// <param name="dbCommand">DB Command</param>
        /// <returns></returns>
        public object ExecuteScalar(Database db, DbCommand dbCommand)
        {           
            return db.ExecuteScalar(dbCommand);
        }
        /// <summary>
        /// Get value from the reader.
        /// </summary>
        /// <typeparam name="T">Type of the column</typeparam>
        /// <param name="reader">IDatareader</param>
        /// <param name="columnName">Name of the column</param>
        /// <returns></returns>
        public T GetValue<T>(IDataReader reader, string columnName)
        {
            int index = reader.GetOrdinal(columnName);
            if (reader.IsDBNull(index))
            {
                if (typeof(T) == typeof(string))
                {
                    object obj;
                    obj = string.Empty;
                    return (T)obj;
                }
                else
                    return default(T);
            }

            return (T)reader[index];
        }
    }
}
