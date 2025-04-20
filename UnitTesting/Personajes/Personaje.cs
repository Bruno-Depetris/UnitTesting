using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Personajes {
    public class Personaje {


        public string ReturnsPersonaje(string n, string l) {
            if (n != null && l != null) {
                return $"nombre:{n} \n linea{l}";
            } else {
                return $"Los campos deben estar completos";
            }




        }
    }
}
