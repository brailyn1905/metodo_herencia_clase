using System;
namespace practica
{
    public class rentcard
    {
        public string marca;
        public string tipo;
        public string ano;


    }

    public class Alquiler : rentcard

    {
        public string nombre;
        public string tiempoAlquiler;

           public void pedirdatos()
        {
            Console.WriteLine("escriba su nombre");
            string nombre=Console.ReadLine();
            Console.WriteLine("tiempo de renta ");
            int dias  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("tipo de vehiculo ");
            string tipo = Console.ReadLine();

            Console.WriteLine("los datos obtenidos son:"+"lo rento " + nombre + "durante  " + dias + " dias "+","+" del tipo  "+tipo );

        }
        


    }
    
   

    class program
    {
        static void Main(string[] args)
        {
            Alquiler miAlquiler = new Alquiler();
            miAlquiler.pedirdatos();




        }




    }

}