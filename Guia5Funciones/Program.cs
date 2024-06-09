using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Guia5Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1.
             * Desarrolla 3 funciones sin argumentos.
             * Funcion 1: Debe devolver un msj de bienvenida
             * Funcion 2: Solicitar nombre y edad
             * Funcion 3: Llamar a funcion 1 y funcion 2. Mostrar 
             * bienvenida y datos del cliente.
            */
            /*
            string nombre;
            int edad;

            void Bienvenida() 
            {
                Console.WriteLine("Bienvenido al sistema de gestion de clientes.");
            }

            void PedirDatos()
            {
                Console.Write("Ingrese nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese edad: ");
                edad = int.Parse(Console.ReadLine());
            }

            void ImprimirBienvenidaDatos()
            {
                PedirDatos();
                Console.Clear(); //Limpia consola
                Bienvenida();
                Console.WriteLine("Nombre: " + nombre );
                Console.WriteLine("Edad: " + edad);
            }
            
            ImprimirBienvenidaDatos();
            Console.ReadLine();
            */
            /*
             * 2. Desarrolle un programa que realice lo siguiente:
             * - Pida al usuario que ingrese numeros de un digito(0-9) repetidamente
             * - El bucle de entrada de continuar hasta que ingrese la letra N.
             * - Por cada numero ingresado, el programa debe llamar a una funcion 
             * que reciba el numero como parametro y devuelva su cuadrado. 
             * - El programa debe imprimir el numero originar y su cuadrado despues 
             * de cada entrada valida.
            */
            /*
            string opcion;
            int numero; 

            int CalcularCuadrado(int numEntero)
            {
                return numEntero * numEntero;
            }
            
            //Metodo principal
            Console.WriteLine("Ingrese un numero de un digito (0-9) o 'N' para salir");
            opcion = Console.ReadLine();
            while (opcion != "N")
            {
                numero = int.Parse(opcion);
                Console.WriteLine($"{numero} al cuadrado es {CalcularCuadrado(numero)}" );
                Console.WriteLine("Ingrese un numero de un digito (0-9) o 'N' para salir");
                opcion = Console.ReadLine();
            }
            */
            /*
             * 3.
             * Practica: Sin argumentos ni return en los metodos
             * Primer metodo: 
             * - nombre: Mostrar Bienvenida
             * - Debe imprimir un mensaje de bienvenida
             * Segundo metodo:
             * - Nombre: Mostrar instrucciones
             * - Debe imprimir instrucciones lavarse las manos.
            */
            /*
            void MostrarBienvenida()
            {
                Console.WriteLine("Bienvenido al programa.");
            }

            void MostrarInstrucciones() 
            {
                Console.WriteLine("1. Moje sus manos con agua limpia y corriente (tibia o fría), cierre el grifo y aplique jabón.");
                Console.WriteLine("2. Enjabone las manos frotando con el jabón. Enjabone la parte posterior de las manos, entre los dedos y debajo de las uñas.");
                Console.WriteLine("3. Frote sus manos durante al menos 20 segundos.");
                Console.WriteLine("4. Enjuague sus manos bien bajo agua limpia y corriente.");
                Console.WriteLine("5. Seque sus manos con una toalla limpia o séquelas al aire.");
            }

            MostrarBienvenida();
            MostrarInstrucciones();
            Console.ReadLine();
            */
        }
    }
}
