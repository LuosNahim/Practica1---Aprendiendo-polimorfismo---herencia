using System;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {

            Avion test = new Avion();
            test.Arrancar();
            test.Conducir();
        }
    }

    class Vehiculo
    {
        public void Arrancar()
        {
            Console.WriteLine( "He arrancado el motor");
        }
        public void Parar()
        {
            Console.WriteLine("El motor se ha detenido");
        }
        public virtual void Conducir()
        {
            Console.WriteLine("conducir el vehiculo");
        }

    }

    class Avion :Vehiculo
    {
        public void Volar()
        {
            Console.WriteLine("Volando");
        }
        public override void Conducir()
        {
            Console.WriteLine("COnduciendo un AVION");
        }
    }
    class Coche : Vehiculo
    {
         public void Moverse()
        {
        Console.WriteLine("cicular en las calles");
        }
        public override void Conducir()
        {
            Console.WriteLine("COnduce un coche");
        }
    }




}
