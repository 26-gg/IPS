using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Entity;


namespace CapaPresentecion
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string identificacion;
            string sexo;
            int edad;
            Persona persona;
            ConsoleKeyInfo opcion;
            PersonaService Servicio = new PersonaService();
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("digite sus datos");
                    Console.WriteLine("digite su nombre");
                    nombre = Console.ReadLine();
                    Console.WriteLine("digite su identificacion");
                    identificacion = Console.ReadLine();
                    Console.WriteLine("digite el sexo");
                    sexo = Console.ReadLine();
                    Console.WriteLine("digite su edad");
                    edad = Convert.ToInt32(Console.ReadLine());

                    persona = new Persona(identificacion, nombre, sexo, edad);

                    Servicio.CalcularPulsaciones(persona);
                    Console.WriteLine(Servicio.Guardar(persona));
                    persona.ToString();

                }
                catch (Exception e)
                {

                    Console.WriteLine("Error" + e.Message);
                }
                Console.WriteLine("Desea continuar (s/n)");
                opcion = Console.ReadKey();

            } while (opcion.Key == ConsoleKey.S);

            Console.Clear();
            Console.WriteLine("Consulta de pulsaciones");
            foreach (var item in Servicio.Consultar()) ;
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Digite la identificacion a eliminar");
            identificacion = Console.ReadLine();
            Console.WriteLine(Servicio.Eliminar(Servicio.Buscar(identificacion)));

            Console.WriteLine("Consulta de pulsaciones");
            foreach (var item in Servicio.Consultar())
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
}