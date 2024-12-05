using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczeniakupka
{
    public class Obraz
    {
        public int liczbaPolubien;
        public string urlObrazka;

        public Obraz(string urlObrazka)
        {
            this.urlObrazka = urlObrazka;
            liczbaPolubien = 0;
        }
    }
}
