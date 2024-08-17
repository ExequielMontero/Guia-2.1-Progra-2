using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class Registrar
    {
        public string patente { get; private set; }
        public string serie { get; private set; }

        public Persona dueño { get; private set; }

        public Registrar(string patente, string serie, Persona propietario)
        {
            this.patente = patente;
            this.serie = serie;
            dueño = propietario;
        }

        public string VerDetalle()
        {
            return $"Patente: {patente}, Serie: {serie}, Dueño: {dueño}";


        }

    }
}
