using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentLibrary.Models;

//Load text file - 1
//Convert text to List<PrizeModel> - 2
//Find the ID
//Add new record with new ID
//convert prizes to the list<string>
//save the list<string> to the text file

namespace TournamentLibrary.DataAccess.TextHelpers //dodano TextConncetor da ne mgu svi pristupit
{
    public static class TextConnectorProcessor
    {
        //ovaj this u parametru, znaci da se metoda sad koristi kao ekstenzijska metoda, odnosno
        //FullFilePath se moze pozvati na bilo kojoj instanciranoj string varijabli
        //stavit ce se ovaj path dolje plus path od tog novog stringa

        //static je sve jer nam ne treba objekt ove klase, samo njene metode koje cemo pozivat bez kreiranja objekta
        public static string FullFilePath(this string fileName) //PrizeModel.csv
        {
            //C:\Users\Korisnik\source\repos\TournamentTracker\PrizeModel.csv
            return $"{ConfigurationManager.AppSettings["filePath"]}\\ {fileName}";  // $ za spajanje strinogva, dva slasha jer jedan se ocitava kao neko odvajanje stringova, a nama treba slash kao dio stringa
        }

        public static List<string> LoadFile(this string file) // 1
        {
            if (!File.Exists(file)) //ako file ne postoji
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines) //2
        {
            List<PrizeModel> output = new List<PrizeModel>();
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(columns[0]);
                p.PlaceNumber = int.Parse(columns[1]);
                p.PlaceName = columns[2];
                p.PrizeAmount = decimal.Parse(columns[3]);
                p.PrizePercentage = double.Parse(columns[4]);   
                output.Add(p);  

            } 
            return output;
        }
        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
             List<string> lines = new List<string>();

            //modele pretvorimo u listu stringova
            foreach(PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines); // file name + path i ono sto upisujemo u file
        }
    }
}
