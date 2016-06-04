using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal static class DayTimeUtilities
    {
        public static int DayToEndMonth(this DateTime date)//Norādot parametrā vārdu this, šī kļūst par Extension metodi, nav nepieciešams izmantot
        {                                                  //DayTimeUtilities keyword lai piekļūtu metodei, var izmantot date.DayToEndMonth piemēram.
            return DateTime.DaysInMonth(date.Year, date.Month) - date.Day;
        }
    }

    class Program
    {
        static void Main()
        {
            DateTime randomDate = new DateTime(2010, 8, 29);

            int dayTillEndOfMonth = randomDate.DayToEndMonth();

            Console.WriteLine("Days till month end: " + dayTillEndOfMonth + " for: " + randomDate.ToShortDateString());
            Console.ReadKey();
        }
    }
}
