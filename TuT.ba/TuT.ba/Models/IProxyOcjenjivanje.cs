using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuT.ba.Models
{
    interface IProxyOcjenjivanje
    {
        public Boolean OdobrenoOcjenjivanje(Instrukcija instrukcija, Student student);
    }
}
