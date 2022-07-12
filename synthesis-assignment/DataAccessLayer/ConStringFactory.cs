using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccessLayer
{
    public static class ConStringFactory
    {
        public static string ConString(string name)
        {
            foreach (var item in ConStringDictionary())
            {
                if (item.Key == name)
                {
                    return item.Value;
                }
            }
            throw new ConnectionStringNotFound(name);
        }


        private static Dictionary<string, string> ConStringDictionary()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("Mysql", "Server=studmysql01.fhict.local;Uid=dbi489394;Database=dbi489394;Pwd=1234;");
            return dict;


        }
    }
}
