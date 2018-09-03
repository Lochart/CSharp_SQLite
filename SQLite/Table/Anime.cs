namespace SQLite
{
    /*
     *  Таблица Animes
     *  Колонки Id, Name
     */

    [Table("Animes")]
    public class Anime 
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}

