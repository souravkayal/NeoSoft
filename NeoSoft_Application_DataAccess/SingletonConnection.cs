using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace NeoSoft_Application_DataAccess
{
 
        //We should not use singleton database object. It may lead to memory leak 
        //as the database object will not dispose 
        public sealed class SingletonDB
        {
            private static readonly SingletonDB instance = new SingletonDB();
            private static readonly SqlConnection con = new SqlConnection("");

            static SingletonDB()
            {
            }

            private SingletonDB()
            {
            }

            public static SingletonDB Instance
            {
                get
                {
                    return instance;
                }
            }

            public static SqlConnection GetDBConnection()
            {
                return con;
            }
        }
    
}
