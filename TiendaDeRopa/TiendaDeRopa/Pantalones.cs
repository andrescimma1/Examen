using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeRopa
{
    class Pantalones : Prenda
    {
        private bool comun;

        public bool Comun { get => comun; set => comun = value; }

        public Pantalones()
        {
            this.comun = false;
        }

        public float Calcular(Pantalones _pantalon, int cantidad)
        {
            float _resultado = 0;

            _resultado = _pantalon.Precio * cantidad;
            if(!_pantalon.comun)
            {
                _resultado -= ((_resultado * 12) / 100); // Descuento del 12% por ser chupín
            }

            return _resultado;
        }
    }
}
