using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio_1.Models
{
    internal class DepartamentoVehicular
    {
        public int CantidadRegistros { get; private set; } = 0;
        ArrayList misregistros = new ArrayList();

        public Registrar RegistrarVehiculo (Persona persona, string apatente, string nmroserie) 
        {
            Registrar actual;
            actual = new Registrar(apatente, nmroserie, persona);
            misregistros.Add(actual);
            CantidadRegistros++;
            return actual;
        }

        public Registrar VerRegistro (int idx)
        {
            Registrar actual;
            actual = (Registrar)misregistros[idx];
            return actual;
        }

         public char GenerarPatente()
        {
            Random random = new Random();
            int valor = random.Next(65, 91);
            char letra;
            letra = Convert.ToChar(valor);
            return letra;
        }

    }
}
