using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonPlua3B.TAD_LISTA
{
    public class CNodo
    {
        private int dato;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public CNodo siguiente;

        public CNodo()
        {
            siguiente = null;
        }
    }

    class CLista
    {
        CNodo cabeza;

        public CLista()
        {
            cabeza = null;                                  //lista vacia
        }

        public void InsertarDato(int dat)
        {
            CNodo NuevoNodo;                                    //Nuevo nodo
            CNodo antes, luego;                                 //señal de antes y despues
            NuevoNodo = new CNodo();                            //creo un nuevo nodo
            NuevoNodo.Dato = dat;                                 //guardo el dato, en ese nuevo nodo
            int ban = 0;
            if (cabeza == null)
            {                                                       //preguntar si cabeza esta vacia
                NuevoNodo.siguiente = null;                       //indico que hay mas datos y se guarda hay
                cabeza = NuevoNodo;                             //dato se convierte en cabeza
            }
            else
            {
                if (dat < cabeza.Dato)
                {                                               //si dato es menor ah cabeza
                    NuevoNodo.siguiente = cabeza;             //ingresar dato antes de dato mayor
                    cabeza = NuevoNodo;                     //nuevo dato se convierte en cabeza
                }
                else
                {
                    antes = cabeza;                       //empieza en cabeza
                    luego = cabeza;                       //empieza en cabeza
                    while (ban == 0)
                    {                                       //bandera apagada
                        if (dat >= luego.Dato)
                        {          //dato mayor a luego
                            antes = luego;                //antes avanza y ocupa el lugar de siguiente
                            luego = luego.siguiente;      //luego avanza a dato siguiente
                        }
                        if (luego == null)
                        {               
                            ban = 1;    
                        }
                        else
                        {
                            if (dat < luego.Dato)
                            {   
                                ban = 1;
                            }
                        }
                    }
                    antes.siguiente = NuevoNodo;          //antes se convierte en nuevo nodo
                    NuevoNodo.siguiente = luego;          //nuevo nodo siguiente se convierte en luego
                }                                                  //FINAL DEL CODIGO//
            }
        }

        public void EliminarDato(int dat)
        {
            CNodo antes, luego;
            int ban = 0;
            if (Vacia())
            {
                Console.WriteLine("Lista vacía ");
                Console.ReadKey();
                
            }
            else
            {
                if (dat < cabeza.Dato)
                {
                    Console.WriteLine("dato no existe en la lista ");
                    Console.ReadKey();
                }
                else
                {
                    if (dat == cabeza.Dato)
                    {
                        cabeza = cabeza.siguiente;
                    }
                    else
                    {
                        antes = cabeza;
                        luego = cabeza;
                        while (ban == 0)
                        {
                            if (dat > luego.Dato)
                            {
                                antes = luego;
                                luego = luego.siguiente;
                            }
                            else ban = 1;
                            if (luego == null)
                            {
                                ban = 1;
                            }
                            else
                            {
                                if (luego.Dato == dat)
                                    ban = 1;
                            }
                        }
                        if (luego == null)
                        {
                            Console.WriteLine("dato no existe en la Lista ");
                            Console.ReadKey();
                        }
                        else
                        {
                            if (dat == luego.Dato)
                            {
                                antes.siguiente = luego.siguiente;
                            }
                            else
                                Console.WriteLine("dato no existe en la Lista ");
                                Console.ReadKey();
                        }
                    }
                }
            }
        }

        public Boolean Vacia()
        {
            return (cabeza == null);
        }

        public void VisualizarDatos()
        {
            CNodo Temporal;
            Temporal = cabeza;
            if (!Vacia())
            {
                while (Temporal != null)
                {
                    Console.WriteLine(" " + Temporal.Dato + " ");
                    Temporal = Temporal.siguiente;
                }
                Console.WriteLine("");
            }
            else
                Console.WriteLine("Lista vacía");
        }
    }
}