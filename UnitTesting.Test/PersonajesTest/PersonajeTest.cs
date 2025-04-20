using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Personajes;
using FluentAssertions;

namespace UnitTesting.Test.PersonajesTest {
    public class PersonajeTest {

        [Fact]
        public void Personaje_ReturnsPersonaje_ReturnString() {
            //OPERACION
            string n = "nombre", l = "line";
            var personaje = new Personaje();

            string result = personaje.ReturnsPersonaje(n, l);

            //ACTUAR
            result.Should().NotBeNullOrEmpty();
        }

    }
}
