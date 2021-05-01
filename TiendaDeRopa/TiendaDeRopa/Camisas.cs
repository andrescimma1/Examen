using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeRopa
{
    class Camisas : Prenda
    {
        private bool mangaCorta;
        private bool cuelloMao;

        public bool MangaCorta { get => mangaCorta; set => mangaCorta = value; }
        public bool CuelloMao { get => cuelloMao; set => cuelloMao = value; }

        public Camisas()
        {
            this.cuelloMao = false;
            this.mangaCorta = false;
            this.Stock = 1000;
        }

        public float Calcular(Camisas _camisa, int cantidad)
        {
            float _resultado = 0;

            _resultado = _camisa.Precio * cantidad;
            
            if(_camisa.mangaCorta)
            {
                _resultado -= ((_resultado * 10) / 100); // Descuento del 10% por ser manga corta
            }

            if(_camisa.cuelloMao)
            {
                _resultado += ((_resultado * 3) / 100); // Aumento del 3% por tener cuello mao
            }

            if(!_camisa.Standar)
            {
                _resultado += ((_resultado * 30) / 100); // Aumento del 30% por ser Premium
            }

            return _resultado;
        }
    }
}
