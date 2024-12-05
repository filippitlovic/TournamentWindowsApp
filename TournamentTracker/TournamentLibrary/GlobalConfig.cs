using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentLibrary.DataAccess;

namespace TournamentLibrary
{
    public static class GlobalConfig
    {
        // ovo znaci, Connections lista ce drzat sve ono sto implementira IdataConnection interface(moze biti i sql i textfile)
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
          {
            if (database)
            {
                ///TODO - do sth - create sql con, set up sqlcon properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if (textFiles)
            {
                ///TODO- do sth - create Text connc
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }

        //connection,predajemo mu ime baze iz connection stringa iz app configa
        public static String CnnString(string name)
        {
           return  ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
