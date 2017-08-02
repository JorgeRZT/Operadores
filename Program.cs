using System;

namespace RedefinirOperador
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona1 = new Persona() { Nombre = "Minerva" };
            var persona2 = new Persona() { Nombre = "Minerva" };

            Console.Write("La persona con nombre " + persona1.Nombre + " y la persona con nombre " + persona2.Nombre);
            if (persona1 == persona2) Console.WriteLine(" son la misma persona"); else Console.WriteLine(" son distintas personas");

            Console.ReadLine();
        }
    }

    public class Persona
    {
        public String Nombre { get; set; }

        public static Boolean operator !=(Persona a, Persona b) { return !(a.Nombre.Equals(b.Nombre)); }
        public static Boolean operator ==(Persona a, Persona b) { return (a.Nombre.Equals(b.Nombre)); }
    }
}