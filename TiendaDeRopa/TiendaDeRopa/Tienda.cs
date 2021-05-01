using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeRopa
{
    class Tienda
    {
        private String nombre;
        private String direccion;
        private LinkedList<Prenda> prendas;
        public string Nombre { get => nombre; }
        public string Direccion { get => direccion; }
        internal LinkedList<Prenda> Prendas { get => prendas; set => prendas = value; }
        
        public Tienda()
        {
            this.nombre = "La tienda de Juan";
            this.direccion = "Pallares 265";
            this.prendas = new LinkedList<Prenda>();
        }
    }
}
