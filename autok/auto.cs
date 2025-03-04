using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autok
{
    internal class auto
    {
        public string rendszam { get; set; }
        public int ora { get; set; }
        public int perc { get; set; }
        public int sebesseg { get; set; }

        public auto(string rend,int or,int pe,int seb)
        {
            rendszam=rend;
            ora=or; 
            perc=pe;
            sebesseg=seb;
        }
    }
}
