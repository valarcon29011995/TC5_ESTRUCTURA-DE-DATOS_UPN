using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC5
{
    internal class Paciente
    {
        public int id;
        public string nombre, apellido;

        public Paciente(int id, string nombre, string apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
