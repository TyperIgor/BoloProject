using System;
using System.Collections.Generic;

namespace Bolo.Integration.Core.Dates
{
    public class FindDates
    {
        public static List<object> GetDatas()
        {
            DateTime dateIni = new DateTime(2020, 2, 20);
            DateTime dateFin = new DateTime(2020, 12, 24);

            var datas = new List<object>();

            while (dateIni < dateFin)
            {
                if (dateIni.DayOfWeek == DayOfWeek.Thursday)
                    datas.Add(dateIni.ToString("dd/MM"));
                dateIni = dateIni.AddDays(7);
            }

            return datas;
        }
    }
}
