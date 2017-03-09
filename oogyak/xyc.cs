using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oogyak
{
    // class osztály, típus(type)
    // absztrakt osztály, mert legalább 1 metódusa absztrakt (abstract class)
    abstract class xyz // egységbezárás / encapsulation (data+code)
    {        

        // Data -members / data field / attributes
        // Data hiding / Protection level / visibility levels / PPP
        private int a; // csak basec osztályon belül
        protected int b; // basec és leszármazottain belül
        public int c; // mindenki számára

        // elnevezési konvenziók változókra (code convention)
        // belső változóknál: _Valami, mValami, valami, Valami
        // példa: I, mI

        // C# kiterjesztés property-k
       
        int mP1; // belső változó / inner variable

        // Property (tulajdonság)
        public int P1
        {
            get
            {
                return mP1;
            }
            set
            {
                mP1 = value;
            }
        }

        public int getP1() // getter
        {
            return mP1;
        }

        public void setP1(int value) // setter
        {
            mP1 = value;
        }

        int mP2;

        public int P2
        {
            get
            {
                return mP2;
            }
            protected set // P2 property csak öröklési láncon belül állítható
            { 
                mP2 = value;
            }
        }

        // automatikus property
        // nem kell külön belső változó (mP3)
        public int P3 { get; set; }

        // automatikus property inicializálással
        public int P4 { get; set; } = 42;

        // csak get-elhető automatikus property, inicializálással
        public int P5 { get; } = 67;

        // függvénytagok / metódusok(methods)
        public void f1() // statikus kötésű metódus (NEM STATIC !!!444!!4!!4!)
        {
            Console.WriteLine("xyz::f1");
        }

        public virtual void f2() // dinamikus kötésű metódus, virtuális metódus (virtual method)
        {
            Console.WriteLine("xyz::f2");
        }

        public abstract void f3(); // dinamikus kötésű absztract metódus (abstract method). Absztrakt metódus == virtuális metódus törzs nélkül/ kifejtés nélkül

        public abstract void f4(); // dinamikus kötésű absztract metódus (abstract method). Absztrakt metódus == virtuális metódus törzs nélkül/ kifejtés nélkül

        // member hiding példa
        public void f11() { Console.WriteLine("xyz::f11"); } // statikus kötésű metódus

        // static method példa
        protected static void f13()
        {

        }
    }
}
