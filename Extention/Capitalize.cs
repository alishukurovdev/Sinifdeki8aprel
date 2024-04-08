using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifdeYazilan.Extention
{
      static  class Capitalize
    {
        public static string Capitalize1(this string name)
        {
           return name.Substring(0,1).ToUpper() + name.Substring(1).ToLower();
        }
    }
}
