using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oogyak
{
    // asd osztály leszármazik az "abc" osztályból
    // és implemntálja (implement) / realizálja (realize) az "ijk" interfészt
    class asd : abc, ijk, bnm
    {
        // xyz::f4 abstract metódust itt realizáljuk
        public override void f4()
        {           
        }

        // "ijk" interfész osztályból származó metódus implementálása
        public void f8()
        {
        }

        // "ijkos" interfész osztályból származó metódus implementálása
        public void f9()
        {         
        }


        // túlterhelés (overloading) példa
        // overload-nál csak a paraméterek különböznek
        public void f10() {}
        public void f10(int p) {}
        public void f10(string p) { }
        // public int f10() { return 1; } // a visszatérésben nem változhat
        public int f10(int p1, int p2) { return 3; }

        // member hiding példa folytatás

        public void f11() {
            base.f11(); // korábbi (hide-olt) metódus hívása
            Console.WriteLine("asd::f11");
        }

        public int akarmi;


        // osztályhoz kötődő statikus adattag (static data member) kezdőértékkel
        public static int si = 34;

        // statikus konstruktor/inicilaizator (static constructor)
        // feladata a statikus adattagok inicializálása
        // akkor hívódik meg amikor először használjuk az osztályt
        static asd(){
            si = 112;
        }

        public static void f12(this) // osztályhoz kötődő statikus metódus (NEM STATIKUS KÖTÉSŰ metódus !4!4!!!!!!!44!!!)
        {
            // statikus metódusban nincs "this", mert osztályhoz kötődik, a "this" pedig objektumhoz kötődik
            //this.akarmi = 34;

            // "akarmi" az objektumhoz (példányhoz kötődő adattag)
            //akarmi = 34;

            // objektumhoz kötődő metódus
            //f4(); // dinamikus kötésű nem static metódus 

            // objektumhoz kötődő metódus
            //f10(); // statikus kötésű nem static metódus

            f13(); // hívható mert statikus mettódus

            si = 78; // static adattag
        }


        // xyz::f3 mellett egy új asd::f3 bejegyzés fog keletkezni a VM Táblában
        public virtual new void f3()
        {
        }

        public void f20()
        {
            throw new NotImplementedException();
        }
    }
}
