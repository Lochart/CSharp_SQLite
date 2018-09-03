using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace SQLite
{
    public class Anime_Command
    {

        SQLiteConnection database;
        public Anime_Command(string filename)
        {
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Anime>();
        }

        public IEnumerable<Anime> Select_Standart()
        {
            return (from i in database.Table<Anime>() select i).ToList();
        }

        public List<Anime> Select_SQL()
        {
            var result = database.Query<Anime>("SELECT * FROM [Animes] ");

            return result;
        }

        public void Update_SQL(Anime item)
        {
            database.Query<Anime>(
                "UPDATE [Animes] " +
                "Set [Name] = '" + item.Name + "'"+
                "Where [Id] = '"+ item.Id +"' ");
        }

        public void Delete_Standart(int id)
        {
            database.Delete<Anime>(id);
        }

        public void Update_Standart(Anime item)
        {
            database.Update(item);
        }

        public void Insert_Standart(Anime item)
        {
            database.Insert(item);
        }
    }
}