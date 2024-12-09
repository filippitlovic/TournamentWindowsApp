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
        public static IDataConnection Connection { get; private set; } 


        public static void InitializeConnections(DatabaseType db) // parametar je enum, da ne moramo vodit brigu oce neko ubacit naziv malim, velikm slovom, krivi naziv .. itd, ovako samo moze birat sta se nalazi u enumu, jednostavno sigurnije je
          {

            if (db == DatabaseType.Sql)
            {
                ///create sql con, set up sqlcon properly
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                ///create Text connc
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        //connection,predajemo mu ime baze iz connection stringa iz app configa
        public static String CnnString(string name)
        {
           return  ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
