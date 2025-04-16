using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting {
    internal class Personaje {


        public string ReturnsPersonaje(string n, string l) {
            return ($"nombre:{n} + linea{l}");
        }
    }
}
