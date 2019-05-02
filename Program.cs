using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndersonPlua3B.TAD_LISTA;

namespace AndersonPlua3B
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CLista objLista = new CLista();
            CLista objLista2 = new CLista();

            Console.Write("Lista Original:");
            objLista.InsertarDato(9);
            objLista.InsertarDato(20);

            objLista2.InsertarDato(7);

            objLista.VisualizarDatos();

            Console.Write("\nLista 1 : ");
            //objLista.EliminarDato(1);
            objLista.VisualizarDatos();

            Console.Write("\nLista 2 : ");
            //  objLista.EliminarDato(1);
            objLista2.VisualizarDatos();
            Console.ReadKey();
        }
    }
}
