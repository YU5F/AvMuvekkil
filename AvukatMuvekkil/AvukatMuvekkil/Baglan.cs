using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvukatMuvekkil
{
    internal class Baglan
    {
        public static SQLiteConnection con = new SQLiteConnection("Data source=.\\Veritabanı.db;Versiyon=3");
    }
}
