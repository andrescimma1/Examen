using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeRopa
{
    class Stock
    {
        public int mangaCortaCuelloMao = 200;
        public int mangaCortaNormal = 300;
        public int mangaLargaCuelloMao = 150;
        public int mangaLargaNormal = 350;
        public int pChupin = 1500;
        public int pNormal = 500;
    }

    class Program
    {
        public int Menu(List<Cotizaciones> _cotizaciones, Tienda tienda, Vendedor vendedor, Stock stock)
        {
            string linea;
            int opcion;
            

            Console.WriteLine(tienda.Nombre + "               " + tienda.Direccion);
            Console.WriteLine(vendedor.Nombre + " " + vendedor.Apellido + " | " + vendedor.Codigo);
            Console.WriteLine("\n                 MENU DE OPCIONES");
            Console.WriteLine("1. Cotizar");
            Console.WriteLine("2. Historial cotizaciones");
            Console.WriteLine("3. Salir\n\n");
            Console.Write("Ingrese el número de opción (Ej. 1, 2, etc): ");
            linea = Console.ReadLine();
            opcion = int.Parse(linea);

            Cotizaciones cotizacion = new Cotizaciones();

            if (opcion == 1)
            {
                Console.Clear();

                Console.Write("Ingrese el tipo de prenda (camisa o pantalon): ");
                linea = Console.ReadLine();

                if (linea == "Camisa" || linea == "camisa")
                {
                    Camisas camisa = new Camisas();

                    Console.Write("Indique el tipo de camisa (manga corta o manga larga): ");
                    linea = Console.ReadLine();

                    if (linea == "manga corta" || linea == "Manga corta")
                    {
                        camisa.MangaCorta = true;
                    }
                    else if (linea == "manga larga" || linea == "Manga larga")
                    {
                        camisa.MangaCorta = false;
                    }

                    Console.Write("¿Con cuello mao? (si/no): ");
                    linea = Console.ReadLine();

                    if (linea == "si" || linea == "Si")
                    {
                        camisa.CuelloMao = true;
                    }
                    else if (linea == "no" || linea == "No")
                    {
                        camisa.CuelloMao = false;
                    }

                    Console.Write("Ingrese la calidad de la prenda: (Standar/Premium): ");
                    linea = Console.ReadLine();

                    if(linea == "Premium" || linea == "premium")
                    {
                        camisa.Standar = false;
                    }
                    else if(linea == "Standar" || linea == "standar")
                    {
                        camisa.Standar = true;
                    }

                    Console.Write("Ingrese el precio de la camisa (sin el signo $): ");
                    camisa.Precio = float.Parse(Console.ReadLine());

                    Console.Write("Ingrese la cantidad de camisas: ");
                    int cantidad = int.Parse(Console.ReadLine());

                    int retorno = VerificarStockCamisas(stock, camisa, cantidad);

                    if(retorno == 1)
                    {
                        Console.WriteLine("Stock no disponible");
                    }
                    else
                    {
                        cotizacion.FechaYHora = DateTime.Now.ToString("dd-MM-yyyy | hh:mm:ss");
                        cotizacion.PrendaCotizada = camisa;
                        cotizacion.CantCotizadas = cantidad;
                        cotizacion.Resultado = camisa.Calcular(camisa, cantidad);
                        _cotizaciones.Add(cotizacion);
                        Console.WriteLine("\nEl resultado es: " + cotizacion.Resultado + "\n\n");
                    }
                    
                }
                else if (linea == "pantalon" || linea == "Pantalon")
                {
                    Pantalones pantalon = new Pantalones();

                    Console.Write("Ingrese el tipo de pantalón (chupin/normal): ");
                    linea = Console.ReadLine();

                    if (linea == "chupin" || linea == "Chupin")
                    {
                        pantalon.Comun = false;
                    }
                    else if (linea == "normal" || linea == "Normal")
                    {
                        pantalon.Comun = true;
                    }

                    Console.Write("Ingrese la calidad de la prenda (Standar/Premium): ");
                    linea = Console.ReadLine();

                    if (linea == "Premium" || linea == "premium")
                    {
                        pantalon.Standar = false;
                    }
                    else if (linea == "Standar" || linea == "standar")
                    {
                        pantalon.Standar = true;
                    }

                    Console.Write("Ingrese el precio de la pantalon (sin el signo $): ");
                    pantalon.Precio = float.Parse(Console.ReadLine());

                    Console.Write("Ingrese la cantidad de pantalones: ");
                    int cantidad = int.Parse(Console.ReadLine());

                    int retorno = VerificarStockPantalones(stock, pantalon, cantidad);

                    if (retorno == 1)
                    {
                        Console.WriteLine("Stock no disponible");
                    }
                    else
                    {
                        cotizacion.FechaYHora = DateTime.Now.ToString("dd-MM-yyyy | hh:mm:ss");
                        cotizacion.PrendaCotizada = pantalon;
                        cotizacion.CantCotizadas = cantidad;
                        cotizacion.Resultado = pantalon.Calcular(pantalon, cantidad);
                        _cotizaciones.Add(cotizacion);
                        Console.WriteLine("\nEl resultado es: " + cotizacion.Resultado + "\n\n");
                    }
                }
            }

            else if(opcion == 2)
            {
                Console.Clear();

                Console.WriteLine("*** Historial de cotizaciones ***\n");
                foreach(Cotizaciones c in _cotizaciones)
                {
                    Console.WriteLine("Número de identificación: " + c.NumIdentificación);
                    Console.WriteLine("Fecha y hora: " + c.FechaYHora);
                    Console.WriteLine("Código del vendedor: " + c.CodigoVendedor);
                    if(c.PrendaCotizada.GetType().ToString() == "TiendaDeRopa.Camisas")
                    {
                        Console.WriteLine("Prenda: Camisa");
                    }
                    else if (c.PrendaCotizada.GetType().ToString() == "TiendaDeRopa.Pantalones")
                    {
                        Console.WriteLine("Prenda: Pantalón");
                    }
                    Console.WriteLine("Cantidad: " + c.CantCotizadas);
                    Console.WriteLine("Resultado: $" + c.Resultado);
                    Console.WriteLine("----------------------------------");
                }

                Console.WriteLine("\n");
            }

            return opcion;
        }

        public int VerificarStockCamisas(Stock stock, Camisas _camisa, int cantidad)
        {
            if(_camisa.MangaCorta && _camisa.CuelloMao)
            {
                if(stock.mangaCortaCuelloMao > cantidad)
                {
                    stock.mangaCortaCuelloMao -= cantidad;
                }
                else
                {
                    return 1;
                }
            }
            else if (_camisa.MangaCorta && !_camisa.CuelloMao)
            {
                if (stock.mangaCortaNormal > cantidad)
                {
                    stock.mangaCortaNormal -= cantidad;
                }
                else
                {
                    return 1;
                }
            }
            else if (!_camisa.MangaCorta && _camisa.CuelloMao)
            {
                if (stock.mangaLargaCuelloMao > cantidad)
                {
                    stock.mangaLargaCuelloMao -= cantidad;
                }
                else
                {
                    return 1;
                }
            }
            else if (!_camisa.MangaCorta && !_camisa.CuelloMao)
            {
                if (stock.mangaLargaNormal > cantidad)
                {
                    stock.mangaLargaNormal -= cantidad;
                }
                else
                {
                    return 1;
                }
            }

            return 0;
        }

        public int VerificarStockPantalones(Stock stock, Pantalones _pantalon, int cantidad)
        {
            if (!_pantalon.Comun)
            {
                if (stock.pChupin > cantidad)
                {
                    stock.pChupin -= cantidad;
                }
                else
                {
                    return 1;
                }
            }
            else if (_pantalon.Comun)
            {
                if (stock.pNormal > cantidad)
                {
                    stock.pNormal -= cantidad;
                }
                else
                {
                    return 1;
                }
            }

            return 0;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            List<Cotizaciones> cotizaciones = new List<Cotizaciones>();
            Tienda tienda = new Tienda();
            Vendedor vendedor = new Vendedor();
            Stock stock = new Stock();

            
            int opcion;

            do
            {
                opcion = program.Menu(cotizaciones, tienda, vendedor, stock);
            } while (opcion != 3);


            Console.ReadKey();
        }
    }
}
