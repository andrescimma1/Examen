using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeRopa
{
    class Vendedor
    {
        private String nombre;
        private String apellido;
        private String codigo;
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public string Codigo { get => codigo; }

        public Vendedor()
        {
            this.nombre = "Juan";
            this.apellido = "Perez";
            this.codigo = "jperez157";
        }

        
    }
}
