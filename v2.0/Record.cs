using System.Collections.Generic;
namespace v2._0
{
    public class Record
    {
        private static string[] countries = new[]{"Uruguay", "Italy", "Italy", "Uruguay", "West Germany",
                                    "Brazil", "Brazil", "England", "Brazil", "West Germany",
                                    "Argentina", "Italy", "Argentina", "West Germany", "Brazil",
                                    "France", "Brazil", "Italy", "Spain", "Germany", "France"};
        
        private static string[] year = new[]{"1930", "1934", "1938", "1950", "1954",
                                    "1958", "1962", "1966", "1970", "1974",
                                    "1978", "1982", "1986", "1990", "1994",
                                    "1998", "2002", "2006", "2010", "2014", "2018"};


        private static List<string> record = new List<string>();


        private static List<string> CreateRecord()
        {
            List<string> temporaryRecord = new();
            for (int i = 0; i < countries.Length; i++)
            {
                string concat = $"{year[i]} \t - \t {countries[i]}";
                temporaryRecord.Add(concat);
            }

            return temporaryRecord;
        }

        public static List<string> LoadWorldCupRecord()
        {
            if (record.Count == 0)
            {
                record = CreateRecord();
            }

            return record;
        }
    }
}