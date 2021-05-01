using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeRopa
{
    public class Prenda
    {
        private bool standar;
        private float precio;
        private int stock;

        public bool Standar { get => standar; set => standar = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }

        public Prenda()
        {
            this.standar = false;
            this.precio = 0;
            this.stock = 0;
        }
    }
}
