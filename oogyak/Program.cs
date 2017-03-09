using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oogyak
{
    class Program
    {
        static void Main(string[] args)
        {
            // példányosítás
            // ahol "sub" az "osztály"(class) / típus(type)
            // "s" a "példány"(instance)/"objektum"(object)
            abc s = new abc();

            // teszteljük láthatóságot öröklési láncon kívülről
            //s.b++; nem érhető el kívűlről mert protected
            s.c++; // elérhető mert public

            s.P1 = 12; // P1 property set(ter) része aktiválódik, a value kulcsszó 12-t tartalmaz
            Console.WriteLine(s.P1); // P1 property get(ter) része aktiválódik

            // ugyanaz megoldva getter és setter metódusokkal
            s.setP1(12);
            Console.WriteLine(s.getP1());

            // s.P2 = 5; mert a P2 property setter-e protected
            Console.WriteLine(s.P2);



        }
    }
}
