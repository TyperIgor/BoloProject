using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectBolo.CakeDates
{
    public class Dates 
    {
        public static List<string> GetDates()
        {
            var lista = new List<string>();

            DateTime dateInicial = new DateTime(2020, 2, 20);
            DateTime dateFinal = new DateTime(2020, 8, 20);

            while (dateInicial <= dateFinal)
            {
                if (dateInicial.DayOfWeek == DayOfWeek.Thursday)
                    lista.Add(dateInicial.ToString("dd/MM"));
                dateInicial = dateInicial.AddDays(7);
            }

            return lista;
        }
    }
}

