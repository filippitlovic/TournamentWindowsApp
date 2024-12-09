using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentLibrary.Models;
using TournamentLibrary.DataAccess.TextHelpers;

namespace TournamentLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv"; //velikim slovom jer je cosntm

        public PersonModel CreatePerson(PersonModel model)
        {
            throw new NotImplementedException();
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
            //nece se id auto kreirat, pa zato prvo trebam sve procitat iz filea sto ima, da znam koji mi je iduci id


            //Load text file
            //Convert text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            //Find the ID
            int currentId = 1;
            
            if(prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }// pronalazi najveći id i max + 1
            model.Id = currentId;

            //Add new record with new ID
            prizes.Add(model);
            
            
            //convert prizes to the list<string>
            //save the list<string> to the text file
            prizes.SaveToPrizeFile(PrizesFile);


            return model;
        }
    }
}
