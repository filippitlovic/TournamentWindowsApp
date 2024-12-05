using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using TournamentLibrary.Models;

namespace TournamentLibrary.DataAccess
{
    
 //   @PlaceNumber int,
	//@PlaceName nvarchar(50),
	//@PrizeAmount money,
 //   @PrizePercentage float,
	//@id int = 0 output
	                   
    public class SqlConnector : IDataConnection
    {
        //saves a new prize to the database
        //parametar model stize s podacima za kreiranje novog prizea, bez id
        public PrizeModel CreatePrize(PrizeModel model)
        {

            //ovaj using omogućuje dohvaćanje konekcije iz globalconfiga iz funkcije cnnstring
            //kad se using zatvori, uništava se sve, zbog sprjecavanja curenja podataka
            // znaci da veza nece bit otvorena stalno, nego ce ju otvarat i zatvarat sa svakim using
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var p = new DynamicParameters(); //klasa vezana za Dapper, sluzi za dodavanje parametara u sql upite
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName",model.PlaceName);    
                p.Add("PrizeAmount",model.PrizeAmount);
                p.Add("PrizePercentage",model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32,direction: ParameterDirection.Output); //ovaj pišeš ovako jer on stiže od outputa

                connection.Execute("dbo.spPrizes_Insert",p,commandType:CommandType.StoredProcedure); //ako ne treba nista da nam vrati(update,insert..),query bi bio da vrati

                model.Id = p.Get<int>("@id");
                return model;
            }
        }
    }
}
