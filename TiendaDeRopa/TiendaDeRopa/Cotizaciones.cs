using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeRopa
{
    class Cotizaciones : Vendedor
    {
        private int numIdentificación;
        private String fechaYHora;
        private String codigoVendedor;
        private Prenda prendaCotizada;
        private int cantCotizadas;
        private float resultado;

        public int NumIdentificación { get => numIdentificación; set => numIdentificación = value; }
        public String FechaYHora { get => fechaYHora; set => fechaYHora = value; }

        public String CodigoVendedor { get => codigoVendedor; set => codigoVendedor = value; }
        public Prenda PrendaCotizada { get => prendaCotizada; set => prendaCotizada = value; }
        public int CantCotizadas { get => cantCotizadas; set => cantCotizadas = value; }
        public float Resultado { get => resultado; set => resultado = value; }
        

        public Cotizaciones()
        {
            this.CodigoVendedor = Codigo;
            this.NumIdentificación = 152;
        }
    }
}
