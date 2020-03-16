using System;
using System.Collections.Generic;
using System.Text;

namespace BoloProject.Processors.Dates
{
    public class BoloDates
    {
        public static List<string> GetDatas()
        {
            DateTime dateIni = new DateTime(2020, 2, 20);
            DateTime dateFin = new DateTime(2020, 12, 24);

            var datas = new List<string>();

            while(dateIni < dateFin)
            {
                if (dateIni.DayOfWeek == DayOfWeek.Thursday)
                    datas.Add(dateIni.ToString("dd/MM"));
                dateIni = dateIni.AddDays(7);
            }

            return datas;
        }
    }
}
